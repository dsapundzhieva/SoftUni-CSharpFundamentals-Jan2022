using System;
using System.Collections.Generic;

namespace Advertisement_Message
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
            string[] initialArticle = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string title = initialArticle[0];
            string content = initialArticle[1];
            string author = initialArticle[2];

            int n = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();
            Article articleObject = new Article(title, content, author);

            for (int i = 0; i < n; i++)
            {
                string[] commandParams = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string commandType = commandParams[0];

                if (commandType == "Edit")
                {
                    string newContent = commandParams[1];

                    articleObject.Content = Edit(content, newContent);
                }
                else if (commandType == "ChangeAuthor")
                {
                    string newAutohor = commandParams[1];

                    articleObject.Author = ChangeAuthor(author, newAutohor);
                }
                else if (commandType == "Rename")
                {
                    string newTitle = commandParams[1];

                    articleObject.Title = Rename(title, newTitle);
                }
                articles.Add(articleObject);
            }

            Console.WriteLine(articleObject.ToString());
        }
        static string Rename(string title, string newTitle)
        {
            title = newTitle;
            return title;
        }

        static string ChangeAuthor(string author, string newAuthor)
        {
            author = newAuthor;
            return author;
        }
        public static string Edit(string content, string newContent)
        {
            content = newContent;
            return content;
        }
    }
}
