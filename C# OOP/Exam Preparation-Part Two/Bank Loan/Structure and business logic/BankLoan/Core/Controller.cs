using BankLoan.Core.Contracts;
using BankLoan.Models;
using BankLoan.Models.Contracts;
using BankLoan.Repositories;
using BankLoan.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankLoan.Core
{
    public class Controller : IController
    {
        private IRepository<IBank> banks;
        private IRepository<ILoan> loans;

        public Controller()
        {
            banks = new BankRepository();
            loans = new LoanRepository();
        }

        public string AddBank(string bankTypeName, string name)
        {
            IBank bank = null;

            if (bankTypeName != typeof(CentralBank).Name && bankTypeName != typeof(BranchBank).Name)
            {
                throw new ArgumentException("Invalid bank type.");
            }

            if (bankTypeName == typeof(CentralBank).Name) 
            {
                bank = new CentralBank(name);
            }
            else if (bankTypeName == typeof(BranchBank).Name)
            {
                bank = new BranchBank(name);
            }

            banks.AddModel(bank);

            return $"{bankTypeName} is successfully added.";
        }

        public string AddClient(string bankName, string clientTypeName, string clientName, string id, double income)
        {
            IClient client = null;

            if (clientTypeName != typeof(Student).Name && clientTypeName != typeof(Adult).Name)
            {
                return "Invalid client type.";
            }

            IBank bank = banks.FirstModel(bankName);

            if (clientTypeName == typeof(Student).Name && bank.GetType().Name == typeof(CentralBank).Name 
                || clientTypeName == typeof(Adult).Name && bank.GetType().Name == typeof(BranchBank).Name)
            {
                return "Unsuitable bank.";
            }

            if (clientTypeName == typeof(Student).Name)
            {
                client = new Student(clientName, id, income);
            }
            else if (clientTypeName == typeof(Adult).Name)
            {
                client = new Adult(clientName, id, income);
            }

            bank.AddClient(client);

            return $"{clientTypeName} successfully added to {bankName}.";
        }

        public string AddLoan(string loanTypeName)
        {
            ILoan loan = null;

            if (loanTypeName != typeof(MortgageLoan).Name && loanTypeName != typeof(StudentLoan).Name)
            {
                throw new ArgumentException("Invalid loan type.");
            }

            if (loanTypeName == typeof(MortgageLoan).Name)
            {
                loan = new MortgageLoan();
            }
            else if (loanTypeName == typeof(StudentLoan).Name)
            {
                loan = new StudentLoan();
            }

            loans.AddModel(loan);

            return $"{loanTypeName} is successfully added.";
        }

        public string FinalCalculation(string bankName)
        {
            IBank bank = banks.FirstModel(bankName);

            double incomeFromClients = 0;
            double incomeFromLoans = 0;
            double totalAmount = 0;

            foreach (var client in bank.Clients)
            {
                incomeFromClients += client.Income;
            }

            foreach (var loan in bank.Loans)
            {
                incomeFromLoans += loan.Amount;
            }

            totalAmount = incomeFromLoans + incomeFromClients;

            return $"The funds of bank {bankName} are {totalAmount:f2}.";
        }

        public string ReturnLoan(string bankName, string loanTypeName)
        {
            ILoan loan = loans.FirstModel(loanTypeName);

            if (loan == null)
            {
                return $"Loan of type {loanTypeName} is missing.";
            }

            IBank bank = banks.FirstModel(bankName);

            bank.AddLoan(loan);
            loans.RemoveModel(loan);

            return $"{loanTypeName} successfully added to {bankName}.";
        }

        public string Statistics()
        {
            StringBuilder sb = new StringBuilder();

            foreach (IBank bank in banks.Models)
            {
                sb.AppendLine(bank.GetStatistics());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
