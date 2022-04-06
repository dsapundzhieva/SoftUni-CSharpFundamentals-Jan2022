using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;
                for (int k = 0; k < array.Length; k++)
                {

                    if (k < i)
                    {
                        sumLeft += array[k];
                    }
                    else if (k > i)
                    {
                        sumRight += array[k];
                    }
                }
                if (sumLeft == sumRight)
                {
                    index = i;
                }
            }

            if (array.Length == 1)
            {
                Console.WriteLine(index);
            }
            else if (index == int.MinValue)
            {

                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }
}
