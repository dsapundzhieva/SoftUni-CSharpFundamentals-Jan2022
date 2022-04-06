using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());

            int[] bestDna = new int[dnaLength];

            int bestSeqIndex = 0;
            int bestSeqSum = 0;
            int bestSeqLength = 0;

            int bestSampleCounter = 1;
            int sampleCounter = 0;


            while (true)
            {
                string command = Console.ReadLine();
                if (command.Equals("Clone them!"))
                {
                    break;
                }

                int[] array = command
                    .Trim()
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                sampleCounter++;

                int  maxSeqLenth = 0;
                int bestIndex = 0;

                int currentSeqLenth = 0;
                int startIndex = 0;
                int sum = 0;


                for (int i = 0; i < dnaLength; i++)
                {
                    if (array[i] == 1)
                    {
                        currentSeqLenth++;
                        sum++;

                        if (currentSeqLenth == 1)
                        {
                            startIndex = i;
                        }
                        if (currentSeqLenth > maxSeqLenth)
                        {
                            maxSeqLenth = currentSeqLenth;
                            bestIndex = startIndex;
                        }
                    }
                    else
                    {
                        currentSeqLenth = 0;
                        startIndex = 0;
                    }
                }

                bool isBestDNA = false;

                if (bestSeqLength < maxSeqLenth)
                {
                    isBestDNA = true;
                }
                else if (maxSeqLenth == bestSeqLength)
                {
                    if (bestIndex < bestSeqIndex)
                    {
                        isBestDNA = true;
                    }
                    else if (bestIndex == bestSeqIndex)
                    {
                        if (sum > bestSeqSum)
                        {
                            isBestDNA = true;
                        }
                    }
                }

                if (isBestDNA)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        bestDna[i] = array[i];
                    }
                    bestSeqIndex = bestIndex;
                    bestSeqLength = maxSeqLenth;
                    bestSeqSum = sum;
                    bestSampleCounter = sampleCounter;
                }

            }

            Console.WriteLine($"Best DNA sample {bestSampleCounter} with sum: {bestSeqSum}.");
            Console.WriteLine(string.Join(" ", bestDna));
        }
    }
}
