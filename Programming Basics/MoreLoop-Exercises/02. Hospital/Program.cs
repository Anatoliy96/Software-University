using System;

namespace _02._Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            int numberOfDoctors = 7;
            int treatedPacients = 0;
            int unTreatedPacients = 0;

            for (int i = 1; i <= period; i++)
            {
                int numberOfPacients = int.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    if (unTreatedPacients > treatedPacients)
                    {
                        numberOfDoctors++;
                    }
                }

                if (numberOfDoctors < numberOfPacients)
                {
                    treatedPacients += numberOfDoctors;
                    unTreatedPacients += numberOfPacients - numberOfDoctors;
                }
                else
                {
                    treatedPacients += numberOfPacients;
                }
                

            }
            Console.WriteLine($"Treated patients: {treatedPacients}.");
            Console.WriteLine($"Untreated patients: {unTreatedPacients}.");
        }
    }
}
