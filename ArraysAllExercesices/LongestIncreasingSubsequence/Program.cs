using System;
using System.Linq;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            var lisArray = new int[numbers.Length];
            var maxValue = 0;
            var maxSolutionIndex = 0;
            var previousArray = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                var solution = 1;
                var previousIndex = -1;

                for (int k = 0; k < i; k++)
                {
                    var prevSolution = lisArray[k];
                    if (numbers[i] > numbers[k] && solution <= lisArray[k])
                    {
                        solution = lisArray[k] + 1;
                        previousIndex = k;
                    }
                }

                lisArray[i] = solution;
                previousArray[i] = previousIndex;

                if (solution > maxValue)
                {
                    maxValue = solution;
                    maxSolutionIndex = i;
                }
            }
 

            var index = maxSolutionIndex;
            var result = new int[maxValue];


            while ( index != -1)
            {
                for (int i = result.Length - 1; i >= 0; i--)
                {
                    result[i] = numbers[index];
                    index = previousArray[index];
                }
            }
            Console.Write(string.Join(" ", result));

        }
    }
}
