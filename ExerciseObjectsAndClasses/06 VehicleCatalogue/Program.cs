using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _06_VehicleCatalogue
{
    class Catalogue
    {
        public Catalogue(string typeOfVehicle, string model, string color, int horsePower)
        {
            this.TypeOfVehicle = typeOfVehicle;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }

        public string TypeOfVehicle { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Type: {(this.TypeOfVehicle == "car" ? "Car" : "Truck")}{Environment.NewLine}");
            sb.Append($"Model: {this.Model}{Environment.NewLine}");
            sb.Append($"Color: {this.Color}{Environment.NewLine}");
            sb.Append($"Horsepower: {this.HorsePower}{Environment.NewLine}");

            return sb.ToString().TrimEnd();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string command;
            List<Catalogue> catalogueList = new List<Catalogue>();

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string typeOfVehicle = commandArgs[0];
                string model = commandArgs[1];
                string color = commandArgs[2];
                int horsePower = int.Parse(commandArgs[3]);

                Catalogue catalogue = new Catalogue(typeOfVehicle, model, color, horsePower);
                catalogueList.Add(catalogue);
            }

            string finalCommand;

            while ((finalCommand = Console.ReadLine()) != "Close the Catalogue")
            {
                Catalogue searchedModel = catalogueList.FirstOrDefault(model => model.Model == finalCommand);

                if (searchedModel != null)
                {
                    Console.WriteLine(searchedModel);
                }
            }

            //List<Catalogue> carsList = catalogueList.Where(car => car.TypeOfVehicle == "car").ToList();
            //List<Catalogue> truckList = catalogueList.Where(truck => truck.TypeOfVehicle == "truck").ToList();
            //decimal sum = carsList.Select(car => car.HorsePower).Sum();

            decimal sumCarsHorsepower = catalogueList
                .Where(car => car.TypeOfVehicle == "car")
                .Sum(car => car.HorsePower);

            decimal countOfCars = catalogueList
                .Where(car => car.TypeOfVehicle == "car")
                .Count();

            if (countOfCars > 0)
            {
                decimal averageCarHorsepower = sumCarsHorsepower / countOfCars;
                Console.WriteLine($"Cars have average horsepower of: {averageCarHorsepower:F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:F2}.");
            }

            decimal sumTruckHorsepower = catalogueList
                .Where(truck => truck.TypeOfVehicle == "truck")
                .Sum(catalogue => catalogue.HorsePower);

            decimal countOfTrucks = catalogueList
               .Where(truck => truck.TypeOfVehicle == "truck").Count();
            if (countOfTrucks > 0)
            {
                decimal averageTruckHorsepower = sumTruckHorsepower / countOfTrucks;
                Console.WriteLine($"Trucks have average horsepower of: {averageTruckHorsepower:F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");
            }
        }
    }
}
