using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_StoreBoxes
{
    class Item
    {
        public Item()
        {

        }
        public string ItemName { get; set; }

        public decimal ItemPrice { get; set; }
    }

    class Box
    {
        public Box()
        {
            this.Item = new Item();
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int BoxItemQuantity { get; set; }
        public decimal BoxItemPrice
        {
            get
            {
                return BoxItemQuantity * Item.ItemPrice;
            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                string command = Console.ReadLine();

                List<Box> boxes = new List<Box>();


                while (command != "end")
                {
                    string[] commandParams = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    Box box = new Box();
                    box.SerialNumber = commandParams[0];
                    box.Item.ItemName = commandParams[1];
                    box.Item.ItemPrice = decimal.Parse(commandParams[3]);
                    box.BoxItemQuantity = int.Parse(commandParams[2]);


                    boxes.Add(box);

                    command = Console.ReadLine();
                }

                List<Box> filteredBoxList = boxes
                    .OrderByDescending(box => box.BoxItemPrice)
                    .ToList();

                foreach (Box box in filteredBoxList)
                {
                    Console.WriteLine($"{box.SerialNumber}");
                    Console.WriteLine($"-- {box.Item.ItemName} - ${box.Item.ItemPrice:F2}: {box.BoxItemQuantity}");
                    Console.WriteLine($"-- ${box.BoxItemPrice:F2}");
                }
            }
        }
    }
}
