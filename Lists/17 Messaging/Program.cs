using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17_Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> listOfNumbers = Console.ReadLine()
            //   .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //   .Aggregate(new List<int>(), (list, currString) =>
            //   {
            //       list.Add(sumDigits(currString));
            //       return list;
            //   })
            //   .ToList();

            Func<string, int> sumDigits = numbers => numbers.Aggregate(0, (total, currNumber) => total + int.Parse(currNumber.ToString()));

            List<int> listOfNumbers = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(sumDigits)
               .ToList();

            string listOfString = Console.ReadLine();
            var result = string.Empty;


            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                var index = listOfNumbers[i] % listOfString.Length;

                var letter = listOfString[index];

                result += listOfString.Substring(index, 1);
                listOfString = listOfString.Remove(index, 1);
            }

            Console.WriteLine(result);
        }

        //static int SumOfDigits(string numbers) => numbers.Aggregate(0, (total, currNumber) => total + int.Parse(currNumber.ToString()));
    }
}
