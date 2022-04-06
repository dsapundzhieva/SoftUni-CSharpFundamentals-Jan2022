using System;

namespace RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonaci(input));
        }

        public static int GetFibonaci(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            else
            {
                return GetFibonaci(n - 1) + GetFibonaci(n - 2);
            }
        }
    }
}
