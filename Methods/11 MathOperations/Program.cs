using System;

namespace _11_MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            string operatorSign = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());

            var result = Calculate(firstNum, operatorSign, secondNum);
            Console.WriteLine(result);
        }

        static double Calculate(int a , string operatorSign, int b)
        {
            var result = 0.00;
            switch (operatorSign)
            {
                case "/":
                    result = a / b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
