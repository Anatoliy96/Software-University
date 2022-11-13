using System;

namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountDeposited = double.Parse(Console.ReadLine());
            int termOfDeposit = int.Parse(Console.ReadLine());
            double annualInterestRate = double.Parse(Console.ReadLine());

            double sum = amountDeposited + termOfDeposit * ((amountDeposited * annualInterestRate / 100) / 12);

            Console.WriteLine(sum);
        }
    }
}
