using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split("|").Reverse()
                .Select(x => x.Split(" ", StringSplitOptions.RemoveEmptyEntries))
                .Select(x => string.Join(" ", x).Trim()).ToList();

            Console.WriteLine(string.Join(" ", input).Trim());
        }
    }
}
