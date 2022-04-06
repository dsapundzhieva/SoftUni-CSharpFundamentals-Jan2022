using System;
using System.Collections.Generic;
using System.Linq;

namespace _16_SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courseSchedule = Console.ReadLine()
                .Split(",")
                .Select(s => s.Trim())
                .Where(s => !string.IsNullOrEmpty(s))
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "course start")
            {
                var cmdArgs = command.Split(":", StringSplitOptions.RemoveEmptyEntries);

                var cmdType = cmdArgs[0];

                if (cmdType == "Add")
                {
                    string lessonTitle = cmdArgs[1];

                    courseSchedule = AddLesson(courseSchedule, lessonTitle);
                }
                else if (cmdType == "Insert")
                {
                    string lessonTitle = cmdArgs[1];
                    int index = int.Parse(cmdArgs[2]);

                    courseSchedule = InsertLesson(courseSchedule, lessonTitle, index);
                }
                else if (cmdType == "Remove")
                {
                    string lessonTitle = cmdArgs[1];

                    courseSchedule = RemoveLesson(courseSchedule, lessonTitle);
                }
                else if (cmdType == "Swap")
                {
                    string lessonTitleOne = cmdArgs[1];
                    string lessonTitleTwo = cmdArgs[2];

                    courseSchedule = SwapLessons(courseSchedule, lessonTitleOne, lessonTitleTwo);

                }
                else if (cmdType == "Exercise")
                {
                    string lessonTitle = cmdArgs[1];

                    courseSchedule = ExerciseLessons(courseSchedule, lessonTitle);
                }
            }

            PrintCourseSchedule(courseSchedule);
        }

        static void PrintCourseSchedule(List<string> courseSchedule)
        {
            for (int i = 0; i < courseSchedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{courseSchedule[i]}");
            }
        }

        static List<string> ExerciseLessons(List<string> courseSchedule, string lessonTitle)
        {
            int indexOfLesson = courseSchedule.IndexOf(lessonTitle);

            if (courseSchedule.Contains(lessonTitle) && !courseSchedule.Contains($"{lessonTitle}-Exercise"))
            {
                courseSchedule.Insert(indexOfLesson+1, $"{lessonTitle}-Exercise");
            }
            else if (!courseSchedule.Contains(lessonTitle))
            {
                courseSchedule.Add(lessonTitle);
                courseSchedule.Add($"{lessonTitle}-Exercise");
            }
            return courseSchedule;

        }

        static List<string> SwapLessons(List<string> courseSchedule, string lessonTitleOne, string lessonTitleTwo)
        {
            bool isLessonOneContainsExercise = courseSchedule.Contains($"{lessonTitleOne}-Exercise");
            bool isLessonTwoContainsExercise = courseSchedule.Contains($"{lessonTitleTwo}-Exercise");

            int index1 = courseSchedule.IndexOf(lessonTitleOne);
            int index2 = courseSchedule.IndexOf(lessonTitleTwo);

            if (courseSchedule.Contains(lessonTitleOne) && courseSchedule.Contains(lessonTitleTwo))
            {
                string tempLessonTitleOne = courseSchedule.ElementAt(index1);
                courseSchedule[index1] = courseSchedule[index2];
                courseSchedule[index2] = tempLessonTitleOne;
            }
            if (isLessonOneContainsExercise)
            {
                index1 = courseSchedule.IndexOf(lessonTitleOne);
                courseSchedule.Remove($"{lessonTitleOne}-Exercise");
                courseSchedule.Insert(index1 + 1, $"{lessonTitleOne}-Exercise");
            }
            if (isLessonTwoContainsExercise)
            {
                index2 = courseSchedule.IndexOf(lessonTitleTwo);
                courseSchedule.Remove($"{lessonTitleTwo}-Exercise");
                courseSchedule.Insert(index2 + 1, $"{lessonTitleTwo}-Exercise");
            }

            return courseSchedule;
        }

        static List<string> RemoveLesson(List<string> courseSchedule, string lessonTitle)
        {

            if (courseSchedule.Contains(lessonTitle) && courseSchedule.Contains($"{lessonTitle}-Exercise"))
            {
                courseSchedule.Remove(lessonTitle);
                courseSchedule.Remove($"{lessonTitle}-Exercise");
            }
            else if (courseSchedule.Contains(lessonTitle) && !courseSchedule.Contains($"{lessonTitle}-Exercise"))
            {
                courseSchedule.Remove(lessonTitle);
            }
            return courseSchedule;
        }

        static List<string> InsertLesson(List<string> courseSchedule, string lessonTitle, int index)
        {
            if (index < 0 || index > courseSchedule.Count - 1)
            {
                return courseSchedule;
            }
            else
            {
                if (!courseSchedule.Contains(lessonTitle))
                {
                    courseSchedule.Insert(index, lessonTitle);
                }
                return courseSchedule;
            }
            
        }
        static List<string> AddLesson(List<string> courseSchedule, string lessonTitle)
        {
            if (!courseSchedule.Contains(lessonTitle))
            {
                courseSchedule.Add(lessonTitle);
            }
            return courseSchedule;
        }
    }
}
