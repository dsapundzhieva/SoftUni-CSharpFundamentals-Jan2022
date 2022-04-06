using System;

namespace _11_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplyInt = 2;
            double multiplyDouble = 1.5;

            var input = Console.ReadLine();

            switch (input)
            {
                case "int":
                    int intNum = GetDataType(int.Parse(Console.ReadLine()), multiplyInt);
                    Console.WriteLine(intNum);
                    break;
                case "real":
                    double realNum = GetDataType(double.Parse(Console.ReadLine()), multiplyDouble);
                    Console.WriteLine($"{realNum:f2}");
                    break;
                case "string":
                    string inputString = GetDataType(Console.ReadLine());
                    Console.WriteLine(inputString);
                    break;
                default:
                    Console.WriteLine("Ivalid data type");
                    break;
            }
        }

        static int GetDataType(int number, int multiply)
        {
            return number * multiply;
        }

        static double GetDataType(double number, double multiply)
        {
            return number * multiply;
        }
        static string GetDataType(string input)
        {
            string result = string.Empty;

            return result += $"${input}$";
        }
    }
}
