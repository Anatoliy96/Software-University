using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int iTwin = 0;
            

            for (int i = 1111; i <= 9999; i++)
            {
                bool isSpecialNumber = true;
                iTwin = i;
                
                for (int j = 1; j <= 4; j++)
                {
                    int lastDigit = iTwin % 10;

                    if (lastDigit == 0)
                    {
                        isSpecialNumber = false;
                        break;
                    }

                    int remainder = n % lastDigit;

                    if (remainder != 0)
                    {
                        isSpecialNumber = false;
                        break;
                    }

                    iTwin /= 10;
                }

                if (isSpecialNumber)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
