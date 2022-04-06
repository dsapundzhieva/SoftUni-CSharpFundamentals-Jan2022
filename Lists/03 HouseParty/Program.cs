using System;
using System.Collections.Generic;

namespace _03_HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();

                string name = cmdArgs[0];
                string goingOrNot = cmdArgs[2];

                if (!list.Contains(name) && goingOrNot == "going!")
                {
                    list.Add(name);
                }
                else if (list.Contains(name) && goingOrNot == "going!")
                {
                    Console.WriteLine($"{name} is already in the list!");
                }
                else if (list.Contains(name) && goingOrNot == "not")
                {
                    list.Remove(name);
                }
                else if (!list.Contains(name) && goingOrNot == "not")
                {
                    Console.WriteLine($"{name} is not in the list!");
                }
            }
            Console.WriteLine(string.Join("\n", list));
        }
    }
}
