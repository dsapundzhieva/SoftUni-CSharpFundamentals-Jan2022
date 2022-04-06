using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace P06_ExtractEmails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string patern = @"\s+([^\-\.\*\$\t\s_\@\n])+(?<user>[A-Za-z\d\.\-_]+)@(?<host>[a-zA-Z\d\-]+)([^\-\.,])(\.)([a-z]+)?(\.)?([a-z]+)?([^\-\.,\s])";

            MatchCollection matcheEmails = Regex.Matches(text, patern);


            List<string> emails = new List<string>();

            foreach (Match match in matcheEmails)
            {
                StringBuilder email = new StringBuilder();

                string user = match.Groups[0].Value;
               
                email.Append(user);
               

                emails.Add(email.ToString());

            }

            foreach (var item in emails)
            {
                Console.WriteLine(item.Trim());
            }
        }
    }
}
