using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int maxCount = 0;
            int maxSequenceValue = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;

                for (int k = i; k < array.Length-1; k++)
                {
                    if (array[i] == array[k + 1])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    maxSequenceValue = array[i];
                }
            }

            int[] newArray = new int[maxCount + 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = maxSequenceValue;
            }

            foreach (var item in newArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}
