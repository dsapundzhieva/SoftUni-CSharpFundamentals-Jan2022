using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P05._MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine().TrimStart(new char[] { '0'});

            char[] bigArray = bigNumber.ToCharArray();

            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("0");
                return;
            }
           
            List<string> newNum = new List<string>();

            int reminder = 0;

            for (int i = bigArray.Length-1; i >= 0; i--)
            {
                int current = int.Parse(bigNumber[i].ToString());

                reminder = (current * number) + reminder;

                string lastDigit = (reminder % 10).ToString();
                newNum.Insert(0, lastDigit);
                reminder /= 10;
            }


            if (reminder > 0)
            {
                Console.WriteLine($"{reminder}{string.Join("",newNum)}");
            }
            else
            {
                Console.WriteLine($"{string.Join("", newNum)}");
            }
        }
    }
}
