using System;

namespace _04_TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[] tribonacci = GetTribonacciSequence(num);
            Console.WriteLine(string.Join(" ", tribonacci));
        }

        static int[] GetTribonacciSequence(int num)
        {
            int[] array = new int[num];
            array[0] = 1;
            array[1] = 1;
            array[2] = 2;
            int index = 0;

            for (int i = 3; i < num; i++)
            {
                array[i] = array[i - 1] + array[i - 2] + array[index];
                index++;
            }
            return array;
        }
    }
}
