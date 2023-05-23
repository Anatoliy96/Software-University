namespace EvenLines
{
    using System;
    using System.IO;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                StringBuilder sb = new StringBuilder();

                while (!reader.EndOfStream)
                {
                    int row = 0;
                    string line = reader.ReadLine();

                    if (row++ % 2 == 0)
                    {
                        string replacedSymbols = ReplaceSymbols(line);
                        string reversedWords = ReversedWords(replacedSymbols);
                        sb.Append(reversedWords);
                    }
                }
                return sb.ToString();
            }
        }

        public static string ReversedWords(string replacedSymbols)
        {
            string result = string.Empty;

            for (int i = replacedSymbols.Length - 1; i >= 0; i--)
            {
                result += replacedSymbols[i];
            }
            return result;
        }

        public static string ReplaceSymbols(string line)
        {
            char symbol = '@';
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '-' || line[i] == ',' || line[i] == '.' || line[i] == '!' || line[i] == '?')
                {
                    line.Replace(line[i], symbol);
                }
            }
            return line;
        }
    }
}
