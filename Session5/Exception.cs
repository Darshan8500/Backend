using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5
{
    public class Exception
    {
        public static void Run()
        {
            Console.WriteLine("8. Exception Handling:");
            try
            {
                int a = 5, b = 0;
                int result = a / b;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Caught exception: " + ex.Message);
            }
            Console.WriteLine();
        }
    }
}

