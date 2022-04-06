using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Tuple<double, int>> orders = new Dictionary<string, Tuple<double, int>>();

            string command;

            while ((command = Console.ReadLine()) != "buy")
            {
                var products = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string productName = products[0];
                double productPrice = double.Parse(products[1]);
                int productQty = int.Parse(products[2]);

                if (!orders.ContainsKey(productName))
                {
                    orders[productName] = new Tuple<double, int>(productPrice, productQty);
                }
                else
                {
                    orders[productName] = new Tuple<double, int>(productPrice, productQty + orders[productName].Item2);
                }
            }

            foreach (var item in orders)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Item1*item.Value.Item2:F2}");
            }



            //Dictionary<string, double[]> orders = new Dictionary<string, double[]>();

            //string command;

            //while ((command = Console.ReadLine()) != "buy")
            //{
            //    var products = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            //    string productName = products[0];

            //    double[] productPriceQty = { double.Parse(products[1]), double.Parse(products[2]) };


            //    if (!orders.ContainsKey(productName))
            //    {
            //        orders[productName] = productPriceQty;
            //    }
            //    else
            //    {
            //        orders[productName][0] = productPriceQty[0];
            //        orders[productName][1] += productPriceQty[1];
            //    }
            //}

            //foreach (var item in orders)
            //{
            //    Console.WriteLine($"{item.Key} -> {item.Value[0] * item.Value[1]:F2}");
            //}
        }
    }
}
