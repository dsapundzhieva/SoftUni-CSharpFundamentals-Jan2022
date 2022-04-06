using System;
using System.Collections.Generic;
using System.Linq;

namespace _15__PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            
            int sum = RemoveIncreaseAndDecrease(numbers);
            Console.WriteLine(sum);

        }

        static int RemoveIncreaseAndDecrease(List<int> numbers)
        {
            int sum = 0;

            while (numbers.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (!IsMoreThanZero(numbers, index))
                {
                    index = 0;
                    int lastElement = numbers.Last();
                    numbers.Insert(1, lastElement);
                }
                if (!isLessThanCount(numbers, index))
                {
                    index = numbers.Count-1;
                    int firstElement = numbers.First();
                    numbers.Insert(numbers.Count, firstElement);
                }

                int elementToBeRemoved = numbers[index];
                numbers.RemoveAt(index);

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (elementToBeRemoved >= numbers[i])
                    {
                        numbers[i] += elementToBeRemoved;
                    }
                    else
                    {
                        numbers[i] -= elementToBeRemoved;
                    }
                }
                sum += elementToBeRemoved;
            }

            return sum;
        }

        static bool IsMoreThanZero(List<int> numbers, int index)
        {
            return index >= 0;
        }

        static bool isLessThanCount(List<int> numbers, int index)
        {
            return index < numbers.Count;
        }
    }
}
