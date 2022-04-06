using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());

            var initialLadybygsArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var fieldArray = new int[fieldSize];

            for (int i = 0; i < fieldArray.Length; i++)
            {
                if (initialLadybygsArray.Contains(i))
                {
                    fieldArray[i] = 1;
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                var cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var initialIndex = int.Parse(cmdArgs[0]);
                var direction = cmdArgs[1];
                var flyLength = int.Parse(cmdArgs[2]);

                if (initialIndex < 0 || initialIndex > fieldArray.Length - 1)
                {
                    continue;
                }
                if (fieldArray[initialIndex] != 1)
                {
                    continue;
                }

                fieldArray[initialIndex] = 0;

                var indexToMove = initialIndex;

                while (true)
                {
                    if (direction.Equals("right"))
                    {
                        indexToMove += flyLength;
                    }
                    else if (direction.Equals("left"))
                    {
                        indexToMove -= flyLength;
                    }

                    if (indexToMove < 0 || indexToMove > fieldArray.Length - 1)
                    {
                        break;
                    }

                    if (fieldArray[indexToMove] == 0)
                    {
                        fieldArray[indexToMove] = 1;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

            }

            Console.Write(string.Join(" ", fieldArray));
        }
    }
}
