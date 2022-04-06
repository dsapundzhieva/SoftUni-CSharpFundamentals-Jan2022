using System;
using System.Linq;

namespace _04_WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Where(word => word.Length % 2 == 0).ToArray();

            Console.WriteLine(string.Join("\n", words));

        }
    }
}
