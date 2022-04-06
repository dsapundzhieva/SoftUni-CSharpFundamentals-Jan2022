using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            var pascalTriangle = new long[numberOfLines][];

            for (int row = 0; row < numberOfLines; row++)
            {
                pascalTriangle[row] = new long[row + 1];

                for (int col = 0; col <= row; col++)
                {
                    if (row == col || row == 0 || col == 0)
                    {
                        pascalTriangle[row][col] = 1;
                    }
                    else
                    {
                        pascalTriangle[row][col] = pascalTriangle[row - 1][col - 1] + pascalTriangle[row - 1][col];
                    }
                }
            }

            for (int i = 0; i < numberOfLines; i++)
            {
                Console.WriteLine(string.Join(" ", pascalTriangle[i]));
            }
        }
    }
}
