using System;

namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWebBrowsers = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            int facebook = 150;
            int instagram = 100;
            int reddit = 50;

            for (int i = 1; i <= numberOfWebBrowsers; i++)
            {
                string browser = Console.ReadLine();

                if (browser == "Facebook")
                {
                    salary -= facebook;
                }
                else if (browser == "Instagram")
                {
                    salary -= instagram;
                }
                else if (browser == "Reddit")
                {
                    salary -= reddit;
                }
            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
