using System;
using System.Collections.Generic;

namespace _3._Longest_Substring_Without_Repeating_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            
            int result = LengthOfLongestSubstring(s);

            Console.WriteLine(result);
        }

        public static int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            List<char> set = new List<char>();
            int maxLenght = 0, i = 0, j = 0;
            while (i < n && j < n)
            {
                // try to extend the range [i, j]
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j++]);
                    maxLenght = Math.Max(maxLenght, j - i);
                }
                else
                {
                    set.Remove(s[i++]);
                }
            }
            return maxLenght;
        }
    }
}
