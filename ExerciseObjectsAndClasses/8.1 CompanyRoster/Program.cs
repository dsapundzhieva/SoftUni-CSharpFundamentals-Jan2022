using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._1_CompanyRoster
{
    class Employee
    {
        public Employee(string name, decimal salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }
        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string Department { get; set; }
    }

    class Result
    {
        public string Department { get; set; }

        public List<Employee> Employees { get; set; }

        public decimal AverageSalary { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Employee> emplyees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                string[] emplyeeParams = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = emplyeeParams[0];
                decimal salary = decimal.Parse(emplyeeParams[1]);
                string department = emplyeeParams[2];

                Employee emplyee = new Employee(name, salary, department);

                emplyees.Add(emplyee);

            }

            List<Result> groupedList = emplyees.GroupBy(e => e.Department)
                .Select(x => new Result
                {
                    Department = x.Key,
                    Employees = x.ToList(),
                    AverageSalary = x.Average(a => a.Salary)
                })
                .OrderByDescending(avSalary => avSalary.AverageSalary)
                .Take(1)
                .ToList();

            foreach (Result department in groupedList)
            {
                Console.WriteLine($"Highest Average Salary: {department.Department}");

                foreach (var item in department.Employees.OrderByDescending(x => x.Salary))
                {
                    Console.WriteLine($"{item.Name} {item.Salary:F2}");
                }
            }
        }
    }
}
