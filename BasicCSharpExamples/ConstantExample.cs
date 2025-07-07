using System;

namespace BasicCSharpExamples
{
    class ConstantExample
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159;
            double radius = 5.0;
            double area = PI * radius * radius;

            Console.WriteLine($"Area of Circle with radius {radius} is {area}");
        }
    }
}