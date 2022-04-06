using System;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int[] numbers = new int[3];
            for (int i = 0; i <= numbers.Length-1; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Array.Sort(numbers);
                Array.Reverse(numbers);
                Console.WriteLine(numbers[i].ToString());
            }
        }
    }
}
