using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArgs = command.Split();

                string manipulation = cmdArgs[0];

                if (manipulation == "Add")
                {
                    int numToAdd = int.Parse(cmdArgs[1]);

                    numbers.Add(numToAdd);
                }
                else if (manipulation == "Insert")
                {
                    int numToInsert = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);

                    if (IsIndexValid(numbers, index))
                    {
                        numbers.Insert(index, numToInsert);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                }
                else if (manipulation == "Remove")
                {
                    int indexToRemoveAt = int.Parse(cmdArgs[1]);

                    if (IsIndexValid(numbers, indexToRemoveAt))
                    {
                        numbers.RemoveAt(indexToRemoveAt);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                }
                else if (manipulation == "Shift")
                {
                    string leftOrRight = cmdArgs[1];
                    int count = int.Parse(cmdArgs[2]);

                     
                    if (leftOrRight == "left")
                    {
                        ShiftLeft(numbers, count);
                    }
                    else if (leftOrRight == "right")
                    {
                        ShifRight(numbers, count);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        static void ShifRight(List<int> nums, int count)
        {
            int realPerformedCount = count % nums.Count;

            for (int i = 1; i <= realPerformedCount; i++)
            {
                int lastElement = nums.Last();
                nums.RemoveAt(nums.Count-1);
                nums.Insert(0, lastElement);
            }

        }

        static void ShiftLeft(List<int> nums, int count)
        {
            int realPerformedCount = count % nums.Count;

            for (int i = 1; i <= realPerformedCount; i++)
            {
                int firstElement = nums.First();
                nums.Remove(firstElement);
                nums.Add(firstElement);
            }

        }

        static bool IsIndexValid(List<int> numbers, int index)
        {
            return index >= 0 && index <= numbers.Count() - 1;
        }
    }
}
