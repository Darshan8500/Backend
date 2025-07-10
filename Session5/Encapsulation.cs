using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5
{
    class Product
    {
        private string name= string.Empty;
        public string Name
        {
            get => name;
            set => name = value;
        }

        public double Price { get; set; }
    }

    public class Encapsulation
    {
        public static void Run()
        {
            Console.WriteLine("1. Encapsulation:");
            var p = new Product { Name = "Laptop", Price = 55000 };
            Console.WriteLine($"Product: {p.Name}, Price: ₹{p.Price}\n");
        }
    }
}
