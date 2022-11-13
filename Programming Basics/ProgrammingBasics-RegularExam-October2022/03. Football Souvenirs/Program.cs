using System;

namespace _03._Football_Souvenirs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string souvenir = Console.ReadLine();
            int numberOfSouvenirs = int.Parse(Console.ReadLine());

            double sum = 0;

            if (team == "Argentina")
            {
                if (souvenir == "flags")
                {
                   sum = numberOfSouvenirs * 3.25;
                }
                else if (souvenir == "caps")
                {
                    sum = numberOfSouvenirs * 7.20;
                }
                else if (souvenir == "posters")
                {
                    sum = numberOfSouvenirs * 5.10;
                }
                else if (souvenir == "stickers")
                {
                    sum = numberOfSouvenirs * 1.25;
                }
            }
            else if (team == "Brazil")
            {
                if (souvenir == "flags")
                {
                    sum = numberOfSouvenirs * 4.20;
                }
                else if (souvenir == "caps")
                {
                    sum = numberOfSouvenirs * 8.50;
                }
                else if (souvenir == "posters")
                {
                    sum = numberOfSouvenirs * 5.35;
                }
                else if (souvenir == "stickers")
                {
                    sum = numberOfSouvenirs * 1.20;
                }
            }
            else if (team == "Croatia")
            {
                if (souvenir == "flags")
                {
                    sum = numberOfSouvenirs * 2.75;
                }
                else if (souvenir == "caps")
                {
                    sum = numberOfSouvenirs * 6.90;
                }
                else if (souvenir == "posters")
                {
                    sum = numberOfSouvenirs * 4.95;
                }
                else if (souvenir == "stickers")
                {
                    sum = numberOfSouvenirs * 1.10;
                }
            }
            else if (team == "Denmark")
            {

                if (souvenir == "flags")
                {
                    sum = numberOfSouvenirs * 3.10;
                }
                else if (souvenir == "caps")
                {
                    sum = numberOfSouvenirs * 6.50;
                }
                else if (souvenir == "posters")
                {
                    sum = numberOfSouvenirs * 4.80;
                }
                else if (souvenir == "stickers")
                {
                    sum = numberOfSouvenirs * 0.90;
                }
            }

            if (team == "Argentina" || team == "Brazil" || team == "Croatia" || team == "Denmark")
            {
                if (souvenir == "flags" || souvenir == "caps" || souvenir == "posters" || souvenir == "stickers")
                {
                    Console.WriteLine($"Pepi bought {numberOfSouvenirs} {souvenir} of {team} for {sum:f2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else if (team != "Argentina" || team != "Brazil" || team != "Croatia" || team != "Denmark")
            {
                Console.WriteLine("Invalid country!");
            }
        }
    }
}
