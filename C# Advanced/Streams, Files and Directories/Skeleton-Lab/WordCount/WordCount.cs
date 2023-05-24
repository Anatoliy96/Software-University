namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            string[] words = File.ReadAllText(wordsFilePath)
                .ToLower()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string text = File.ReadAllText(textFilePath).ToLower();

            Regex wordRegex = new Regex(@"[A-Za-z']+");
            MatchCollection matches = wordRegex.Matches(text);

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                wordCount.Add(currentWord, 0);

                for (int j = 0; j < matches.Count; j++)
                {
                    if (matches[j].ToString() == currentWord)
                    {
                        wordCount[currentWord]++;
                    }
                }
            }
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (var word in wordCount.OrderByDescending(w => w.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
