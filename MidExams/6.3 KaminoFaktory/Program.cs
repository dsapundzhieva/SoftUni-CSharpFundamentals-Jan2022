using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._3_KaminoFaktory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLenght = int.Parse(Console.ReadLine());

            string command;

            int bestLenght = 0;
            int bestSum = 0;
            int bestDnaSequence = 0;
            int sequenceCount = 0;
            int bestIndex = int.MaxValue;

            List<int> bestDnaList = new List<int>();

            while ((command = Console.ReadLine()) != "Clone them!")
            {
                List<int> currentDnaList = command
                       .Split("!", StringSplitOptions.RemoveEmptyEntries)
                       .Select(int.Parse)
                       .ToList();

                int maxLength = 0;
                int currLength = 0;
                int index = -1;
                int sum = 0;
                int minIndex = 0;

                sequenceCount++;

                for (int i = 0; i < currentDnaList.Count; i++)
                {
                    var currentElement = currentDnaList[i];

                    if (currentElement == 1)
                    {
                        currLength++;

                        if (currLength == 1)
                        {
                            index = i;
                        }
                        if (currLength > maxLength)
                        {
                            maxLength = currLength;
                            minIndex = index;
                        }
                    }
                    else
                    {
                        currLength = 0;
                        index = 0;
                    }
                    
                    sum += currentElement;
                }

                bool isBestDna = false;

                if (bestLenght < maxLength)
                {
                    bestLenght = maxLength;
                    bestIndex = minIndex;
                    isBestDna = true;
                }
                else if (maxLength == bestLenght)
                {
                    if (minIndex < bestIndex)
                    {
                        bestIndex = minIndex;
                        isBestDna = true;
                    }
                    else if (minIndex == bestIndex)
                    {
                        if (bestSum < sum)
                        {
                            bestSum = sum;
                            isBestDna = true;
                        }
                    }
                }

                if (isBestDna)
                {
                    bestDnaSequence = sequenceCount;
                    bestDnaList = new List<int>(currentDnaList);
                    bestSum = sum;
                }
            }

            Console.WriteLine($"Best DNA sample {bestDnaSequence} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDnaList));

        }
    }
}
