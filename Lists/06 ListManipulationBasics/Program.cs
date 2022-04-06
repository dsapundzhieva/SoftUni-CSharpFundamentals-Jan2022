using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_ListManipulationBasics
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

            while (command != "end")
            {
                string[] cmdArgs = command.Split();

                if (cmdArgs[0] == "Add")
                {
                   int numberToAdd = int.Parse(cmdArgs[1]);
                   numbers.Add(numberToAdd);
                }
                else if (cmdArgs[0] == "Remove")
                {
                    int removeFromList = int.Parse(cmdArgs[1]);
                    numbers.Remove(removeFromList);
                }
                else if (cmdArgs[0] == "RemoveAt")
                {
                    int removeByIndex = int.Parse(cmdArgs[1]);
                    numbers.RemoveAt(removeByIndex);
                    
                }
                else if (cmdArgs[0] == "Insert")
                {
                    int numberToInsert = int.Parse(cmdArgs[1]);
                    int indexToInsert = int.Parse(cmdArgs[2]);
                    numbers.Insert(indexToInsert, numberToInsert);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
