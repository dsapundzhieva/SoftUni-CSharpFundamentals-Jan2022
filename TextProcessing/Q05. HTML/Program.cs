using System;
using System.Text;

namespace Q05._HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();

            string command;

            StringBuilder result = new StringBuilder();

            result.Append($"<h1>\n\t{title}\n</h1>\n<article>\n\t{content}\n</article>");

            
            while ((command = Console.ReadLine()) != "end of comments")
            {
                var comments = command;

                result.Append($"\n<div>\n\t{comments}\n</div>");
            }

            Console.WriteLine(result);
        }
    }
}
