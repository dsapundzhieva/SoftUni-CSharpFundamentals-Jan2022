using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_OrderByAge
{

    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }
        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }
    }
     class Program
    {
        static void Main(string[] args)
        {

            string command;
            List<Person> persons = new List<Person>();

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdParams = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = cmdParams[0];
                string id = cmdParams[1];
                int age  = int.Parse(cmdParams[2]);

                Person personWithTheSameId = persons.FirstOrDefault(personId => personId.Id == id);

                if (personWithTheSameId != null)
                {
                    personWithTheSameId.Name = name;
                    personWithTheSameId.Age = age;
                    continue;
                }

                Person person = new Person(name, id, age);
                persons.Add(person);
            }

            foreach (Person person in persons.OrderBy(p => p.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
}
