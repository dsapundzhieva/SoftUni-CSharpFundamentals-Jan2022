using System;
using System.Text;

namespace P07._StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int bombPower = 0;

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                var currElement = input[i];

                if (currElement == '>')
                {
                    bombPower += int.Parse(input[i + 1].ToString());
                }
                else if (bombPower > 0)
                {
                    bombPower--;
                    continue;
                }
                result.Append(currElement);
            }

            Console.WriteLine(result);
        }
    }
}
