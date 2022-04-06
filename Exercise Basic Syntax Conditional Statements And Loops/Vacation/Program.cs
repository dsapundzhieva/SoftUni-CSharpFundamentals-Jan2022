using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            short countOfPeople = short.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double priceforOne;
            double priceforGroup;

            switch (dayOfWeek)
            {
                case "Friday":
                    switch (typeOfGroup)
                    {
                        case "Students":
                            priceforOne = 8.45;
                            priceforGroup = priceforOne * countOfPeople;
                            if (countOfPeople >= 30)
                            {
                                priceforGroup -= priceforGroup * 0.15;
                                Console.WriteLine($"Total price: {priceforGroup:f2}");
                            }
                            else
                            {
                                Console.WriteLine($"Total price: {priceforGroup:f2}");
                            }
                            break;
                        case "Business":
                            priceforOne = 10.90;
                            if (countOfPeople >= 100)
                            {
                                countOfPeople -= 10;
                                priceforGroup = countOfPeople * priceforOne;
                                Console.WriteLine($"Total price: {priceforGroup:f2}");
                            }
                            else
                            {
                                priceforGroup = priceforOne * countOfPeople;
                                Console.WriteLine($"Total price: {priceforGroup:f2}");
                            }
                            break;
                        case "Regular":
                            priceforOne = 15;
                            priceforGroup = priceforOne * countOfPeople;
                            if (countOfPeople >= 10 && countOfPeople <= 20)
                            {
                                priceforGroup -= priceforGroup * 0.05;
                                Console.WriteLine($"Total price: {priceforGroup:f2}");
                            }
                            else
                            {
                                Console.WriteLine($"Total price: {priceforGroup:f2}");
                            }
                            break;
                    }
                    break;
                case "Saturday":
                    switch (typeOfGroup)
                    {
                        case "Students":
                            priceforOne = 9.80;
                            priceforGroup = priceforOne * countOfPeople;
                            if (countOfPeople >= 30)
                            {
                                priceforGroup -= priceforGroup * 0.15;
                                Console.WriteLine($"Total price: {priceforGroup:f2}");
                            }
                            else
                            {
                                Console.WriteLine($"Total price: {priceforGroup:f2}");
                            }
                            break;
                        case "Business":
                            priceforOne = 15.60;
                            if (countOfPeople >= 100)
                            {
                                countOfPeople -= 10;
                                priceforGroup = countOfPeople * priceforOne;
                                Console.WriteLine($"Total price: {priceforGroup:f2}");
                            }
                            else
                            {
                                priceforGroup = priceforOne * countOfPeople;
                                Console.WriteLine($"Total price: {priceforGroup:f2}");
                            }
                            break;
                        case "Regular":
                            priceforOne = 20;
                            priceforGroup = priceforOne * countOfPeople;
                            if (countOfPeople >= 10 && countOfPeople <= 20)
                            {
                                priceforGroup -= priceforGroup * 0.05;
                                Console.WriteLine($"Total price: {priceforGroup:f2}");
                            }
                            else
                            {
                                Console.WriteLine($"Total price: {priceforGroup:f2}");
                            }
                            break;
                    }
                    break;
                case "Sunday":
                    switch (typeOfGroup)
                    {
                        case "Students":
                            priceforOne = 10.46;
                            priceforGroup = priceforOne * countOfPeople;
                            if (countOfPeople >= 30)
                            {
                                priceforGroup -= priceforGroup * 0.15;
                                Console.WriteLine($"Total price: {priceforGroup:f2}");
                            }
                            else
                            {
                                Console.WriteLine($"Total price: {priceforGroup:f2}");
                            }
                            break;
                        case "Business":
                            priceforOne = 16;
                            if (countOfPeople >= 100)
                            {
                                countOfPeople -= 10;
                                priceforGroup = countOfPeople * priceforOne;
                                Console.WriteLine($"Total price: {priceforGroup:f2}");
                            }
                            else
                            {
                                priceforGroup = priceforOne * countOfPeople;
                                Console.WriteLine($"Total price: {priceforGroup:f2}");
                            }
                            break;
                        case "Regular":
                            priceforOne = 22.50;
                            priceforGroup = priceforOne * countOfPeople;
                            if (countOfPeople >= 10 && countOfPeople <= 20)
                            {
                                priceforGroup -= priceforGroup * 0.05;
                                Console.WriteLine($"Total price: {priceforGroup:f2}");
                            }
                            else
                            {
                                Console.WriteLine($"Total price: {priceforGroup:f2}");
                            }
                            break;
                    }
                    break;
            }
        }
    }
}
