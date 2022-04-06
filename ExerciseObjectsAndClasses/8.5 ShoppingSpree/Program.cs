using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._5_ShoppingSpree
{
    class Person
    {
        public Person(string name, int money)
        {
            this.PersonName = name;
            this.PersonMoney = money;
            this.Products = new List<Product>();
        }
        public string PersonName { get; set; }

        public int PersonMoney { get; set; }

        public List<Product> Products { get; set; }

        public void AddProduct(Product product)
        {
            if (this.PersonMoney >= product.ProductCost)
            {
                Products.Add(product);
                this.PersonMoney -= product.ProductCost;
                Console.WriteLine($"{this.PersonName} bought {product.ProductName}");
            }
            else
            {
                Console.WriteLine($"{this.PersonName} can't afford {product.ProductName}");
            }
        }
    }
    class Product
    {
        public Product(string productName, int productCost)
        {
            this.ProductName = productName;
            this.ProductCost = productCost;
        }
        public string ProductName { get; set; }

        public int ProductCost { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            var peopleInfo = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Split("=", StringSplitOptions.RemoveEmptyEntries));
            var productInfo = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Split("=", StringSplitOptions.RemoveEmptyEntries));

            List<Product> products = new List<Product>();
            foreach (var person in peopleInfo)
            {
                string personName = person[0];
                int personMoney = int.Parse(person[1]);

                Person currPerson = new Person(personName, personMoney);
                people.Add(currPerson);
            }

            foreach (var product in productInfo)
            {
                string productName = product[0];
                int productCost = int.Parse(product[1]);

                Product currProduct = new Product(productName, productCost);
                products.Add(currProduct);
            }

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] commandParams = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string personName = commandParams[0];
                string productName = commandParams[1];

                Person currPerson = people.FirstOrDefault(p => p.PersonName == personName);

                Product currProduct = products.FirstOrDefault(p => p.ProductName == productName);

                currPerson.AddProduct(currProduct);
            }

            foreach (Person finalPerson in people)
            {
                if (finalPerson.Products.Count == 0)
                {
                    Console.WriteLine($"{finalPerson.PersonName} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{finalPerson.PersonName} - {string.Join(", ", finalPerson.Products.Select(p => p.ProductName))}");
                }
            }
        }
    }
}
