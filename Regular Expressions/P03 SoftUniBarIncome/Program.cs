using System;
using System.Text.RegularExpressions;

namespace P03_SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            string patern =
                @"\%(?<client>[A-Z]{1}[a-z]+)\%[^%$|.]*?\<(?<products>\w+)\>[^%$|.]*?\|(?<count>\d+)\|[^%$|.]*?(?<price>\d+(\.\d+)?)\$";

            decimal income = 0m;

            while ((command = Console.ReadLine()) != "end of shift")
            {
                MatchCollection match = Regex.Matches(command, patern);

                foreach (Match item in match)
                {
                    string customer = item.Groups["client"].Value;
                    string product = item.Groups["products"].Value;
                    int count = int.Parse(item.Groups["count"].Value);
                    decimal price = decimal.Parse(item.Groups["price"].Value);

                    decimal totalPrice = (decimal)count * price;

                    income += totalPrice;

                    Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
                }
            }
            Console.WriteLine($"Total income: {income:f2}");
        }
    }
}
