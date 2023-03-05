using System;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] article = Console.ReadLine().Split(", ", StringSplitOptions.None);
            string title = article[0];
            string content = article[1];
            string author = article[2];

            Articles articles = new Articles(title, content, author);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split(": ", StringSplitOptions.None);

                if (commands[0] == "Edit")
                {
                    string newContent = commands[1];

                    articles.Content = newContent;
                }
                else if (commands[0] == "ChangeAuthor")
                {
                    string newAuthor = commands[1];

                    articles.Author = newAuthor;
                }
                else if (commands[0] == "Rename")
                {
                    string newTitle = commands[1];

                    articles.Title = newTitle; 
                }
            }
            Console.WriteLine(articles.ToString());
            
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
