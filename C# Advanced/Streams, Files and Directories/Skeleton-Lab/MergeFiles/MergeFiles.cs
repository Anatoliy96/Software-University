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
            using FileStream fs1 = File.Open(firstInputFilePath, FileMode.Open);
            using FileStream fs2 = File.Open(secondInputFilePath, FileMode.Open);
            using FileStream fs3 = File.Open(outputFilePath, FileMode.Append);

            
        }
    }
}
