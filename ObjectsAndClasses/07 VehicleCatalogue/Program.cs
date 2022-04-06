using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_VehicleCatalogue
{
    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }

    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }

    class Catalogue
    {
        public Catalogue()
        {
            this.Trucks = new List<Truck>();
            this.Cars = new List<Car>();
        }
        public List<Truck> Trucks { get; set; }

        public List<Car> Cars { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Catalogue catalogue = new Catalogue();

            while (command != "end")
            {
                string[] commandParams = command.Split('/',
                    StringSplitOptions.RemoveEmptyEntries);

                string type = commandParams[0];
                string brand = commandParams[1];
                string model = commandParams[2];
                int finalParam = int.Parse(commandParams[3]);

                if (type == "Car")
                {
                    Car car = new Car(brand, model, finalParam);

                    catalogue.Cars.Add(car);
                }
                if (type == "Truck")
                {
                    Truck truck = new Truck(brand, model, finalParam);
                    catalogue.Trucks.Add(truck);
                }

                command = Console.ReadLine();
            }


            if (catalogue.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                List<Car> filteredCars = catalogue.Cars.OrderBy(carBrand => carBrand.Brand).ToList();
                foreach (Car car in filteredCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }


            if (catalogue.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                List<Truck> filteredTrucks = catalogue.Trucks.OrderBy(truckBrand => truckBrand.Brand).ToList();
                foreach (Truck truck in filteredTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
