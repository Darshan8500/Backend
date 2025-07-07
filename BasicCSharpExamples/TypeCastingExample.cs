using System;

namespace BasicCSharpExamples
{
    class TypeCastingExample
    {
        static void Main(string[] args)
        {
            int num = 100;
            double d = num;

            double pi = 3.14159;
            int intPi = (int)pi;

            Console.WriteLine($"Implicit: {d}, Explicit: {intPi}");
        }
    }
}