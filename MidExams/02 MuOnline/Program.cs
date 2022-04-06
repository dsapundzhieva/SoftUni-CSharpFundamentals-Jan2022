using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = 100;
            int initialBitcoins = 0;

            List<string> rooms = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();

            if (initialHealth > 0)
            {
                for (int i = 0; i < rooms.Count; i++)
                {
                    var command = rooms[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    var cmdType = command[0];
                    var number = int.Parse(command[1]);

                    if (cmdType == "potion")
                    {
                        int reminder = 100 - initialHealth;
                        if (reminder < number)
                        {
                            initialHealth += reminder;
                            Console.WriteLine($"You healed for {reminder} hp.");
                            Console.WriteLine($"Current health: {initialHealth} hp.");
                        }
                        else
                        {
                            initialHealth += number;
                            Console.WriteLine($"You healed for {number} hp.");
                            Console.WriteLine($"Current health: {initialHealth} hp.");
                        }
                        
                    }
                    else if (cmdType == "chest")
                    {
                        initialBitcoins += number;
                        Console.WriteLine($"You found {number} bitcoins.");
                    }
                    else
                    {
                        if (initialHealth > number)
                        {
                            initialHealth -= number;
                            Console.WriteLine($"You slayed {cmdType}.");
                        }
                        else
                        {
                            initialHealth -= number;
                            Console.WriteLine($"You died! Killed by {cmdType}.\nBest room: {i + 1}");
                            return;
                        }
                    }
                }
                Console.WriteLine($"You've made it!\nBitcoins: {initialBitcoins}\nHealth: {initialHealth}");

                //if (initialHealth > 0)
                //{
                //    Console.WriteLine($"You've made it!\nBitcoins: {initialBitcoins}\nHealth: {initialHealth}");
                //}
            }
        }
    }
}
