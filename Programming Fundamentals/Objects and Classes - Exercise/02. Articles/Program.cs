using System;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] currArticle = Console.ReadLine().Split(", ");
            
            var article = new Article(currArticle[0], currArticle[1], currArticle[2]);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] lines = Console.ReadLine().Split(": ");
                string commnad = lines[0];
                string argument = lines[1];
                
                if (commnad == "Edit")
                {
                    article.Edit(argument);
                }
                else if (commnad == "ChangeAuthor")
                {
                    article.ChangeAuthor(argument);
                }
                else if (commnad == "Rename")
                {
                    article.Rename(argument);
                }
            }
            Console.WriteLine(article);
        }
    }
    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void ChangeAuthor(string author) => Author = author;
        public void Edit(string content) => Content = content;
        public void Rename(string title) => Title = title;

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
