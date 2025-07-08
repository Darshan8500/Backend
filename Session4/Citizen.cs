using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Session4
{
    public class Citizen
    {
        public string Name;
        public int Age;
        private string City;  // Access modifier: private

        // Constructor
        public Citizen(string name, int age, string city = "Gadag")
        {
            Name = name;
            Age = age;
            City = city;
        }

        // Method to return full details
        public string GetDetails()
        {
            return $"Name: {Name}, Age: {Age}, City: {City}";
        }
    }
}

