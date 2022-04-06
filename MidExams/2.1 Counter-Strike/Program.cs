using System;

namespace _2._1_Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());

            int winConter = 0;
            string command;
            bool hasEnoughMoney = true;

            while ((command = Console.ReadLine()) != "End of battle")
            {
                int distanceToEnemy = int.Parse(command);

                if (initialEnergy >= distanceToEnemy)
                {
                    initialEnergy -= distanceToEnemy;
                    winConter++;

                    if (winConter % 3 == 0)
                    {
                        initialEnergy += winConter;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {winConter} won battles and {initialEnergy} energy");
                    hasEnoughMoney = false;
                    break;
                }
            }
            if (hasEnoughMoney)
            {
                Console.WriteLine($"Won battles: {winConter}. Energy left: {initialEnergy}");
            }
        }
    }
}
