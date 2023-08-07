using BankLoan.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLoan.Models
{
    public abstract class Bank : IBank
    {
        private string name;
        private int capacity;
        private readonly List<ILoan> loans;
        private readonly List<IClient> clients;

        public Bank(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;

            loans = new List<ILoan>();
            clients = new List<IClient>();
        }

        public string Name
        {
            get => name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Bank name cannot be null or empty.");
                }

                name = value;
            }
        }

        public int Capacity { get => capacity; private set => capacity = value; }

        public IReadOnlyCollection<ILoan> Loans => loans.AsReadOnly();

        public IReadOnlyCollection<IClient> Clients => clients.AsReadOnly();

        public void AddClient(IClient Client)
        {
            if (this.Capacity > clients.Count)
            {
                clients.Add(Client);
            }
            else
            {
                throw new ArgumentException("Not enough capacity for this client.");
            }
        }

        public void AddLoan(ILoan loan)
        {
            loans.Add(loan);
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {this.Name}, Type: {this.GetType().Name}");

            if (clients.Count == 0)
            {
                sb.AppendLine($"Clients: none");
            }
            else
            {
                sb.AppendLine($"Clients: {String.Join(", ", clients.Select(c => c.Name))}");
            }

            sb.AppendLine($"Loans: {loans.Count}, Sum of Rates: {SumRates()}");

            return sb.ToString().TrimEnd();
        }

        public void RemoveClient(IClient Client)
        {
            clients.Remove(Client);
        }

        public double SumRates()
        {
            double sum = 0;

            foreach (var loan in loans)
            {
                sum += loan.InterestRate;
            }

            return sum;
        }
    }
}
