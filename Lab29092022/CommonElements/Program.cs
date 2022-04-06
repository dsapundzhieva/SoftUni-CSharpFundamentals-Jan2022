using System;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split().ToArray();
            string[] secondArray = Console.ReadLine().Split().ToArray();

            string[] commonArray = new string[secondArray.Length];

            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int k = 0; k < firstArray.Length; k++)
                {
                    if (secondArray[i].Equals(firstArray[k]))
                    {
                        commonArray[i] = secondArray[i];
                    }
                }
            }

            commonArray = commonArray.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            foreach (var item in commonArray)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
