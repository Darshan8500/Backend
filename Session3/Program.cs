using System;
using System.Linq; // For array operations

namespace SmartCityBilling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Smart City Electricity Billing System ===\n");

            // ---------------------------
            // 1. User Input + Variables
            // ---------------------------
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();

            Console.Write("Enter number of months to calculate: ");
            int months = Convert.ToInt32(Console.ReadLine());

            double[] unitsUsed = new double[months]; // array to store units

            // ---------------------------
            // 2. Loops + Math
            // ---------------------------
            for (int i = 0; i < months; i++)
            {
                Console.Write($"Enter units consumed in month {i + 1}: ");
                unitsUsed[i] = Convert.ToDouble(Console.ReadLine());
            }

            // ---------------------------
            // 3. Processing: If-Else, Math, Strings
            // ---------------------------
            double[] billAmounts = new double[months];
            const double ratePerUnit = 7.5;

            for (int i = 0; i < months; i++)
            {
                double units = unitsUsed[i];
                double bill = units * ratePerUnit;

                // Conditional logic
                if (units > 300)
                    bill *= 0.9; // 10% discount
                else if (units < 100)
                    bill += 50; // Minimum maintenance charge

                billAmounts[i] = Math.Round(bill, 2);
            }

            // ---------------------------
            // 4. Display using foreach, string interpolation
            // ---------------------------
            Console.WriteLine($"\nElectricity Report for {name.ToUpper()}:\n");

            int monthIndex = 1;
            foreach (var bill in billAmounts)
            {
                Console.WriteLine($"Month {monthIndex++}: ₹{bill}");
            }

            // ---------------------------
            // 5. Calculations using LINQ
            // ---------------------------
            double total = billAmounts.Sum();
            double avg = billAmounts.Average();
            double max = billAmounts.Max();
            double min = billAmounts.Min();

            Console.WriteLine($"\nTotal Bill: ₹{total}");
            Console.WriteLine($"Average Monthly Bill: ₹{avg}");
            Console.WriteLine($"Highest Bill: ₹{max}");
            Console.WriteLine($"Lowest Bill: ₹{min}");

            // ---------------------------
            // 6. Switch-case for rating
            // ---------------------------
            Console.Write("\nEnter overall satisfaction rating (1-5): ");
            int rating = Convert.ToInt32(Console.ReadLine());

            switch (rating)
            {
                case 5:
                    Console.WriteLine(" Excellent Service!");
                    break;
                case 4:
                    Console.WriteLine(" Very Good");
                    break;
                case 3:
                    Console.WriteLine(" Good");
                    break;
                case 2:
                    Console.WriteLine(" Needs Improvement");
                    break;
                case 1:
                    Console.WriteLine(" Poor Experience");
                    break;
                default:
                    Console.WriteLine("Invalid rating.");
                    break;
            }

            // ---------------------------
            // 7. 2D Array: Tariff Table Example
            // ---------------------------
            Console.WriteLine("\n--- Tariff Slabs Table ---");
            string[,] tariffs = {
                { "Slab", "Rate (₹/unit)" },
                { "0 - 100", "5.00" },
                { "101 - 300", "7.50" },
                { "301+", "9.00 (10% discount on total)" }
            };

            for (int row = 0; row < tariffs.GetLength(0); row++)
            {
                for (int col = 0; col < tariffs.GetLength(1); col++)
                {
                    Console.Write(tariffs[row, col].PadRight(20));
                }
                Console.WriteLine();
            }

            // ---------------------------
            // 8. Boolean Example
            // ---------------------------
            Console.Write("\nAre you enrolled in paperless billing (true/false)? ");
            bool isPaperless = Convert.ToBoolean(Console.ReadLine());
            //ternary operator
            Console.WriteLine(isPaperless
                ? " You're helping save trees "
                : " Consider switching to paperless billing!");

            Console.WriteLine("\nThank you for using Smart City Billing!");
        }
    }
}

