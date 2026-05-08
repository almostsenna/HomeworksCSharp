using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworksCSharp.Overload
{
    
using System;

public class Product
    {
        private int quantity;
        private decimal price;

        public string Name { get; set; }

        public int Quantity
        {
            get => quantity;
            set
            {
                if (value < 0)
                  
                throw new ArgumentException("Кількість не може бути від'ємною.");
                quantity = value;
            }
        }

        public decimal Price
        {
            get => price;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Ціна не може бути від'ємною.");
                price = value;
            }
        }

        public Product(string name, int quantity, decimal price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }
        public static Product operator +(Product p, int amount)
        {
            p.Quantity += amount;
            return p;
        }

        public static Product operator -(Product p, int amount)
        {
            p.Quantity -= amount;
            return p;
        }

        public static bool operator ==(Product p1, Product p2)
        {
            return p1.Price == p2.Price;
        }

        public static bool operator !=(Product p1, Product p2)
        {
            return p1.Price != p2.Price;
        }

        public static bool operator >(Product p1, Product p2)
        {
            return p1.Quantity > p2.Quantity;
        }

        public static bool operator <(Product p1, Product p2)
        {
            return p1.Quantity < p2.Quantity;
        }

        public override bool Equals(object obj)
        {
            if (obj is Product other)
                return this.Price == other.Price && this.Quantity == other.Quantity && this.Name == other.Name;
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Quantity, Price);
        }

        public override string ToString()
        {
            return $"{Name}: {Quantity} шт., {Price} грн.";
        }
    }

}

