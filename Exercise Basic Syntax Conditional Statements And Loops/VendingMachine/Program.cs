using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double money;

            string command = Console.ReadLine();
            double sum = 0;
            double productPrice = 0;

            while (!command.Equals("Start"))
            {
                money = double.Parse(command);
                switch (money)
                {
                    case 0.1:
                        sum += money;
                        break;
                    case 0.2:
                        sum += money;
                        break;
                    case 0.5:
                        sum += money;
                        break;
                    case 1:
                        sum += money;
                        break;
                    case 2:
                        sum += money;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {command}");
                        break;
                }
                command = Console.ReadLine();
            }

            while (!command.Equals("End"))
            {
                command = Console.ReadLine();
                switch (command)
                {
                    case "Nuts":
                        productPrice = 2;
                        if (sum >= productPrice)
                        {
                            sum -= productPrice;
                            Console.WriteLine($"Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        productPrice = 0.7;
                        if (sum >= productPrice)
                        {
                            sum -= productPrice;
                            Console.WriteLine($"Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        productPrice = 1.5;
                        if (sum >= productPrice)
                        {
                            sum -= productPrice;
                            Console.WriteLine($"Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        productPrice = 0.8;
                        if (sum >= productPrice)
                        {
                            sum -= productPrice;
                            Console.WriteLine($"Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        productPrice = 1;
                        if (sum >= productPrice)
                        {
                            sum -= productPrice;
                            Console.WriteLine($"Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "End":
                        Console.WriteLine($"Change: {sum:f2}");
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
            }    
        }
    }
}
