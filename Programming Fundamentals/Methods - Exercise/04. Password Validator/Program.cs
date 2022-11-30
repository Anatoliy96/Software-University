using System;
using System.Linq;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            PasswordValidator(password);
            
        }

        static string PasswordValidator(string password)
        {
            bool isValid = true;
            int count = 0;

            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (password.Contains("@") || password.Contains("#")
                || password.Contains("!") || password.Contains("~")
                || password.Contains("$") || password.Contains("%")
                || password.Contains("^") || password.Contains("&")
                || password.Contains("*") || password.Contains("(")
                || password.Contains(")") || password.Contains("-")
                || password.Contains("+") || password.Contains("/")
                || password.Contains(":") || password.Contains(".")
                || password.Contains(", ") || password.Contains("<")
                || password.Contains(">") || password.Contains("?")
                || password.Contains("|"))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    isValid = false;
                }

            if (true)
            {
                for (int i = 0; i < 9; i++)
                {
                    string str1 = i.ToString();

                    if (password.Contains(str1))
                    {
                        count++;
                    }
                }

                if (count < 2)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }

            if (password.Length >= 6 && password.Length <= 10 && isValid == true && count >= 2)
            {
                Console.WriteLine("Password is valid");
            }
                return password;
        }
    }
}
