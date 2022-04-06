using System;

namespace _15_Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            string result = GetMultiplicationSign(num1, num2, num3);

            Console.WriteLine(result);
        }

        static string GetMultiplicationSign(int num1, int num2, int num3)
        {
            int first = Math.Sign(num1);
            int second = Math.Sign(num2);
            int third = Math.Sign(num3);

            int count = 0;
            string result = string.Empty;

            for (int i = 0; i < 1; i++)
            {
                if (first < 0)
                {
                    count++;
                }
                else if (second < 0)
                {
                    count++;
                }
                else if (third < 0)
                {
                    count++;
                }
            }

            if (first == 0 || second == 0 || third == 0)
            {
                result += "zero";
            }
            else if (count % 2 == 0)
            {
                result += "positive";
            }
            else
            { 
                result += "negative";
            }
            return result;
        }
    }
}
