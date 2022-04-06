using System;

namespace EnglishNameОfТheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            ReadLastDigit(num);
        }

        public static void ReadLastDigit(int number)
        {
            int lastDigit = number % 10;

            switch (lastDigit)
            {
                case 1:
                    if (lastDigit == 1)
                    {
                        Console.WriteLine("one");
                    }
                    break;
                case 2:
                    if (lastDigit == 2)
                    {
                        Console.WriteLine("two");
                    }
                    break;
                case 3:
                    if (lastDigit == 3)
                    {
                        Console.WriteLine("three");
                    }
                    break;
                case 4:
                    if (lastDigit == 4)
                    {
                        Console.WriteLine("four");
                    }
                    break;
                case 5:
                    if (lastDigit == 5)
                    {
                        Console.WriteLine("five");
                    }
                    break;
                case 6:
                    if (lastDigit == 6)
                    {
                        Console.WriteLine("six");
                    }
                    break;
                case 7:
                    if (lastDigit == 7)
                    {
                        Console.WriteLine("seven");
                    }
                    break;
                case 8:
                    if (lastDigit == 8)
                    {
                        Console.WriteLine("eight");
                    }
                    break;
                case 9:
                    if (lastDigit == 9)
                    {
                        Console.WriteLine("nine");
                    }
                    break;
                case 0:
                    if (lastDigit == 0)
                    {
                        Console.WriteLine("zero");
                    }
                    break;
            }
        }
    }
}
