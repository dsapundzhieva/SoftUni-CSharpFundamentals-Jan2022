using System;
using System.Linq;
using System.Text;

namespace _05_DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            var digit = new StringBuilder();
            var letter = new StringBuilder();
            var other = new StringBuilder();


            foreach (var item in input)
            {
                if (char.IsDigit(item))
                {
                    digit.Append(item);
                }
                else if (char.IsLetter(item))
                {
                    letter.Append(item);
                }
                else
                {
                    other.Append(item);
                }
            }

            Console.WriteLine(digit.ToString());
            Console.WriteLine(letter.ToString());
            Console.WriteLine(other.ToString());



            //var digit = input.Where(x => char.IsDigit(x)).ToArray();
            //var letter = input.Where(x => char.IsLetter(x)).ToArray();
            //var other = input.Where(x => !char.IsLetterOrDigit(x)).ToArray();

            //Console.WriteLine(digit.ToString());
            //Console.WriteLine(letter.ToString());
            //Console.WriteLine(other.ToString());
        }
    }
}
