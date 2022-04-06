using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] bombInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int bombNum = bombInfo[0];
            int power = bombInfo[1];

            while (true)
            {
                int indexOfBomb = numbers.IndexOf(bombNum);
                 
                if (indexOfBomb == -1)
                {
                    break;
                }

                DetonateBomb(numbers, indexOfBomb, power);
            }

            Console.WriteLine(numbers.Sum());
        }


        static void DetonateBomb(List<int> numbers, int indexOfBomb, int power)
        {
            int rightCount = indexOfBomb + power;

            for (int count = indexOfBomb; count <= rightCount; count++)
            {
                if (indexOfBomb >= numbers.Count)
                {
                    break;
                }
                numbers.RemoveAt(indexOfBomb);
            }

            int leftCount = indexOfBomb - power;

            if (leftCount < 0)
            {
                leftCount = 0;
            }

            for (int count = leftCount; count < indexOfBomb; count++)
            {
                if (leftCount >= numbers.Count)
                {
                    break;
                }
                numbers.RemoveAt(leftCount);
            }
        }
    }
}
