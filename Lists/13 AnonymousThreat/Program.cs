using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13_AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "3:1")
            {
                var cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string comandType = cmdArgs[0];

                if (comandType == "merge")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    Merge(words, startIndex, endIndex);
                }
                else if (comandType == "divide")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int partitionsCount = int.Parse(cmdArgs[2]);

                    Divide(words, index, partitionsCount);
                }
            }

            Console.WriteLine(String.Join(" ", words));
        }

        static void Divide(List<string> words, int elementIndex, int partitionsCount)
        {
            string word = words[elementIndex];

            if (partitionsCount > word.Length)
            {
                return;
            }
            int partitionsLength = word.Length / partitionsCount;
            int partitionsReminder = word.Length % partitionsCount;
            int lastPartitionLength = partitionsLength + partitionsReminder;

            List<string> partitions = new List<string>();

            for (int i = 0; i < partitionsCount; i++)
            {
                char[] currentPartition;

                if (i == partitionsCount - 1)
                {
                    currentPartition = word
                        .Skip(i * partitionsLength)
                        .Take(lastPartitionLength)
                        .ToArray();
                }
                else
                {
                    currentPartition = word
                        .Skip(i * partitionsLength)
                        .Take(partitionsLength)
                        .ToArray();
                }

                partitions.Add(new string(currentPartition));
            }

            words.RemoveAt(elementIndex);
            words.InsertRange(elementIndex, partitions);
        }

        static void Merge(List<string> words, int startIndex, int endIndex)
        {
            if (!IsIndexValid(words, startIndex))
            {
                startIndex = 0;
            }

            if (!IsIndexValid(words, endIndex))
            {
                endIndex = words.Count - 1;
            }

            StringBuilder merged = new StringBuilder();

            for (int i = startIndex; i <= endIndex; i++)
            {
                merged.Append(words[startIndex]);
                words.RemoveAt(startIndex);
            }
            words.Insert(startIndex, merged.ToString());
        }

        static bool IsIndexValid(List<string> words, int index)
        {
            return index >= 0 && index < words.Count;
        }
    }
}
