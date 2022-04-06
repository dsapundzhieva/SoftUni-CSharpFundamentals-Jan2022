using System;
using System.Linq;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();
            var index = 0;
            bool areEqual = false;

            for (int i = 0; i < array.Length; i++)
            {
                var leftSum = 0;
                var rightSum = 0;
                for (int k = 0; k < array.Length; k++)
                {
                    if (k < i)
                    {
                        leftSum += array[k];
                    }
                    else if (k > i)
                    {
                        rightSum += array[k];
                    }
                }
                if (leftSum == rightSum)
                {
                    index = i;
                    areEqual = true;
                    break;
                }
                areEqual = false;
            }
            if (areEqual)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
