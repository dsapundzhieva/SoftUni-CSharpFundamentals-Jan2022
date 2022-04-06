using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fieldArray = new int[int.Parse(Console.ReadLine())];


            int[] ladybugIndexes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < fieldArray.Length; i++)
            {
                if (ladybugIndexes.Contains(i))
                {
                    fieldArray[i] = 1;
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "end")
            {

                string[] argsComand = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                int initialIndex = int.Parse(argsComand[0]);
                string direction = argsComand[1];
                int flyLength = int.Parse(argsComand[2]);

                //check if index is valid, if it is not, next command input
                if (initialIndex > fieldArray.Length - 1 || initialIndex < 0)
                {
                    continue;
                }
                // have a valid index so check if there is a ladybug
                // if there isn't a ladybug, nothing happens, next command input
                if (fieldArray[initialIndex] == 0)
                {
                    continue;
                }
                //ladybug starts flying 
                fieldArray[initialIndex] = 0;
                int nextIndex = initialIndex;

                while (true)
                {
                    if (direction == "left")
                    {
                        nextIndex -= flyLength;
                    }
                    else if (direction == "right")
                    {
                        nextIndex += flyLength;
                    }

                    if (nextIndex > fieldArray.Length - 1 || nextIndex < 0)
                    {
                        break;
                    }
                    if (fieldArray[nextIndex] == 0)
                    {
                        break;
                    }
                }
                if (nextIndex >= 0 && nextIndex < fieldArray.Length)
                {
                    fieldArray[nextIndex] = 1;
                }
            } 

            Console.WriteLine(string.Join(" ", fieldArray));
        }
    }
}
