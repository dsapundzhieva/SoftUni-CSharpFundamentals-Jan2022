using System;
using System.Linq;

namespace EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[int.Parse(Console.ReadLine())];
            int[] sums = new int[names.Length];

            for (int i = 0; i < names.Length; i++)
            {
                int sum = 0;
                names[i] = Console.ReadLine();
                string name = names[i];
                for (int k = 0; k < name.Length; k++)
                {
                    char letter = name[k];
                    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
                    {
                        sum += letter * name.Length;
                    }
                    else
                    {
                        sum += letter / name.Length;
                    }
                }
                sums[i] = sum;
            }

            Console.WriteLine(string.Join("\n", sums.OrderBy(s => s)));
        }
    }
}
