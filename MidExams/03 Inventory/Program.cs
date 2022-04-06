using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command;

            while ((command = Console.ReadLine()) != "Craft!")
            {
                var cmdArgs = command.Split(" - ",StringSplitOptions.RemoveEmptyEntries);

                var cmdType = cmdArgs[0];
                var item = cmdArgs[1];

                if (cmdType == "Collect")
                {
                    journal = Collect(journal, item);
                }
                else if (cmdType == "Drop")
                {
                    journal = Drop(journal, item);
                }
                else if (cmdType == "Combine Items")
                {
                    var itemTypes = cmdArgs[1].Split(":");

                    string oldItem = itemTypes[0];
                    string newItem = itemTypes[1];

                    journal = CombineItems(journal, oldItem, newItem);
                }
                else if (cmdType == "Renew")
                {
                    Renew(journal, item);
                }
            }
            Console.WriteLine(string.Join(", ", journal));
        }

        static List<string> Renew(List<string> journal, string item)
        {
            if (journal.Contains(item))
            {
                journal.Remove(item);
                journal.Add(item);
            }

            return journal;
        }

        static List<string> CombineItems(List<string> journal, string oldItem, string newItem)
        {
            if (journal.Contains(oldItem))
            {
                int index = journal.IndexOf(oldItem);
                journal.Insert(index + 1, newItem);
            }

            return journal;
        }
        static List<string> Drop(List<string> journal, string item)
        {
            if (journal.Contains(item))
            {
                journal.Remove(item);
            }

            return journal;
        }
        static List<string> Collect(List<string> journal, string item)
        {
            if (!journal.Contains(item))
            {
                journal.Add(item);
            }

            return journal;
        }
    }
}
