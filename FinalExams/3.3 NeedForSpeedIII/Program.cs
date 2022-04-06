using System;
using System.Collections.Generic;

namespace _3._3_NeedForSpeedIII
{
    class Car
    {
        public Car(int mileage, int fuel)
        {
            this.Mileage = mileage;
            this.Fuel = fuel;
        }
        public int Mileage { get; set; }

        public int Fuel { get; set; }

        public bool IsTimeForSaling()
        {
            return (this.Mileage >= 100000 ? true : false);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                var carArgs = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string carName = carArgs[0];
                int mileage = int.Parse((carArgs[1]));
                int fuel = int.Parse((carArgs[2]));

                Car car = new Car(mileage, fuel);

                cars.Add(carName, car);
            }

            string command;

            while ((command = Console.ReadLine()) != "Stop")
            {
                var cmdArgs = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                if (cmdType == "Drive")
                {
                    string carName = cmdArgs[1];
                    int distance = int.Parse(cmdArgs[2]);
                    int fuel = int.Parse(cmdArgs[3]);

                    if (cars.ContainsKey(carName))
                    {
                        if (cars[carName].Fuel < fuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            if (!cars[carName].IsTimeForSaling())
                            {
                                cars[carName].Fuel -= fuel;
                                cars[carName].Mileage += distance;
                                Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                            }
                            if (cars[carName].IsTimeForSaling())
                            {
                                cars.Remove(carName);
                                Console.WriteLine($"Time to sell the {carName}!");
                            }
                        }
                    }
                }
                else if (cmdType == "Refuel")
                {
                    string carName = cmdArgs[1];
                    int fuel = int.Parse(cmdArgs[2]);

                    int currFuel = 0;

                    if (cars.ContainsKey(carName))
                    {
                        if (cars[carName].Fuel + fuel > 75)
                        {
                            currFuel = 75 - cars[carName].Fuel;
                            cars[carName].Fuel += currFuel;
                        }
                        else
                        {
                            currFuel = fuel;
                            cars[carName].Fuel += currFuel;
                        }
                        Console.WriteLine($"{carName} refueled with {currFuel} liters");
                    }
                }
                else if (cmdType == "Revert")
                {
                    string carName = cmdArgs[1];
                    int kilometers = int.Parse(cmdArgs[2]);

                    if (cars.ContainsKey(carName))
                    {
                        if (cars[carName].Mileage - kilometers < 10000)
                        {
                            cars[carName].Mileage = 10000;
                        }
                       else
                        {
                            cars[carName].Mileage -= kilometers;
                            Console.WriteLine($"{carName} mileage decreased by {kilometers} kilometers");
                        }
                    }
                }
            }

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value.Mileage} kms, Fuel in the tank: {item.Value.Fuel} lt.");
            }
        }
    }
}
