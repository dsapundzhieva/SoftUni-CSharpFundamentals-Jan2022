using System;
using System.Collections.Generic;
using System.Linq;

namespace _22_ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command;

            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                var cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var cmdType = cmdArgs[0]; 

                if (cmdType == "Urgent")
                {
                    var item = cmdArgs[1];
                    groceries = Urgent(groceries, item);
                }
                else if (cmdType == "Unnecessary")
                {
                    var item = cmdArgs[1];
                    groceries = Unnecessary(groceries, item);
                }
                else if (cmdType == "Correct")
                {
                    var oldItem = cmdArgs[1];
                    var newItem = cmdArgs[2];
                    groceries = Correct(groceries, oldItem, newItem);
                }
                else if (cmdType == "Rearrange")
                {
                    var item = cmdArgs[1];
                    groceries = Rearrange(groceries, item);
                }
            }

            Console.WriteLine(string.Join(", ", groceries));
        }
        static List<string> Rearrange(List<string> groceries, string item)
        {
            if (groceries.Contains(item))
            {
                groceries.Remove(item);
                groceries.Add(item);
            }
            return groceries;
        }

        static List<string> Correct(List<string> groceries, string oldItem, string newItem)
        {
            if (groceries.Contains(oldItem))
            {
                int index = groceries.IndexOf(oldItem);
                groceries.Remove(oldItem);
                groceries.Insert(index, newItem);
            }
            return groceries;
        }

        static List<string> Unnecessary(List<string> groceries, string item)
        {
            if (groceries.Contains(item))
            {
                groceries.Remove(item);
            }
            return groceries;
        }

        static List<string> Urgent(List<string> groceries, string item)
        {
            if (!groceries.Contains(item))
            {
                groceries.Insert(0, item);
            }
            return groceries;
        }
    }
}
