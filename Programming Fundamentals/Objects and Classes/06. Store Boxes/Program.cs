using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string command;

            double sum = 0;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split();

                Box box = new Box
                {
                    SerialNumber = tokens[0],
                    Item = new Item(tokens[1], decimal.Parse(tokens[3])),
                    ItemQuantity = int.Parse(tokens[2])
                };

                boxes.Add(box);
            }

            var orderboxes = boxes.OrderByDescending(b => b.Price).ToList();

            foreach (var box in orderboxes)
            {
                Console.Write($"{box.SerialNumber}");
                Console.WriteLine();
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.Price:f2}");
            }
        }

        public class Item
        {
            public Item(string name, decimal price)
            {
                Name = name;
                Price = price;
            }

            public string Name { get; set; }
            public decimal Price { get; set; }
        }
        public class Box
        {
            public string SerialNumber { get; set; }
            public Item Item { get; set; }
            public int ItemQuantity { get; set; }
            public decimal Price 
            {
                get
                {
                    return this.ItemQuantity * this.Item.Price;
                }
            }
        }
    }
}
