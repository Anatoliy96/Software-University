﻿using System;
using System.Collections.Generic;

namespace _03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] currentArticles = Console.ReadLine().Split(", ");

                var article = new Article(currentArticles[0], currentArticles[1], currentArticles[2]);

                articles.Add(article);
            }

            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }
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

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
