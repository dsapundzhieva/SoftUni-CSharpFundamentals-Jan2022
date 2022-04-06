using System;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double balance = double.Parse(command);
            double price = 0;
            double spent = 0;

            while (!command.Equals("Game Time"))
            {
                command = Console.ReadLine();
                switch (command)
                {
                    case "OutFall 4":
                        price = 39.99;
                        if (balance < price)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else if (balance >= price)
                        {
                            Console.WriteLine($"Bought {command}");
                            spent += price;
                            balance -= price;
                        }
                        else if (balance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            break;
                        }
                        break;
                    case "CS: OG":
                        price = 15.99;
                        if (balance < price)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else if (balance >= price)
                        {
                            Console.WriteLine($"Bought {command}");
                            spent += price;
                            balance -= price;
                        }
                        else if (balance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            break;
                        }
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        if (balance < price)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else if (balance >= price)
                        {
                            Console.WriteLine($"Bought {command}");
                            spent += price;
                            balance -= price;
                        }
                        else if (balance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            break;
                        }
                        break;
                    case "Honored 2":
                        price = 59.99;
                        if (balance < price)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else if (balance >= price)
                        {
                            Console.WriteLine($"Bought {command}");
                            spent += price;
                            balance -= price;
                        }
                        else if (balance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            break;
                        }
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        if (balance < price)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else if (balance >= price)
                        {
                            Console.WriteLine($"Bought {command}");
                            spent += price;
                            balance -= price;
                        }
                        else if (balance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            break;
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        if (balance < price)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else if (balance >= price)
                        {
                            Console.WriteLine($"Bought {command}");
                            spent += price;
                            balance -= price;
                        }
                        else if (balance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            break;
                        }
                        break;
                    case "Game Time":
                        if (balance == 0)
                        {
                            Console.WriteLine("Out of money!");

                        }
                        else
                        {
                            Console.WriteLine($"Total spent: ${spent:f2}. Remaining: ${balance:f2}");
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
            }
        }
    }
}
