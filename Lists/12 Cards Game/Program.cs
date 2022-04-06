using System;
using System.Collections.Generic;
using System.Linq;

namespace _12_Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToList();

            List<int> secondHand = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            CardGames(firstHand, secondHand);
        }

        static void CardGames(List<int> first, List<int> second)
        {

            while (first.Count != 0 && second.Count != 0)
            {
                int firstElementFirstPlayer = first[0];
                int firstElementSecondPlayer = second[0];

                if (firstElementFirstPlayer > firstElementSecondPlayer)
                {
                    first.Add(firstElementFirstPlayer);
                    first.Add(firstElementSecondPlayer);
                    first.RemoveAt(0);
                    second.RemoveAt(0);
                }
                else if (firstElementSecondPlayer > firstElementFirstPlayer)
                {
                    second.Add(firstElementSecondPlayer);
                    second.Add(firstElementFirstPlayer);
                    second.RemoveAt(0);
                    first.RemoveAt(0);
                }
                else if (firstElementSecondPlayer == firstElementFirstPlayer)
                {
                    first.RemoveAt(0);
                    second.RemoveAt(0);
                }
            }

            if (first.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {second.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {first.Sum()}");
            }

        }
    }
}
