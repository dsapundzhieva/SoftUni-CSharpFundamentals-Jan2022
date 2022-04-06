using System;
using System.Linq;

namespace Longest
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var solutions = new int[numbers.Length];
            var maxSolution = 0;
            var maxSolutionIndex = 0;
            var prev = new int[numbers.Length];

            for (int current = 0; current < numbers.Length; current++)
            {
                var solution = 1;
                var prevIndex = -1;
                var currentNumber = numbers[current];

                for (int solIndex = 0; solIndex < current; solIndex++)
                {
                    var prevNumber = numbers[solIndex];
                    var prevSolution = solutions[solIndex];

                    if (currentNumber > prevNumber && solution <= prevSolution)
                    {
                        solution = prevSolution + 1;
                        prevIndex = solIndex;
                    }
                }
                solutions[current] = solution;
                prev[current] = prevIndex;

                if (solution > maxSolution)
                {
                    maxSolution = solution;
                    maxSolutionIndex = current;
                }

            }


            var index = maxSolutionIndex;

            var result = new int[maxSolution];

            while (index != -1)
            {
                for (int i = result.Length - 1; i >= 0; i--)
                {
                    var currentNumber = numbers[index];
                    index = prev[index];
                    result[i] = currentNumber;
                }
            }
            Console.Write(string.Join(" ", result));
        }
    }
}
