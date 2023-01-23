using System;

namespace _02._From_Left
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long sum = 0;

            for (int i = 0; i < n; i++)
            {
                string numbers = Console.ReadLine();

                string firsNum = numbers.Substring(0, numbers.IndexOf(" "));
                string secondNum = numbers.Substring(numbers.IndexOf(" ") + 1);

                long.TryParse(firsNum, out long num);
                long.TryParse(secondNum, out long num2);

                if (num >= num2)
                {
                    while (num != 0)
                    {
                        sum += num % 10;

                        num /= 10;
                    }
                }
                else if (num2 > num)
                {
                    while (num2 != 0)
                    {
                        sum += num2 % 10;

                        num2 /= 10;
                    }
                }
                Console.WriteLine(Math.Abs(sum));

                sum = 0;
            }
        }
    }
}
