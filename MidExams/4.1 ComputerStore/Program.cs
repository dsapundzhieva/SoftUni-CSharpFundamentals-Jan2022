using System;
using System.Linq;

namespace _4._1_ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            double sum = 0;

            while (true)
            {
                command = Console.ReadLine();
                if (command == "special" || command == "regular")
                {
                    break;
                }
                else
                {
                    var cmdArgs = command
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                         .Select(double.Parse)
                        .ToArray();

                    if (cmdArgs[0] >= 0)
                    {
                        sum += cmdArgs[0];
                    }
                    else
                    {
                        Console.WriteLine("Invalid price!");
                        continue;
                    }
                }
            }

            var taxes = sum * 0.20;
            var totalPrice = sum + taxes;
            var specialTotalPRice = totalPrice - (totalPrice * 0.10);

            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            else
            {
                if (command == "special")
                {
                    Console.WriteLine($"Congratulations you've just bought a new computer!\nPrice without taxes: {sum:f2}$\nTaxes: {taxes:f2}$\n-----------\nTotal price: {specialTotalPRice:f2}$");
                }
                else
                {
                    Console.WriteLine($"Congratulations you've just bought a new computer!\nPrice without taxes: {sum:f2}$\nTaxes: {taxes:f2}$\n-----------\nTotal price: {totalPrice:f2}$");
                }
            }
        }
    }
}
