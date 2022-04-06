using System;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] nums = Console.ReadLine().Split(" ");

            double[] doubledNums = new double[nums.Length];

            int[] roundedNums = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                doubledNums[i] = double.Parse(nums[i]);
                roundedNums[i] = (int)Math.Round(doubledNums[i], MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < roundedNums.Length; i++)
            {
                Console.WriteLine($"{doubledNums[i]} => {roundedNums[i]}");
            }
        }
    }
}
