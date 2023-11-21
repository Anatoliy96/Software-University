using System;

namespace P04.Recharge
{
    class Program
    {
        static void Main()
        {

            Robot worker = new Robot("1", 10, 8);

            worker.Work(8);
            worker.Recharge();
        }
    }
}
