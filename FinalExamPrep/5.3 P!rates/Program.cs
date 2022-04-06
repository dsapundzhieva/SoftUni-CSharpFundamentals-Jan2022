using System;
using System.Collections.Generic;

namespace _5._3_P_rates
{
    class City
    {
        public City(string cityName, int population, int gold)
        {
            this.CityName = cityName;
            this.Population = population;
            this.Gold = gold;
        }
        public string CityName { get; set; }

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

                string cityName = cmdArgs[0];
                int population = int.Parse(cmdArgs[1]);
                int gold = int.Parse(cmdArgs[2]);

                City city = new City(cityName, population, gold);

                if (cityList.ContainsKey(cityName))
                {
                    cityList[cityName].Population += population;
                    cityList[cityName].Gold += gold;
                }
                else
                {
                    cityList.Add(cityName, city);
                }
            }

            string secCommand;

            while ((secCommand = Console.ReadLine()) != "End")
            {
                var cmdArgs = secCommand.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                if (cmdType == "Plunder")
                {
                    string cityName = cmdArgs[1];
                    int people = int.Parse(cmdArgs[2]);
                    int gold = int.Parse(cmdArgs[3]);

                    if (cityList.ContainsKey(cityName))
                    {
                        cityList[cityName].Population -= people;
                        cityList[cityName].Gold -= gold;
                        Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {people} citizens killed.");
                    }
                    if (cityList[cityName].Population <= 0 || cityList[cityName].Gold <= 0)
                    {
                        cityList.Remove(cityName);
                        Console.WriteLine($"{cityName} has been wiped off the map!");
                    }
                }
                else if (cmdType == "Prosper")
                {
                    string cityName = cmdArgs[1];
                    int gold = int.Parse(cmdArgs[2]);

                    if (cityList.ContainsKey(cityName))
                    {
                        if (gold < 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                            continue;
                        }
                        cityList[cityName].Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {cityName} now has {cityList[cityName].Gold} gold.");
                    }
                }
            }

            if (cityList.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {cityList.Count} wealthy settlements to go to:");
                foreach (var item in cityList)
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value.Population} citizens, Gold: {item.Value.Gold} kg");
                }
            }
        }
    }
}
