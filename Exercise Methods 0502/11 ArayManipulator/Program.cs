using System;
using System.Linq;

namespace _11_ArayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                var cmdArgs = command.Split(" ");
                string commandType = cmdArgs[0];

                if (commandType == "exchange")
                {
                    int exchangeIndex = int.Parse(cmdArgs[1]);

                    if (exchangeIndex < 0 || exchangeIndex > array.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    else
                    {
                        array = ExchangeByIndex(array, exchangeIndex);
                    }
                }
                else if (commandType == "max" || commandType == "min")
                {
                    string evenOrOdd = cmdArgs[1];

                    int index = commandType == "max" ? GetMaxOddEvenIndex(array, evenOrOdd) : GetMinOddEvenIndex(array, evenOrOdd);

                    if (index < 0)
                    {
                        Console.WriteLine("No matches");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(index);
                    }
                }
                else if (commandType == "first" || commandType == "last")
                {
                    int count = int.Parse(cmdArgs[1]);
                    string evenOrOdd = cmdArgs[2];

                    //int[] newArray = commandType == "first" ? GetFirstEvenOddNumbers(array, count, evenOrOdd) : GetLastEvenOddNumbers(array, count, evenOrOdd);

                    if (count > array.Length || count < 0)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    else
                    {
                        if (commandType == "first")
                        {
                            GetFirstEvenOddNumbers(array, count, evenOrOdd);
                        }
                        else if (commandType == "last")
                        {
                            GetLastEvenOddNumbers(array, count, evenOrOdd);
                        }
                    }
                }
            }
            Console.WriteLine(PrintArray(array, array.Length));
        }

        static int[] ExchangeByIndex(int[] array, int index)
        {
            int[] exchangedArray = new int[array.Length];
            int exchangedIndex = 0;

            for (int i = index + 1; i < array.Length; i++)
            {
                exchangedArray[exchangedIndex] = array[i];
                exchangedIndex++;
            }
            for (int i = 0; i <= index; i++)
            {
                exchangedArray[exchangedIndex] = array[i];
                exchangedIndex++;
            }
            return exchangedArray;
        }

        static int GetMaxOddEvenIndex(int[] array, string oddEven)
        {
            int maxIndex = -1;
            int maxNumber = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= maxNumber)
                {
                    if (array[i] % 2 == 0 && oddEven == "even")
                    {
                        maxNumber = array[i];
                        maxIndex = i;
                    }
                    else if (array[i] % 2 != 0 && oddEven == "odd")
                    {
                        maxNumber = array[i];
                        maxIndex = i;
                    }
                }
            }
            return maxIndex;
        }

        static int GetMinOddEvenIndex(int[] array, string oddEven)
        {
            int minIndex = -1;
            int minNumber = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= minNumber)
                {
                    if (array[i] % 2 == 0 && oddEven == "even")
                    {
                        minNumber = array[i];
                        minIndex = i;
                    }
                    else if (array[i] % 2 != 0 && oddEven == "odd")
                    {
                        minNumber = array[i];
                        minIndex = i;
                    }
                }
            }
            return minIndex;
        }

        static void GetFirstEvenOddNumbers(int[] array, int count, string evenOrOdd)
        {
            int[] firstEvenOddElements = new int[count];
            int index = 0;
            //int[] test = array.Where(t => t % 2 == 0).Take(count).ToArray();


            for (int i = 0; i < array.Length; i++)
            {
                if (evenOrOdd == "even")
                {
                    if (array[i] % 2 == 0 && index < count)
                    {
                        firstEvenOddElements[index] = array[i];
                        index++;
                    }
                }
                else if (evenOrOdd == "odd")
                {
                    if (array[i] % 2 != 0 && index < count)
                    {
                        firstEvenOddElements[index] = array[i];
                        index++;
                    }
                }
            }
            Console.WriteLine(PrintArray(firstEvenOddElements, index));
        }

        static void GetLastEvenOddNumbers(int[] array, int count, string evenOrOdd)
        {
            int currCount = 0;
            int[] lastEvenOddElements = new int[count];
            int index = lastEvenOddElements.Length - 1;

            for (
                int i = array.Length - 1; i >= 0; i--)
            {
                if (evenOrOdd == "even")
                {
                    if (array[i] % 2 == 0 && currCount < count)
                    {
                        lastEvenOddElements[index] = array[i];
                        currCount++;
                    }
                }
                else if (evenOrOdd == "odd")
                {
                    if (array[i] % 2 != 0 && currCount < count)
                    {
                        lastEvenOddElements[index] = array[i];
                        currCount++;
                    }
                }
                index--;
            }
            Console.WriteLine(PrintArray(lastEvenOddElements, currCount));
        }

        static string PrintArray(int[] arr, int elementsCount)
        {
            string output = string.Empty;
            output += "[";

            for (int i = 0; i < elementsCount; i++)
            {
                if (i == elementsCount - 1)
                {
                    output += $"{arr[i]}";
                }
                else
                {
                    output += $"{arr[i]}, ";
                }
            }

            output += "]";

            return output;
        }
    }
}
