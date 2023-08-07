using BankLoan.Core.Contracts;
using BankLoan.Models;
using BankLoan.Models.Contracts;
using BankLoan.Repositories;
using BankLoan.Repositories.Contracts;
using BankLoan.Utilities.Messages;
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
        private IRepository<ILoan> loans;
        private IRepository<IBank> banks;

        public Controller()
        {
            loans = new LoanRepository();
            banks = new BankRepository();
        }

        public string AddBank(string bankTypeName, string name)
        {
            if (bankTypeName != nameof(BranchBank) && bankTypeName != nameof(CentralBank))
            {
                return $"Invalid bank type.";
            }

            if (bankTypeName == nameof(BranchBank))
            {
                banks.AddModel(new BranchBank(name));
            }

            if (bankTypeName == nameof(CentralBank))
            {
                banks.AddModel(new CentralBank(name));
            }

            return $"{bankTypeName} is successfully added.";


        }

        public string AddClient(string bankName, string clientTypeName, string clientName, string id, double income)
        {
            IClient currentClient;

            //Checking The Client's Type
            if (clientTypeName == nameof(Student))
            {
                currentClient = new Student(clientName, id, income);
            }
            else if (clientTypeName == nameof(Adult))
            {
                currentClient = new Adult(clientName, id, income);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.ClientTypeInvalid);
            }

            IBank currentBank = banks.FirstModel(bankName);

            //Client Type Name Is Not A Valid Client Type Of The Current Bank
            if (currentBank.GetType().Name == nameof(BranchBank) && currentClient.GetType().Name == nameof(Adult)
                || currentBank.GetType().Name == nameof(CentralBank) && currentClient.GetType().Name == nameof(Student))
            {
                return OutputMessages.UnsuitableBank;
            }

            //Successfully Adding The Client To The Bank
            currentBank.AddClient(currentClient);
            return String.Format(OutputMessages.ClientAddedSuccessfully, clientTypeName, bankName);
        }

        public string AddLoan(string loanTypeName)
        {
            if (loanTypeName != nameof(StudentLoan) && loanTypeName != nameof(MortgageLoan))
            {
                return $"Invalid loan type.";
            }

            if (loanTypeName == nameof(StudentLoan))
            {
                loans.AddModel(new StudentLoan());
            }

            if (loanTypeName == nameof(MortgageLoan))
            {
                loans.AddModel(new MortgageLoan());
            }

            return $"{loanTypeName} is successfully added.";
        }

        public string FinalCalculation(string bankName)
        {
            var bank = banks.FirstModel(bankName);

            double incomeFromeClients = 0;
            double incomeFromLoans = 0;
            double totalSum = 0;

            foreach (var client in bank.Clients)
            {
                incomeFromeClients += client.Income;
            }

            foreach (var loan in bank.Loans)
            {
                incomeFromLoans += loan.Amount;
            }

            totalSum = incomeFromeClients + incomeFromLoans;

            return $"The funds of bank {bankName} are {totalSum:f2}.";
        }

        public string ReturnLoan(string bankName, string loanTypeName)
        {
            var loan = loans.FirstModel(loanTypeName);
            var bank = banks.FirstModel(bankName);

            if (loan == null)
            {
                return $"Loan of type {loanTypeName} is missing.";
            }

            bank.AddLoan(loan);
            loans.RemoveModel(loan);

            return $"{loanTypeName} successfully added to {bankName}.";
        }

        public string Statistics()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var bank in banks.Models)
            {
                sb.AppendLine(bank.GetStatistics());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
