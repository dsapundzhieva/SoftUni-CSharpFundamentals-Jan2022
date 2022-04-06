
using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            var firstInput = Console.ReadLine();
            var secondInput = Console.ReadLine();

            switch (input)
            {
                case "int":
                    var firstNumber = int.Parse(firstInput);
                    var secondNumber = int.Parse(secondInput);
                    var resultInt = GetMax(firstNumber, secondNumber);
                    Console.WriteLine(resultInt);
                    break;
                case "char":
                    var firstChar = char.Parse(firstInput);
                    var secondChar = char.Parse(secondInput);
                    var resultChar = GetMax(firstChar, secondChar);
                    Console.WriteLine(resultChar);

                    break;
                case "string":
                    var resultString = GetMax(firstInput, secondInput);
                    Console.WriteLine(resultString);
                    break;
                default:
                    break;
            }
        }

       
       static int GetMax(int firstNumber, int secondNumber)
        {
            return firstNumber >= secondNumber ? firstNumber : secondNumber;
        }

        static char GetMax(char firstChar, char secondChar)
        {
            return firstChar >= secondChar ? firstChar : secondChar;
        }

        static string GetMax(string firstInput, string secondInput)
        {
            return firstInput.CompareTo(secondInput) >= 0 ? firstInput : secondInput;
        }
    }
}
