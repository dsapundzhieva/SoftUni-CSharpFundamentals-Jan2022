using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> bombNumber = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            for (int i = 0; i < integers.Count; i++)
            {
                int bombNum = bombNumber[0];
                int power = bombNumber[1];

                if (integers[i] == bombNum)
                {
                    integers.Remove(bombNum);

                    int index = i;

                    for (int g = 0; g < Math.Abs(power); g++)
                    {
                        if (index < integers.Count)
                        {
                            integers.RemoveAt(index);
                        }
                        if (index - 1 >= 0 && index - 1 < integers.Count)
                        {
                            integers.RemoveAt(index - 1);
                            index--;
                        }
                    }
                    i = -1;
                }
       
            }
            Console.WriteLine(integers.Sum());
        }
    }
}
