using System;

namespace RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonacci(num));

        }

        public static long GetFibonacci(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            return GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }
    }
}
