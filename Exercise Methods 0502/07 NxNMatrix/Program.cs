using System;

namespace _07_NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                PrintSingleLine(number);
            }
        }

        static void PrintSingleLine (int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
