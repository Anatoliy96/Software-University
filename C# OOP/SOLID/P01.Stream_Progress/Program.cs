using System;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            StreamProgressInfo fileStream = new StreamProgressInfo(new File("txt", 5, 100));

            Console.WriteLine(fileStream.CalculateCurrentPercent());

            StreamProgressInfo musicStream = new StreamProgressInfo(new Music("Eminem", "Marshal LP", 5, 100));

            Console.WriteLine(musicStream.CalculateCurrentPercent());
        }
    }
}
