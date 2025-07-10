using Session5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5
{
    public class Polymorphism
    {
        public static void Run()
        {
            Console.WriteLine("3. Polymorphism:");
            Person person = new Employee { Name = "Kiran" };
            person.Greet(); // Polymorphic call
            Console.WriteLine();
        }
    }
}
