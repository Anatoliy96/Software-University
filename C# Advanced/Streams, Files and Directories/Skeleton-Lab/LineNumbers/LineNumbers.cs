namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            int count = 1;

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line = reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    System.Console.WriteLine($"{count} {reader.ReadLine()}");
                    count++;
                }
            }
        }
    }
}
