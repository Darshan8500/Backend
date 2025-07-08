using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4
{
    public class Utility
    {
        // Method with parameters and return value
        public string Greet(string name)
        {
            return $"Welcome, {name}!";
        }

        // Method with default parameter
        public string GetCityMessage(string city = "Bengaluru")
        {
            return $"You are living in {city}.";
        }

        // Overloaded method
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}

