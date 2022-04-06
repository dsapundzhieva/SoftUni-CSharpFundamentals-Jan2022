using System;

namespace _05_AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int result = SubstractLastIntegersFromAGivenSum(firstNum, secondNum, thirdNum);

            Console.WriteLine(result);


        }

        static int GetSumOfFirstTwoIntegers(int first, int second)
        {
            return first + second;
        }

        static int SubstractLastIntegersFromAGivenSum(int first, int second, int third)
        {
            var sumOfFirstIntegers = GetSumOfFirstTwoIntegers(first, second);

            return sumOfFirstIntegers - third;
        }
    }
}
