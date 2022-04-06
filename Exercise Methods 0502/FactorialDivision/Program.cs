using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            var firstFactorial = GetFactorial(first);
            var secondFactorial = GetFactorial(second);
            var result = firstFactorial / secondFactorial;

            Console.WriteLine($"{result:f2}");
        }

        static double GetFactorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num * GetFactorial(num-1)
            }
        }

        static double GetFactorialSecond(int num)
        {
            var result = 1.0;

            while (num > 0)
            {
                result *= num;
                num--;
            }

            return result;
        }
    }
}
