using System;
using System.Collections.Generic;
using System.Text;

namespace HelloVisualStudio.ConsoleApp
{
    public class Product
    {
        public string id { get; }

        public string Name { get; set; }

        private double _price;

        public double Price
        {
            get { return _price; }
            set { 
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Price must be positive and not zero");
                }
                _price = value; }
        }

        private int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Quantity cannot be negative.");
                }
            }
        }
        public Product(string id, string name, double price, int quantity)
        {
            Name = name;
            Quantity = quantity;
            this.id = id;
            Price = price;
        }

        public void AddInventory(int count)
        {
            Quantity += count;
        }
    }
}
