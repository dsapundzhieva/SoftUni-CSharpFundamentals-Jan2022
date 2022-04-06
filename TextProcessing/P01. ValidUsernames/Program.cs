using System;
using System.Text;

namespace P01._ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var username = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();

            foreach (var item in username)
            {
                if (!isValid(item))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(item.ToString().Trim());
                }
            }
        }

        static bool isValid(string word)
        {
            bool isValid = false;

            foreach (var currLetter in word)
            {
                if (word.Length < 3 || word.Length > 16)
                {
                    isValid = false;
                }
                else
                {
                    if (char.IsLetterOrDigit(currLetter) || currLetter == '-' || currLetter == '_')
                    {
                        isValid = true;
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                }
            }
            return isValid;
        }
    }
}
