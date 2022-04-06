using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseNumber = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());

            var result = MathPower(baseNumber, power);
            Console.WriteLine(result);
        }

        static double MathPower(double baseNumber, int power)
        {
            var result = 1.0;
            for (int i = 1; i <= power; i++)
            {
                result *= baseNumber;
            }
            return result;
        }
    }
}
