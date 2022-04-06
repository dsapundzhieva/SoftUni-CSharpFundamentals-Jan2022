using System;
using System.Linq;

namespace _04._TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bannedList = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();

            foreach (var item in bannedList)
            {
                input = input.Replace(item, new string('*', item.Length));
            }
            Console.WriteLine(input);
        }
    }
}
