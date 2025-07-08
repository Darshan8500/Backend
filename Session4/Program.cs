using Session4;
using System;

namespace Session4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SmartCity Console Application ===\n");

            // Creating multiple objects
            Citizen citizen1 = new Citizen("Darshan", 23, "Dharwad");
            Citizen citizen2 = new Citizen("Tweety", 22); // Default city used

            // citizen info
            Console.WriteLine(citizen1.GetDetails());
            Console.WriteLine(citizen2.GetDetails());

            Console.WriteLine();

            // Using Utility class methods
            Utility util = new Utility();

            Console.WriteLine(util.Greet("Darshan"));
            Console.WriteLine(util.GetCityMessage());  // Default parameter
            Console.WriteLine(util.GetCityMessage("Mumbai"));  // Passed argument

            Console.WriteLine("Integer Add: " + util.Add(10, 20));         // Method overloading
            Console.WriteLine("Double Add: " + util.Add(5.5, 6.5));       // Overloaded method

            Console.WriteLine("\n=== End of Program ===");
        }
    }
}
