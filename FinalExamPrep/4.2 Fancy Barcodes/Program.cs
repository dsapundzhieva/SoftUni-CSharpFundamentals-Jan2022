using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _4._2_Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();
                string pattern = @"(@[#]+)(?<product>[A-Z][A-Za-z\d]{4,}[A-Z])(@[#]+)";
                Match match = Regex.Match(barcode, pattern);

                if (!match.Success)
                {
                    Console.WriteLine("Invalid barcode");
                }
                else
                {
                    string digitPattern = @"\d";
                    MatchCollection digitMatch = Regex.Matches(barcode, digitPattern);
                    StringBuilder result = new StringBuilder();

                    if (digitMatch.Count == 0)
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        foreach (Match item in digitMatch)
                        {
                            result.Append(item.ToString());
                        }
                        Console.WriteLine($"Product group: {result}");
                    }
                }
            }
        }
    }
}
