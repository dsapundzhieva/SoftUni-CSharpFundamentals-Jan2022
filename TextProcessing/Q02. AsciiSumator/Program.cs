using System;

namespace Q02._AsciiSumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().ToCharArray();
            var secondLine = Console.ReadLine().ToCharArray();
            var randomString = Console.ReadLine().ToCharArray();

            int sum = 0;

            foreach (var item in randomString)
            {
                if (item > firstLine[0] && item < secondLine[0])
                {
                    sum += item;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
