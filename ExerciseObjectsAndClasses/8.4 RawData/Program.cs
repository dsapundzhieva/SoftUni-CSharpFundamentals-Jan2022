using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._4_RawData
{
    class Car
    {

        public Car(string model, Engine engine, Cargo cargo)
        {
            this.CarModel = model;
            this.Engine = engine;
            this.Cargo = cargo;
        }
        public string CarModel { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

    }

    class Engine
    {
        public int EngineSpeed { get; set; }

        public int EnginePower { get; set; }
    }
    class Cargo
    {
        public int CargoWeight { get; set; }

        public string CargoType { get; set; }
    }
     class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carParams = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string carModel = carParams[0];

                Engine engine = new Engine();
                engine.EngineSpeed = int.Parse(carParams[1]);
                engine.EnginePower = int.Parse(carParams[2]);

                Cargo cargo = new Cargo();
                cargo.CargoWeight = int.Parse(carParams[3]);
                cargo.CargoType = carParams[4];

                Car car = new Car(carModel, engine, cargo);
                cars.Add(car);
            }

            string finalCommand = Console.ReadLine();

            if (finalCommand == "fragile")
            {
                List<Car> fragileCars = cars.Where(car => car.Cargo.CargoType == "fragile" && car.Cargo.CargoWeight < 1000).ToList();

                foreach (Car fragileCar in fragileCars)
                {
                    Console.WriteLine(fragileCar.CarModel);
                }
            }

            else if (finalCommand == "flamable")
            {
                List<Car> flamableCars = cars.Where(car => car.Cargo.CargoType == "flamable" && car.Engine.EnginePower > 250).ToList();
                foreach (Car flamableCar in flamableCars)
                {
                    Console.WriteLine(flamableCar.CarModel);
                }
            }
        }
    }
}
