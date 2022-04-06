using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            bool isTop = false;
            int[] topsArray = new int[array.Length];
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int k = 0; k < array.Length - 1 - i; k++)
                {
                    
                    if (array[i] > array[k + i + 1])
                    {
                        isTop = true;
                    }
                    else
                    {
                        isTop = false;
                        break;
                    }
                }
                if (isTop && i != array.Length-1)
                {
                    topsArray[counter] = array[i];
                    counter++;
                }
                if (i == array.Length-1 && array[i] != 0)
                {
                    topsArray[counter] = array[i];
                }
                else if (i == array.Length - 1 && array[i] == 0)
                {
                    topsArray[counter] = int.MinValue;
                }
            }


            topsArray = topsArray.Where(x => x != 0).ToArray();

            for (int i = 0; i < topsArray.Length; i++)
            {
                if (topsArray[topsArray.Length-1] == int.MinValue)
                {
                    topsArray[topsArray.Length - 1] = 0;
                }
            }

            foreach (var item in topsArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}
