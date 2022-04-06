using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double diplayPrice = double.Parse(Console.ReadLine());

            int countHeadset = 0;
            int countMouse = 0;
            int countKeyboard = 0;
            int countDisplay = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    countHeadset++;
                }
                if (i % 3 == 0)
                {
                    countMouse++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    countKeyboard++;
                    if (countKeyboard % 2 == 0)
                    {
                        countDisplay++;
                    }
                }
            }

            double trashedHeadset = countHeadset * headsetPrice;
            double trashedMouse = countMouse * mousePrice;
            double trashedKeyboard = countKeyboard * keyboardPrice;
            double trashedDisplay = countDisplay * diplayPrice;
            double totalExpenses = trashedHeadset + trashedMouse + trashedKeyboard + trashedDisplay;

            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
        }
    }
}

