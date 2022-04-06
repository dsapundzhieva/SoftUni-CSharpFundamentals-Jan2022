using System;

namespace FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool isTrue = Math.Abs(numberOne - numberTwo) < eps;

            if (isTrue)
            {
                Console.WriteLine(isTrue);
            }
            else
            {
                Console.WriteLine(isTrue);
            }
        }
    }
}
