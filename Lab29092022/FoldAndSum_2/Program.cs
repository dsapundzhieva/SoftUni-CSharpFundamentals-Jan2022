using System;
using System.Linq;

namespace FoldAndSum_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var firstArray = new int[array.Length / 2];
            var secondArray = new int[array.Length / 2];
            var secondArrayIndex = 0;
            var firstArrayIndex = 0;
            var firstArrayIndexForSecondPart = array.Length - 1;

            for (int i = 0; i < array.Length; i++)
            {

                if (i >= 0 && i < array.Length / 4)
                {
                    firstArray[firstArrayIndex] = array[array.Length / 4 - i - 1];
                    firstArrayIndex++;
                }
                else if (i >= array.Length / 4 && i < array.Length / 4 + array.Length / 2)
                {
                    secondArray[secondArrayIndex] = array[i];
                    secondArrayIndex++;
                }

                else if (i >= array.Length - array.Length / 4)
                {
                    firstArray[firstArrayIndex] = array[firstArrayIndexForSecondPart];
                    firstArrayIndex++;
                    firstArrayIndexForSecondPart--;
                }
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] += secondArray[i];
            }
            Console.WriteLine(string.Join(" ", firstArray));
        }
    }
}
