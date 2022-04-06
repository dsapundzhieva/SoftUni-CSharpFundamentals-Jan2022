using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19_TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();


            List<int> numbers = input
                .Where(x => Char.IsDigit(x))
                .Select(x => int.Parse(x.ToString()))
                .ToList();


            List<int> takeList = numbers
                .Where((x, index) => index % 2 == 0)
                .ToList();

            List<int> skipList = numbers
                .Where((x, index) => index % 2 != 0)
                .ToList();

            string word = new string(input.Where(x => x < '0' || x > '9').ToArray());


            //string word = AlphaOnly(input);

            int evenIndex = -1;
            int oddIndex = -1;
            int currentIndex = 0;

            List<string> partitions = new List<string>();

            for (int i = 0; i < takeList.Count; i++)
            {
                evenIndex = takeList[i];
                oddIndex = skipList[i];

                var currentPartition = word
                    .Skip(currentIndex)
                    .Take(evenIndex)
                    .ToArray();

                currentIndex = evenIndex + oddIndex + currentIndex;
                partitions.Add(new string(currentPartition));
            }

            Console.WriteLine(String.Join("", partitions));
        }

        //static string AlphaOnly(string text)
        //{
        //    var result = "";

        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        if (text[i] < '0' || text[i] > '9')
        //        {
        //            result += text[i];
        //        }
        //    }

        //    return result;
        //}
    }
}
