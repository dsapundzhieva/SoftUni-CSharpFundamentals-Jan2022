using System;
using System.Linq;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());


            switch (command)
            {
                case "add": 
                    Add(firstNumber, secondNumber);
                    break;
                case "multiply":
                    Multiply(firstNumber, secondNumber);
                    break;
                case "subtract":
                    Substract(firstNumber, secondNumber);
                    break;
                case "divide":
                    Divide(firstNumber, secondNumber);
                    break;
                default:
                    break;
            }
        }

         static void Divide(int v1, int v2)
        {
            var result = v1 / v2;
            Console.WriteLine(result);

        }

         static void Substract(int v1, int v2)
        {
            var result = v1 - v2;
            Console.WriteLine(result);

        }

         static void Multiply(int v1, int v2)
        {
            var result = v1 * v2;
            Console.WriteLine(result);

        }

         static void Add(int v1, int v2)
        {
            var result = v1 + v2;
            Console.WriteLine(result);
        }
    }
}
