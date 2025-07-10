using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Session5
{
    class Person
    {
        public string Name { get; set; } = string.Empty;
        public void Greet() => Console.WriteLine("Hello, I am a person.");
    }

    class Employee : Person
    {
        public string Company { get; set; } = string.Empty;
        public void Work() => Console.WriteLine($"{Name} works at {Company}.");
    }

    public class Inheritance
    {
        public static void Run()
        {
            Console.WriteLine("2. Inheritance:");
            var emp = new Employee { Name = "Darshan", Company = "VHP" };
            emp.Greet();
            emp.Work();
            Console.WriteLine();
        }
    }
}
