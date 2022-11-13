using System;

namespace _07._Safe_Passwords_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int numberOfGeneratedPasswords = int.Parse(Console.ReadLine());

            char A = ((char)35);
            char B = ((char)64);
            char C = ((char)55);
            char D = ((char)96);
            int counter = 0;

            for (char i = A; i <= C; i++)
            {
                for (char j = B; j <= D; j++)
                {
                    for (int k = 1; k <= a; k++)
                    {
                        for (int l = 1; l <= b; l++)
                        {
                            Console.Write($"{i}{j}{k}{l}{j}{i}|");

                            i++;
                            j++;
                            
                            counter++;

                            if (counter >= numberOfGeneratedPasswords || k == a && l == b)
                            {
                                return;
                            }

                            if (i > C)
                            {
                                i = A;
                            }

                            if (j > D)
                            {
                                j = B;
                            }
                        }
                    }
                }
            }
        }
    }
}
