using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._3_SpeedRacing
{
    class Car
    {
        public Car(string model, decimal fuelAmount, decimal fuelConsumptionFor1Km)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionFor1Km = fuelConsumptionFor1Km;
            this.TraveledDistance = 0.0m;
        }
        public string Model { get; set; }

        public decimal FuelAmount { get; set; }

        public decimal FuelConsumptionFor1Km { get; set; }

        public decimal TraveledDistance { get; set; }

        public bool CanCarMoveTheDistance(Car car, decimal amountOfKm)
        {
            decimal currentFuelAmount = car.FuelAmount;

            decimal fuelConsumption = car.FuelConsumptionFor1Km * amountOfKm;

            if (currentFuelAmount >= fuelConsumption)
            {
                car.FuelAmount -= fuelConsumption;
                car.TraveledDistance += amountOfKm;
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

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carsParams = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = carsParams[0];
                decimal fuelAmount = decimal.Parse(carsParams[1]);
                decimal fuelConsumptionFor1Km = decimal.Parse(carsParams[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionFor1Km);

                cars.Add(car);
            }


            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdParams = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string drive = cmdParams[0];
                string carModel = cmdParams[1];
                decimal amountOfKm = decimal.Parse(cmdParams[2]);

                Car currentCar = cars.FirstOrDefault(car => car.Model == carModel);

                if (!currentCar.CanCarMoveTheDistance(currentCar, amountOfKm))
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TraveledDistance:f0}");
            }
        }
    }
}
