using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Необходимо количество найлон(в кв.м.) -цяло число в интервала[1... 100]
            int amountOfNylon = int.Parse(Console.ReadLine());
            //2.Необходимо количество боя(в литри) -цяло число в интервала[1…100]
            int amountOfPainting = int.Parse(Console.ReadLine());
            //3.Количество разредител(в литри) - цяло число в интервала[1…30]
            int diluent = int.Parse(Console.ReadLine());
            //4.Часовете, за които майсторите ще свършат работата -цяло число в интервала[1…9]
            int hoursOfWork = int.Parse(Console.ReadLine());

            double priceOfNylon = 1.50;
            double priceOfPainting = 14.50;
            double priceOfDiluent = 5.00;

            double sumOfNylon = (amountOfNylon + 2) * priceOfNylon;
            double sumOfPainting = (amountOfPainting + 1.10) * priceOfPainting;
            double sumOfDiluent = diluent * priceOfDiluent;
            double sumOfBags = 0.40;

            double priceOfMaterials = sumOfNylon + sumOfPainting + sumOfDiluent + sumOfBags;
            double priceOfMaster = (priceOfMaterials * 0.30) * hoursOfWork;

            double totalPrice = priceOfMaterials + priceOfMaster;
            Console.WriteLine(totalPrice);
        }
    }
}
