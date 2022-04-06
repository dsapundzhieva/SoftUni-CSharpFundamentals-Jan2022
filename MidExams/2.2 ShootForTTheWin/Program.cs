using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._2_ShootForTTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targetSequence = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();


            targetSequence = Reduce(targetSequence);
            List<int> shotTargets = targetSequence.FindAll(x => x == -1);
            Console.WriteLine($"Shot targets: {shotTargets.Count} -> {string.Join(" ", targetSequence)}");
        }

        static List<int> Reduce(List<int> targetSequence)
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                int shootIndex = int.Parse(command);

                if (!isIndexValid(targetSequence, shootIndex))
                {
                    continue;
                }

                if (targetSequence[shootIndex] != -1)
                {
                    for (int i = 0; i < targetSequence.Count; i++)
                    {
                        if (i == shootIndex)
                        {
                            continue;
                        }
                        else
                        {
                            if (targetSequence[i] != -1 && targetSequence[i] <= targetSequence[shootIndex])
                            {
                                var sumtToIncrease = targetSequence[i] + targetSequence[shootIndex];
                                targetSequence[i] = sumtToIncrease;
                            }
                            else if (targetSequence[i] != -1 && targetSequence[i] > targetSequence[shootIndex])
                            {
                                var test = targetSequence[shootIndex];
                                var sumtToReduce = targetSequence[i] - targetSequence[shootIndex];
                                targetSequence[i] = sumtToReduce;
                            }

                        }
                    }

                    targetSequence[shootIndex] = -1;
                }
            }
            return targetSequence;
        }

        static bool isIndexValid(List<int> targetSequence, int index)
        {
            return index >= 0 && index < targetSequence.Count;
        }
    }
}
