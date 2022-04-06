
using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_ListManipulationAdvanced
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
            bool hasChange = false;

            while (command != "end")
            {
                string[] cmdArgs = command.Split();

                if (cmdArgs[0] == "Add")
                {
                    int numberToAdd = int.Parse(cmdArgs[1]);
                    numbers.Add(numberToAdd);
                    hasChange = true;
                }
                else if (cmdArgs[0] == "Remove")
                {
                    int removeFromList = int.Parse(cmdArgs[1]);
                    numbers.Remove(removeFromList);
                    hasChange = true;
                }
                else if (cmdArgs[0] == "RemoveAt")
                {
                    int removeByIndex = int.Parse(cmdArgs[1]);
                    numbers.RemoveAt(removeByIndex);
                    hasChange = true;
                }
                else if (cmdArgs[0] == "Insert")
                {
                    int numberToInsert = int.Parse(cmdArgs[1]);
                    int indexToInsert = int.Parse(cmdArgs[2]);
                    numbers.Insert(indexToInsert, numberToInsert);
                    hasChange = true;
                }
                else if (cmdArgs[0] == "Contains")
                {
                    int numberContains = int.Parse(cmdArgs[1]);

                    if (numbers.Contains(numberContains))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (cmdArgs[0] == "PrintEven")
                {
                    List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);
                    Console.WriteLine(string.Join(" ", evenNumbers));
                }
                else if (cmdArgs[0] == "PrintOdd")
                {
                    List<int> oddNubers = numbers.FindAll(x => x % 2 != 0);
                    Console.WriteLine(string.Join(" ", oddNubers));
                }
                else if (cmdArgs[0] == "GetSum")
                {
                    int sum = numbers.Sum();
                    Console.WriteLine(sum);
                }
                else if (cmdArgs[0] == "Filter")
                {
                    string condition = cmdArgs[1];
                    int numberToFilter = int.Parse(cmdArgs[2]);
                    List<int> filteredNumbers = FilterByGivenNumber(numbers, condition, numberToFilter);
                    Console.WriteLine(string.Join(" ", filteredNumbers));
                }

                command = Console.ReadLine();
            }
            if (hasChange)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        static List<int> FilterByGivenNumber(List<int> nums, string condition, int num)
        {

            if (condition == "<")
            {
                return nums.FindAll(x => x < num);
            }
            else if (condition == ">")
            {
                return nums.FindAll(x => x > num);
            }
            else if (condition == "<=")
            {
                return nums.FindAll(x => x <= num);
            }
            else if (condition == ">=")
            {
                return nums.FindAll(x => x >= num);
            }
            return nums;
        }
    }
}
