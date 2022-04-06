using System;

namespace _01_SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            var minValue = GetSmallestNumber(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(minValue);
        }

        static int GetSmallestNumber(int first, int second, int third)
        {

            if (first < second && first < third)
            {
                return first;
            }
            else if (second < first && second < third)
            {
                return second;
            }
            return third;
        }
    }
}
