using System;
using System.Collections.Generic;

namespace _06_Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseDict = new Dictionary<string, List<string>>();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                var courseInfo = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string courseName = courseInfo[0];
                string studentName = courseInfo[1];

                if (!courseDict.ContainsKey(courseName))
                {
                    courseDict[courseName] = new List<string>();
                }

                courseDict[courseName].Add(studentName);

            }

            foreach (var item in courseDict)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                Console.WriteLine($"-- {string.Join("\n-- ", item.Value)}");
            }
        }
    }
}
