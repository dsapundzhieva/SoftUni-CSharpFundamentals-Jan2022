using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            short numberOfLines = short.Parse(Console.ReadLine());
            string previousModel = string.Empty;
            double prevoiusVolume = 0.00;
            string biggestKeg = string.Empty;

            for (int i = 0; i < numberOfLines; i++)
            {
                string currentModel = Console.ReadLine();
                double radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > prevoiusVolume)
                {
                    prevoiusVolume = volume;
                    previousModel = currentModel;
                    biggestKeg = currentModel;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
