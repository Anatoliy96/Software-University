using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups = int.Parse(Console.ReadLine());

            double totalNumberOfPeople = 0;
            double peopleOfMusala = 0;
            double peopleOfMontblanc = 0;
            double peopleOfKilimanjaro = 0;
            double peopleOfK2 = 0;
            double peopleOfEverest = 0;


            for (int i = 0; i < numberOfGroups; i++)
            {
                int numberOfPeopleInGroup = int.Parse(Console.ReadLine());

                if (numberOfPeopleInGroup <= 5)
                {
                    peopleOfMusala += numberOfPeopleInGroup;
                }
                else if (numberOfPeopleInGroup >= 6 && numberOfPeopleInGroup <= 12)
                {
                    peopleOfMontblanc += numberOfPeopleInGroup;
                }
                else if (numberOfPeopleInGroup >= 13 && numberOfPeopleInGroup <= 25)
                {
                    peopleOfKilimanjaro += numberOfPeopleInGroup;
                }
                else if (numberOfPeopleInGroup >= 26 && numberOfPeopleInGroup <= 40)
                {
                    peopleOfK2 += numberOfPeopleInGroup;
                }
                else if (numberOfPeopleInGroup >= 41)
                {
                    peopleOfEverest += numberOfPeopleInGroup;
                }
                totalNumberOfPeople += numberOfPeopleInGroup;
            }

            double percentOfMusala = peopleOfMusala / totalNumberOfPeople * 100;
            double percentOfMontBlanc = peopleOfMontblanc / totalNumberOfPeople * 100;
            double percentOfKilimandjaro = peopleOfKilimanjaro / totalNumberOfPeople * 100;
            double percentOfK2 = peopleOfK2 / totalNumberOfPeople * 100;
            double percentOfEveres = peopleOfEverest / totalNumberOfPeople * 100;

            Console.WriteLine($"{percentOfMusala:f2}%");
            Console.WriteLine($"{percentOfMontBlanc:f2}%");
            Console.WriteLine($"{percentOfKilimandjaro:f2}%");
            Console.WriteLine($"{percentOfK2:f2}%");
            Console.WriteLine($"{percentOfEveres:f2}%");
        }
    }
}
