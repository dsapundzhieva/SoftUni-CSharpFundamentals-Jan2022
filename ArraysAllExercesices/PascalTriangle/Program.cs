using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            var pascalTriangle = new int[input][];

            for (int row = 0; row < pascalTriangle.Length; row++)
            {
                pascalTriangle[row] = new int[row + 1];

                for (int col = 0; col <= row; col++)
                {
                    if (col == 0 || col == row)
                    {
                        pascalTriangle[row][col] = 1;

                    }
                    else
                    {
                        pascalTriangle[row][col] = pascalTriangle[row - 1][col - 1] + pascalTriangle[row - 1][col];
                    }
                }
            }

            for (int i = 0; i < pascalTriangle.Length; i++)
            {
                Console.WriteLine(string.Join(" ", pascalTriangle[i]));

            }
        }
    }
}
