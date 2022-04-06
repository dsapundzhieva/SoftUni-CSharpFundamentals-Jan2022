using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Articles_2._0
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] commandParams = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string title = commandParams[0];
                string content = commandParams[1];
                string author = commandParams[2];

                Article articleObject = new Article(title, content, author);

                articles.Add(articleObject);
            }

            string finalCommand = Console.ReadLine();

            List<Article> filteredByTitle = articles.OrderBy(article => article.Title).ToList();
            List<Article> filteredByContent = articles.OrderBy(article => article.Content).ToList();
            List<Article> filteredByAuthor = articles.OrderBy(article => article.Author).ToList();

            if (finalCommand == "title")
            {
                PrintList(filteredByTitle);

            }
            else if (finalCommand == "content")
            {
                PrintList(filteredByContent);

            }
            else if (finalCommand == "author")
            {
                PrintList(filteredByAuthor);
            }
        Console.WriteLine(String.Join(" ", filteredByTitle));
        }
        static void PrintList(List<Article> articles)
        {
            foreach (Article article in articles)
            {
                Console.WriteLine(article.ToString());
            }
        }
    }
}
