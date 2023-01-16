using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //· On the first input line – lost games count – integer in the range[0…1000].
            int countOfLostGames = int.Parse(Console.ReadLine());
            //· On the second line – headset price – floating - point number in the range[0…1000].
            double headSetPrice = double.Parse(Console.ReadLine());
            //· On the third line – mouse price – floating - point number in the range[0…1000].
            double mousePrice = double.Parse(Console.ReadLine());
            //· On the fourth line – keyboard price – floating - point number in the range[0…1000].
            double keyboardPrice = double.Parse(Console.ReadLine());
            //· On the fifth line – display price – floating - point number in the range[0… 1000].
            double displayPrice = double.Parse(Console.ReadLine());

            double totalPrice = 0;
            double sumOfHeadSet = 0;
            double sumOfMouse = 0;
            double sumOfKeyboard = 0;
            double sumOfDisplay = 0;
            int coutOfTrashedHeadSet = 0;
            int coutOfTrashedMouse = 0;
            int countOfTrashedKeyboard = 0;
            int countOfDisplayTrashed = 0;

            for (int i = 1; i <= countOfLostGames; i++)
            {
                if (i % 2 == 0)
                {
                    coutOfTrashedHeadSet++;
                    sumOfHeadSet = headSetPrice * coutOfTrashedHeadSet;
                }
                if (i % 3 == 0)
                {
                    coutOfTrashedMouse++;
                    sumOfMouse = mousePrice * coutOfTrashedMouse;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    countOfTrashedKeyboard++;
                    sumOfKeyboard = keyboardPrice * countOfTrashedKeyboard;

                    if (countOfTrashedKeyboard % 2 == 0)
                    {
                        countOfDisplayTrashed++;
                        sumOfDisplay = displayPrice * countOfDisplayTrashed;
                    }
                }
            }

            totalPrice = sumOfHeadSet + sumOfMouse + sumOfKeyboard + sumOfDisplay;

            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
        }
    }
}
