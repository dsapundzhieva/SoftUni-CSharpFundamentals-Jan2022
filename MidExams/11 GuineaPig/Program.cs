using System;

namespace _11_GuineaPig
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantityOfFoodGr = double.Parse(Console.ReadLine()) * 1000;
            double quantityOfHayGr = double.Parse(Console.ReadLine()) * 1000;
            double quantityOfCoverGr = double.Parse(Console.ReadLine()) * 1000;
            double guineasPigWeightGr = double.Parse(Console.ReadLine()) * 1000;
            double foodPerDay = 300;
            double calculateCoverPerThreeDays = guineasPigWeightGr / 3;


            for (int i = 1; i <= 30; i++)
            {
                quantityOfFoodGr -= foodPerDay;
              
                if (i % 2 == 0)
                {
                    double calculateHayPerTwoDays = quantityOfFoodGr * 0.05;
                    quantityOfHayGr -= calculateHayPerTwoDays;
                }
                if (i % 3 == 0)
                {
                    quantityOfCoverGr -= calculateCoverPerThreeDays;
                }
            }

            if (quantityOfFoodGr > 0 && quantityOfHayGr > 0 && quantityOfCoverGr > 0)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {quantityOfFoodGr/1000:f2}, Hay: {quantityOfHayGr/1000:f2}, Cover: {quantityOfCoverGr/1000:f2}.");
            }
            else
            {
                Console.WriteLine("Merry must go to the pet store!");
            }

        }
    }
}
