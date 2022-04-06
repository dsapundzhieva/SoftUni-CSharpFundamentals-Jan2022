using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._3_MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
           .ToList();

            CheckIfCheat(elements);

        }

        static void CheckIfCheat(List<string> elements)
        {
            int countMovers = 0;

            string command;
            bool isWon = false;

            while ((command = Console.ReadLine()) != "end")
            {
                var cmdArgs = command.Split(" ");

                int index1 = int.Parse(cmdArgs[0]);
                int index2 = int.Parse(cmdArgs[1]);

                bool isCheating = index1 == index2;
                countMovers++;

                if (isCheating || !isIndexesValid(elements, index1, index2))
                {
                    int middleOfArray = elements.Count / 2;

                    string addElement = $"-{countMovers}a";

                    elements.Insert(middleOfArray, addElement);
                    elements.Insert(middleOfArray, addElement);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }

                if (elements[index1] == elements[index2])
                {
                    string elementTwin = elements.ElementAt(index1);
                    //elements.RemoveAll(x => x == elementTwin);
                    elements.Remove(elementTwin);
                    elements.Remove(elementTwin);
                    Console.WriteLine($"Congrats! You have found matching elements - {elementTwin}!");
                }
                else
                {
                    Console.WriteLine("Try again!");
                    continue;
                }

                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {countMovers} turns!");
                    isWon = true;
                    break;
                }
            }
            if (!isWon)
            {
                Console.WriteLine($"Sorry you lose :(\n{string.Join(" ", elements)}");
            }
        }

        static bool isIndexesValid(List<string> list, int index1, int index2)
        {
            return index1 >= 0 && index2 >= 0 && index1 < list.Count && index2 < list.Count;
        }
    }
}
