using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._2_OldestFamilyMember
{
    class Family
    {
        public Family()
        {
            this.People = new List<Person>();
        }
        public List<Person> People { get; set; }

        public void AddMember(Person member)
        {
            People.Add(member);
        }

        public Person GetOldestMember(Family family)
        {
            Person oldestMember = family.People.OrderByDescending(p => p.Age).FirstOrDefault();
            return oldestMember;
        }
    }

    class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
        
            for (int i = 0; i < n; i++)
            {
                string[] currPerson = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = currPerson[0];
                int age = int.Parse(currPerson[1]);

                Person person = new Person(name, age);
                family.AddMember(person);
            }

            Person oldestPerson = family.GetOldestMember(family);

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
