using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Students
{
    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
     class Program
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (command != "end")
            {
                string[] studentParams = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = studentParams[0];
                string lastName = studentParams[1];
                int age = int.Parse(studentParams[2]);
                string homeTown = studentParams[3];

                if (DoesTheGivenStudentExists(students, firstName, lastName))
                {
                    Student existingStudent = students.FirstOrDefault(student => student.FirstName == firstName && student.LastName == lastName);

                    existingStudent.Age = age;
                    existingStudent.HomeTown = homeTown;
                }
                else
                {
                    Student student = new Student(firstName, lastName, age, homeTown);
                    students.Add(student);
                }

                command = Console.ReadLine();
            }

            string finalCityName = Console.ReadLine();

            List<Student> filteredStudents = students.FindAll(student => student.HomeTown == finalCityName);

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

       public static bool DoesTheGivenStudentExists(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
