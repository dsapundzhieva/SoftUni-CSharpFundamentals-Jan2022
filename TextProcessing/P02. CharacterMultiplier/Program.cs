using System;
using System.Linq;

namespace P02._CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


            var first = command[0].ToCharArray();
            var second = command[1].ToCharArray();

            long sum = 0;

            if (first.Length > second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    char letterFirst = first[i];

                    if (i > second.Length-1)
                    {
                        sum += letterFirst;
                        continue;
                    }
                    char letterSecond = second[i];

                    sum += letterFirst * letterSecond;
                }
            }
            else
            {
                for (int i = 0; i < second.Length; i++)
                {
                    char letterSecond = second[i];

                    if (i > first.Length-1)
                    {
                        sum += letterSecond;
                        continue;
                    }
                    char letterFirst = first[i];
                    sum += letterFirst * letterSecond;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
