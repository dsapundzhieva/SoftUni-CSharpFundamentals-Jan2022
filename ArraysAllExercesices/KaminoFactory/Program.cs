using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());


            var sample = 0;
            var bestDnaSample = 1;

            var bestSum = 0;
            var bestSeqIndex = 0;
            var bestLength = 0;


            bool isBestDna = false;
            var bestDnaArray = new int[dnaLength];


            string command;

            while ((command = Console.ReadLine()) != "Clone them!")
            {
                var cmdArgs = command
                 .Split("!", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

                sample++;

                
                var currentLength = 0;
                var maxLenght = 0;
                var maxIndex = 0;
                var firstIndex = 0;
                var sum = 0;
               

                for (int i = 0; i < cmdArgs.Length; i++)
                {
                    if (cmdArgs[i] == 1)
                    {
                        currentLength++;
                        sum++;

                        if (currentLength == 1)
                        {
                            firstIndex = i;
                        }
                        if (currentLength > maxLenght)
                        {
                            maxLenght = currentLength;
                            maxIndex = firstIndex;
                        }
                    }
                    else
                    {
                        currentLength = 0;
                        firstIndex = 0;
                    }
                }

                

                if (maxLenght > bestLength)
                {
                    isBestDna = true;
                }
                else if (maxLenght == bestLength)
                {
                    if (maxIndex < bestSeqIndex)
                    {
                        isBestDna = true;
                    }
                    else if (bestSeqIndex == maxIndex)
                    {
                        if (sum > bestSum)
                        {
                            isBestDna = true;
                        }
                    }
                }

                if (isBestDna)
                {
                    for (int i = 0; i < cmdArgs.Length; i++)
                    {
                        bestDnaArray[i] = cmdArgs[i];
                    }
                    bestLength = maxLenght;
                    bestSeqIndex = maxIndex;
                    bestSum = sum;
                    bestDnaSample = sample;
                }
                isBestDna = false;
            }

            Console.WriteLine($"Best DNA sample {bestDnaSample} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDnaArray));
        }
    }
}
