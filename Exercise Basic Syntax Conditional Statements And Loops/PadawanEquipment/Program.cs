using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentMoney = double.Parse(Console.ReadLine());
            short countOfStudents = short.Parse(Console.ReadLine());
            double priceOfALightsabres = double.Parse(Console.ReadLine());
            double priceOfARobe = double.Parse(Console.ReadLine());
            double priceOfABelt = double.Parse(Console.ReadLine());


            double additionalLightsabres = (countOfStudents + Math.Ceiling(countOfStudents * 0.10)) * priceOfALightsabres;
            double totalPriceRobe = priceOfARobe * countOfStudents;
            double freeBelt = (countOfStudents / 6) * priceOfABelt;
            double totalPriceBelt = priceOfABelt * countOfStudents - freeBelt;

            double totalSumOfTheEquipment = totalPriceBelt + totalPriceRobe + additionalLightsabres;
            double neededMoney = totalSumOfTheEquipment - currentMoney;

            if (currentMoney >= totalSumOfTheEquipment)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSumOfTheEquipment:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {neededMoney:f2}lv more.");
            }
        }
    }
}
