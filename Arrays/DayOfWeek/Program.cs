using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWeek = int.Parse(Console.ReadLine());
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
           /* for (int i = 0; i < daysOfWeek.Length; i++)
            {
                if (numberOfWeek >= 1 && numberOfWeek <= 7)
                {
                    if (numberOfWeek == i + 1)
                    {
                        Console.WriteLine(daysOfWeek[i]);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid day!");
                    break;
                }
            }*/

            if (numberOfWeek >= 1 && numberOfWeek <= 7)
            {
                Console.WriteLine(daysOfWeek[numberOfWeek - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");

            }
        }
    }
}
