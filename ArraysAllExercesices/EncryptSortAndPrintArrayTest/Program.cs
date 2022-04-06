using System;
using System.Linq;

namespace EncryptSortAndPrintArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var array = new int[number];

            for (int i = 0; i < number; i++)
            {
                var name = Console.ReadLine();
                var sum = 0;

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
                array[i] = sum;
            }
            Console.WriteLine(string.Join("\n", array.OrderBy(a=>a)));
        }
    }
}
