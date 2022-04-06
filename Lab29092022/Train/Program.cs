using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[int.Parse(Console.ReadLine())];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
            }

            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\n{sum}");
        }
    }
}
