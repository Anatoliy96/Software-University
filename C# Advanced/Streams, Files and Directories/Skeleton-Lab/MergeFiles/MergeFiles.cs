namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using StreamReader streamReader = new StreamReader(firstInputFilePath);
            using StreamReader streamReader1 = new StreamReader(secondInputFilePath);
            using StreamWriter write = new StreamWriter(outputFilePath);

            string line1 = string.Empty;
            string line2 = string.Empty;

            while ((line1 = streamReader.ReadLine()) != null && (line2 = streamReader1.ReadLine()) != null)
            {
                if (line2 != null)
                {
                    write.WriteLine(line1);
                }
                if (line1 != null)
                {
                    write.WriteLine(line2);
                }
            }
        }
    }
}
