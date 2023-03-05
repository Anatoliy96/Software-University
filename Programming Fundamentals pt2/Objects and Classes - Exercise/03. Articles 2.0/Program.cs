using System;
using System.Collections.Generic;

namespace _03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<Articles> artcles = new List<Articles>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] article = Console.ReadLine().Split(", ", StringSplitOptions.None);
                string title = article[0];
                string content = article[1];
                string author = article[2];

                Articles articles = new Articles(title, content, author);

                artcles.Add(articles);
            }

            foreach (var article in artcles)
            {
                Console.WriteLine(article.ToString());
            }
        }
        class Articles
        {
            public Articles(string title, string content, string author)
            {
                this.Author = author;
                this.Title = title;
                this.Content = content;
            }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}
