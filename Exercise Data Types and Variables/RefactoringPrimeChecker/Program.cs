using System;

namespace RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToCalculate = int.Parse(Console.ReadLine());

            for (int i = 2; i <= numberToCalculate; i++)
            {
                bool isPrime = true; //devided by itslef or 1 & grater than 1

                for (int k = 2; k < i; k++)
                {
                    if (i % k == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime.ToString().ToLower()}");
            }
        }
    }
}
