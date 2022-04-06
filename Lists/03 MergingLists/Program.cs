using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToList();

            List<int> secondList = Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToList();

            List<int> combinedList = new List<int>();

            int maxLength = Math.Max(firstList.Count(), secondList.Count());

            for (int i = 0; i < maxLength; i++)
            {
                if (i < firstList.Count())
                {
                    combinedList.Add(firstList[i]);
                }
                if (i < secondList.Count())
                {
                    combinedList.Add(secondList[i]);
                }

            }

            Console.WriteLine(string.Join(" ", combinedList));
        }
    }
}
