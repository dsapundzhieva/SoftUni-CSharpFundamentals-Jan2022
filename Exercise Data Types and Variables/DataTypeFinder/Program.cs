using System;

namespace DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                var input = Console.ReadLine();
                if (input.Equals("END"))
                {
                    break;
                }
                bool isInteger = int.TryParse(input, out int integer);
                bool isBoolean = bool.TryParse(input, out bool boolean);
                bool isChar = char.TryParse(input, out char charInput);
                bool isFloat = decimal.TryParse(input, out decimal floatInput);

                if (isInteger)
                {
                    Console.WriteLine($"{integer} is integer type");
                }
                else if (isBoolean)
                {
                    Console.WriteLine($"{boolean.ToString().ToLower()} is boolean type");
                }
                else if (isChar)
                {
                    Console.WriteLine($"{charInput} is character type");
                }
                else if (isFloat)
                {
                    Console.WriteLine($"{floatInput} is floating point type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
            }
        }
    }
}
