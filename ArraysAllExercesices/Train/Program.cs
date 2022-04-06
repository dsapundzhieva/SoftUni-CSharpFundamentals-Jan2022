using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfWagons = int.Parse(Console.ReadLine());

            int[] array = new int[numOfWagons];

            for (int i = 0; i < numOfWagons; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

              
            }

            int sum = array.Sum();
            Console.Write(string.Join(" ", array));
            Console.Write($"\n{sum}");
        }
    }
}
