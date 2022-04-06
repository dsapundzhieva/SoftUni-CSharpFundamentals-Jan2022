using System;

namespace PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int numToStart = int.Parse(Console.ReadLine());
            int numToEnd = int.Parse(Console.ReadLine());

            for (int i = numToStart; i <= numToEnd; i++)
            {
                char numberToChar = (char)(i);
                //char charToChar = Convert.ToChar(i);
                Console.Write($"{numberToChar} ");
            }
        }
    }
}
