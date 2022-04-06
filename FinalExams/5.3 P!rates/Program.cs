using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._3_P_rates
{
    class City
    {
        public City(int population, int gold)
        {
            this.Population = population;
            this.Gold = gold;
        }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string command;

            Dictionary<string, City> cityList = new Dictionary<string, City>();

            while ((command = Console.ReadLine()) != "Sail")
            {
                var cmdArgs = command.Split("||", StringSplitOptions.RemoveEmptyEntries);

                string name = cmdArgs[0];
                int population = int.Parse(cmdArgs[1]);
                int gold = int.Parse(cmdArgs[2]);

                City city = new City(population, gold);


                if (!cityList.ContainsKey(name))
                {
                    cityList.Add(name, city);
                }
                else
                {
                    cityList[name].Population += population;
                    cityList[name].Gold += gold;
                }
            }

            string commandEnd;

            while ((commandEnd = Console.ReadLine()) != "End")
            {
                var cmdArgs = commandEnd.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                if (cmdType == "Plunder")
                {
                    string cityName = cmdArgs[1];
                    int people = int.Parse(cmdArgs[2]);
                    int gold = int.Parse(cmdArgs[3]);

                    cityList[cityName].Population -= people;
                    cityList[cityName].Gold -= gold;
                    Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (cityList[cityName].Population <= 0 || cityList[cityName].Gold <= 0)
                    {
                        Console.WriteLine($"{cityName} has been wiped off the map!");
                        cityList.Remove(cityName);
                    }
                }
                else if (cmdType == "Prosper")
                {
                    string cityName = cmdArgs[1];
                    int gold = int.Parse(cmdArgs[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                    else
                    {
                        if (cityList.ContainsKey(cityName))
                        {
                            cityList[cityName].Gold += gold;
                            Console.WriteLine($"{gold} gold added to the city treasury. {cityName} now has {cityList[cityName].Gold} gold.");
                        }
                    }
                }
            }

            if (cityList.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cityList.Count} wealthy settlements to go to:");

                foreach (var item in cityList)
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value.Population} citizens, Gold: {item.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
