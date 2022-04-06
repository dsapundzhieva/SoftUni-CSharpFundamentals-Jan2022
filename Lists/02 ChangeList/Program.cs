using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_ChangeList
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

                string manipulation = cmdArgs[0];

                if (manipulation == "Delete")
                {
                    int elementToDelete = int.Parse(cmdArgs[1]);

                    numbers.RemoveAll(x => x == elementToDelete);
                }
                else if (manipulation == "Insert")
                {
                    int elementToInsert = int.Parse(cmdArgs[1]);
                    int IndexToInsertAt = int.Parse(cmdArgs[2]);

                    numbers.Insert(IndexToInsertAt, elementToInsert);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
