using System;

namespace SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(" ");
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int[] numArray = new int[array.Length];
                numArray[i] = int.Parse(array[i]);
                if (numArray[i] % 2 == 0)
                {
                    sum += numArray[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
