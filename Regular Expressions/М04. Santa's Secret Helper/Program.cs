using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace М04._Santa_s_Secret_Helper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            string command;

            List<string> names = new List<string>();

            while ((command = Console.ReadLine()) != "end")
            {
                names = GetGoodKids(names, command, key);
            }

            Console.WriteLine(string.Join("\n", names));
            
        }

        static string DecryptMessage(string message, int key)
        {
            StringBuilder result = new StringBuilder();

            foreach (var item in message)
            {
                char currLetter = (char)(item-key);
                result.Append(currLetter);
            }

            return result.ToString();
        }

        static List<string> GetGoodKids(List<string> names, string message, int key)
        {
            string decryptedMessage = DecryptMessage(message, key);

            string pattern = @"@(?<name>[A-Za-z]+)[^\@\-\!\:\>]*!(?<behavior>G|N)!";

            Match matchName = Regex.Match(decryptedMessage, pattern);


            if (matchName.Groups["behavior"].Value == "G")
            {
                names.Add(matchName.Groups["name"].Value);
            }

            return names;
        }
    }
}
