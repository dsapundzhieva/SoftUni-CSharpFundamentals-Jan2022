using System;

namespace PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());
            int[] numbers = new int[numberOfNumbers];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = numbers.Length-1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
