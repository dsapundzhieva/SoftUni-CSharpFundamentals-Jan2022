using System;

namespace _01_BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfStudents = int.Parse(Console.ReadLine());

            double totalNumberOfLectures = int.Parse(Console.ReadLine());

            double additionalBonus = int.Parse(Console.ReadLine());

            double totalBonus = 0;
            double attendance = 0;

            for (int i = 0; i < numberOfStudents; i++)
            {
                double studentAttendance = int.Parse(Console.ReadLine());
                double bonusForCurrentStudents = (studentAttendance / totalNumberOfLectures) * (5 + additionalBonus);

                if (totalBonus < bonusForCurrentStudents)
                {
                    totalBonus = bonusForCurrentStudents;
                    attendance = studentAttendance;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(totalBonus)}.\nThe student has attended {attendance} lectures.");

        }
    }
}
