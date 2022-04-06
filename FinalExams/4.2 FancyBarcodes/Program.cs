using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _4._2_FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string paternBarcode = @"(@[#]+)[A-Z][A-Za-z0-9]{4,}[A-Z](@[#]+)";

            string paternProductGroup = @"\d";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();

                Match barcodeMatche = Regex.Match(barcode, paternBarcode);

                if (barcodeMatche.Success)
                {
                    MatchCollection productGroup = Regex.Matches(barcode, paternProductGroup);
                    StringBuilder result = new StringBuilder();

                    if (productGroup.Count == 0)
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        foreach (Match item in productGroup)
                        {
                            result.Append(item.Value);
                        }
                        Console.WriteLine($"Product group: {result}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
