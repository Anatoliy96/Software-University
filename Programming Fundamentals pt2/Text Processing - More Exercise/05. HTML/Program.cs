using System;
using System.Collections.Generic;

namespace _05._HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string article = Console.ReadLine();
            List<string> comments = new List<string>();

            string content = Console.ReadLine();

            while (content != "end of comments")
            {
                comments.Add(content);
                content = Console.ReadLine();
            }

            Console.WriteLine("<h1>");
            Console.WriteLine(title);
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine(article);
            Console.WriteLine("</article>");

            foreach (var comment in comments)
            {
                Console.WriteLine("<div>");
                Console.WriteLine(comment);
                Console.WriteLine("</div>");
            }
        }
    }
}
