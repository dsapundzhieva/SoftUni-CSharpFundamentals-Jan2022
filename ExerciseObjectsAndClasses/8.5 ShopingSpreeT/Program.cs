using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._5_ShopingSpreeT
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

        List<Product> Products { get; set; }

        public void AddProduct(Product product)
        {
            if (this.PersonMoney >= product.ProductCost)
            {
                Products.Add(product);
            }
            else
            {
                Console.WriteLine($"{this.PersonName} can't afford {product.ProductName}".);
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

            Console.WriteLine();
        }
    }
}
