using System;

namespace _3._1_SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int totalStudents = int.Parse(Console.ReadLine());

            int answeredStudentsPerHour = first + second + third;

            int countHours = 0;

            while (totalStudents > 0)
            {
                countHours++;

                totalStudents -= answeredStudentsPerHour;

                if (countHours % 4 == 0)
                {
                    countHours++;
                }
            }

            Console.WriteLine($"Time needed: {countHours}h.");
        }
    }
}
