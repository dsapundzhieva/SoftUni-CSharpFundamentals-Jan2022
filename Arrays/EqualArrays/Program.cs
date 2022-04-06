using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sum = 0;
            int indexDiff = 0;
            bool areEqual = false;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    sum += firstArray[i];
                    areEqual = true;
                }
                else
                {
                    indexDiff = i;
                    areEqual = false;
                    break;
                }
            }
            if (areEqual)
            {
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {indexDiff} index");
            }
        }
    }
}
