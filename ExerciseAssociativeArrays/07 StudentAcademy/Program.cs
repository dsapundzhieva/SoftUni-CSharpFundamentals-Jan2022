using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, double> studentsInfoWithAverageGrade = new Dictionary<string, double>();

            Dictionary<string, List<double>> studentsInfo = new Dictionary<string, List<double>>();


            string[] studentsArray = new string[n * 2];

            for (int i = 0; i < n * 2; i++)
            {
                studentsArray[i] = Console.ReadLine();
            }

            for (int i = 0; i < studentsArray.Length; i += 2)
            {
                string name = studentsArray[i];
                double grade = double.Parse(studentsArray[i + 1]);

                if (!studentsInfo.ContainsKey(name))
                {
                    studentsInfo[name] = new List<double>() { grade };
                }
                else
                {
                    studentsInfo[name].Add(grade);
                }
            }

            //var avarageList = studentsInfo.GroupBy(key => key.Key, value => value.Value.Average()).Where(value => value.Average() >= 4.50).ToList();

            //var avarageList1 = studentsInfo.Where(value => value.Value.Average() >= 4.50).ToDictionary(key => key.Key);

            //var avarageList2 = studentsInfo.Where(value => value.Value.Average() >= 4.50).ToList();


            foreach (var item in studentsInfo)
            {
                if (!studentsInfoWithAverageGrade.ContainsKey(item.Key))
                {
                    studentsInfoWithAverageGrade[item.Key] = item.Value.Average();
                }
            }

            foreach (var item in studentsInfoWithAverageGrade.Where(x => x.Value >= 4.50))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
