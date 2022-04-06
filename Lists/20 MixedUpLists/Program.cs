using System;
using System.Collections.Generic;
using System.Linq;

namespace _20_MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbersOne = Console.ReadLine()
              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToList();

            List<int> listOfNumbersTwo = Console.ReadLine()
              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToList();

            int minCount = Math.Min(listOfNumbersOne.Count, listOfNumbersTwo.Count);

            List<int> result = new List<int>();

            for (int i = 0; i < minCount; i++)
            {
                result.Add(listOfNumbersOne[0]);
                result.Add(listOfNumbersTwo[listOfNumbersTwo.Count - 1]);
                listOfNumbersOne.RemoveAt(0);
                listOfNumbersTwo.RemoveAt(listOfNumbersTwo.Count - 1);
            }

            if (listOfNumbersOne.Count == 2)
            {
                result = result.
                    Where(x => x < Math.Max(listOfNumbersOne[0], listOfNumbersOne[1]) && x > Math.Min(listOfNumbersOne[0], listOfNumbersOne[1]))
                    .OrderBy(x => x)
                    .ToList();
            }
            else
            {
                result = result.
                    Where(x => x < Math.Max(listOfNumbersTwo[0], listOfNumbersTwo[1]) && x > Math.Min(listOfNumbersTwo[0], listOfNumbersTwo[1]))
                    .OrderBy(x => x)
                    .ToList();
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
