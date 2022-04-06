using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Students
{
    class Student
    {
        public Student(string firstName, string lastName, decimal grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade}";
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] studentParams = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = studentParams[0];
                string lastName = studentParams[1];
                decimal grade = decimal.Parse(studentParams[2]);

                Student student = new Student(firstName, lastName, grade);

                students.Add(student);
            }

            students = students.OrderByDescending(student => student.Grade).ToList();

            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
