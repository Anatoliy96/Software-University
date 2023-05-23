namespace LineNumbers
{
    using System;
    using System.IO;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                int lineCount = 1;
                
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        writer.WriteLine($"Line {lineCount++}: {line}");
                    }
                }
            }
        }
    }
}
