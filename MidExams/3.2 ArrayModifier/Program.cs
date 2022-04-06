using System;
using System.Linq;

namespace _3._2_ArrayModifier
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
                var cmdType = cmdArgs[0];

                if (cmdType == "swap")
                {
                    int index1 = int.Parse(cmdArgs[1]);
                    int index2 = int.Parse(cmdArgs[2]);

                    array = Swap(array, index1, index2);
                }
                else if (cmdType == "multiply")
                {
                    int index1 = int.Parse(cmdArgs[1]);
                    int index2 = int.Parse(cmdArgs[2]);

                    array = Multiply(array, index1, index2);
                }
                else if (cmdType == "decrease")
                {
                    array = array.Select(x => x -= 1).ToArray();
                }
            }
            Console.WriteLine(string.Join(", ", array));
        }

        static int[] Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;

            return array;
        }

        static int[] Multiply(int[] array, int index1, int index2)
        {
            int multiply = array[index1] * array[index2];

            array[index1] = multiply;

            return array;
        }
    }
}
