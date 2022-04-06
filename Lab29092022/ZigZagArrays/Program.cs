using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            string[] array = new string[numberOfLines];

            for (int i = 0; i < numberOfLines; i++)
            {
                var userInput = Console.ReadLine();
                var reversed = userInput.Split(" ").Select(int.Parse).Reverse();
                array[i] = i % 2 == 0 ? userInput : string.Join(" ", reversed);
            }

            string newArray = string.Join(" ", array);
            int[] finalArray = newArray.Split(" ").Select(int.Parse).ToArray();

            int[] firstArray = new int[finalArray.Length];
            int[] secondArray = new int[finalArray.Length];

            for (int i = 0; i < finalArray.Length; i++)
            {
                firstArray[i] = i % 2 == 0 ? finalArray[i] : firstArray[i];
                secondArray[i] = i % 2 != 0 ? finalArray[i] : secondArray[i];
            }

            /*int[] firstArray = finalArray.Where(i => i % 2 == 0).ToArray();
            int[] secondArray = finalArray.Where(i => i % 2 != 0).ToArray();
      */

            firstArray = firstArray.Where(i => i != 0).ToArray();
            secondArray = secondArray.Where(i => i != 0).ToArray();

            foreach (var item in firstArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            foreach (var item in secondArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}
