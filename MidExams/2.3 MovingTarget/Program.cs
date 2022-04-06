using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._3_MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> movingSequence = Console.ReadLine()
              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToList();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var cmdArgs = command.Split(" ");

                var cmdType = cmdArgs[0];

                if (cmdType == "Shoot")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int power = int.Parse(cmdArgs[2]);

                    movingSequence = Shoot(movingSequence, index, power);
                }
                else if (cmdType == "Add")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int value = int.Parse(cmdArgs[2]);

                    if (isIndexValid(movingSequence, index))
                    {
                        movingSequence = Add(movingSequence, index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (cmdType == "Strike")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int radius = int.Parse(cmdArgs[2]);

                    movingSequence = Strike(movingSequence, index, radius);
                }

            }
            Console.WriteLine(string.Join("|", movingSequence));
        }

        static List<int> Strike(List<int> movingSequence, int index, int radius)
        {
            int indexRight = index + radius;
            int indexLeft = index - radius;

            if (indexRight > movingSequence.Count - 1)
            {
                Console.WriteLine("Strike missed!");
                return movingSequence;
            }
            if (indexLeft < 0)
            {
                Console.WriteLine("Strike missed!");
                return movingSequence;
            }

            movingSequence.RemoveRange(indexLeft, radius * 2 + 1);

            return movingSequence;
        }

        static List<int> Add(List<int> movingSequence, int index, int value)
        {
            movingSequence.Insert(index, value);
            return movingSequence;
        }

        static List<int> Shoot(List<int> movingSequence, int index, int power)
        {
            if (isIndexValid(movingSequence, index))
            {
                if (movingSequence[index] > 0)
                {
                    movingSequence[index] -= power;
                }
                if (movingSequence[index] <= 0)
                {
                    movingSequence.RemoveAt(index);
                }
            }
            return movingSequence;
        }

        static bool isIndexValid(List<int> list, int index)
        {
            return index >= 0 && index < list.Count;
        }
    }
}
