using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._3_Need_for_Speed_III
{
    class Car
    {
        public Car(string car, int mileage, int fuel)
        {
            this.CarName = car;
            this.Mileage = mileage;
            this.Fuel = fuel;
        }
        public string CarName { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }

        public bool IsTimeToSellTheCar()
        {
            if (this.Mileage >= 100000)
            {
                Console.WriteLine($"Time to sell the {this.CarName}!");
                return true;
            }
            return false;
        }

        public bool DoesTheKilometersOfTheCarLessThan10K()
        {
            if (this.Mileage < 10000)
            {
                this.Mileage = 10000;
                return true;
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> carList = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var cmdArgs = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArgs[0];
                int mileage = int.Parse(cmdArgs[1]);
                int fuel = int.Parse(cmdArgs[2]);
                Car newCar = new Car(name, mileage, fuel);
                carList.Add(newCar);
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

                    DriveGivenDistance(carList, carName, distance, fuel);
                }
                else if (cmdType == "Refuel")
                {
                    string carName = cmdArgs[1];
                    int fuel = int.Parse(cmdArgs[2]);

                    RefillTheTankOfCar(carList, carName, fuel);
                }
                else if (cmdType == "Revert")
                {
                    string carName = cmdArgs[1];
                    int kilometers = int.Parse(cmdArgs[2]);

                    RevertCarKilometers(carList, carName, kilometers);
                }
            }

            PrintOut(carList);
        }

        static void PrintOut(List<Car> carList)
        {
            foreach (var car in carList)
            {
                Console.WriteLine($"{car.CarName} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }
        static void RevertCarKilometers(List<Car> carList, string carName, int kilometers)
        {
            var matchCar = carList.Where(c => c.CarName == carName);

            if (matchCar.Any())
            {
                Car car = carList.Find(c => c.CarName == carName);
                car.Mileage -= kilometers;
                if (!car.DoesTheKilometersOfTheCarLessThan10K())
                {
                    Console.WriteLine($"{carName} mileage decreased by {kilometers} kilometers");
                }
            }
        }

        static void RefillTheTankOfCar(List<Car> carList, string carName, int fuel)
        {
            var matchCar = carList.Where(c => c.CarName == carName);

            if (matchCar.Any())
            {
                Car car = carList.Find(c => c.CarName == carName);

                if (car.Fuel + fuel > 75)
                {
                    Console.WriteLine($"{carName} refueled with {75 - car.Fuel} liters");
                    car.Fuel = 75;
                }
                else
                {
                    car.Fuel += fuel;
                    Console.WriteLine($"{carName} refueled with {fuel} liters");
                }
            }
        }

        static void DriveGivenDistance(List<Car> carList, string carName, int distance, int fuel)
        {
            var carMatch = carList.Where(c => c.CarName == carName);

            if (carMatch.Any())
            {
                Car car = carList.Find(c => c.CarName == carName);
                if (car.Fuel < fuel)
                {
                    Console.WriteLine("Not enough fuel to make that ride");
                }
                else
                {
                    car.Mileage += distance;
                    car.Fuel -= fuel;
                    Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                }
                if (car.IsTimeToSellTheCar())
                {
                    carList.Remove(car);
                }
            }
        }
    }
}
