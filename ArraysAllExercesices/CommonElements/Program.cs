using System;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] secondArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] commonElements = new string[firstArray.Length];

            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int k = 0; k < firstArray.Length; k++)
                {
                    if (secondArray[i].Contains(firstArray[k]))
                    {
                        commonElements[i] = secondArray[i];
                    }
                }
            }
            commonElements = commonElements.Where(c => !string.IsNullOrEmpty(c)).ToArray();
            Console.Write(string.Join(" ", commonElements));
        }
    }
}
