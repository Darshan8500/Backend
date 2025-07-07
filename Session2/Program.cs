
    class Program
    {
        // Constant for city name
        const string CityName = "Smartville";

        static void Main(string[] args)
        {
            // Displaying a title
            Console.WriteLine("=== Welcome to the " + CityName + " Citizen Portal ===\n");

            // Declare variables of different types
            string citizenName;       // string type
            int age;                  // integer type
            double monthlyBill;       // double type
            bool isResident;          // boolean type

            // Input from user
            Console.Write("Enter your full name: ");
            citizenName = Console.ReadLine();

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());  // Explicit casting (string to int)

            Console.Write("Are you a resident? (true/false): ");
            isResident = Convert.ToBoolean(Console.ReadLine());  // type casting (string to bool)

            Console.Write("Enter your monthly utility bill (approx): ");
            monthlyBill = Convert.ToDouble(Console.ReadLine());  // type casting

            // Implicit type casting example
            int roundedBill = (int)monthlyBill;  // Explicit cast from double to int

            // Output data
            Console.WriteLine("\n--- Citizen Summary ---");
            Console.WriteLine("Name: " + citizenName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Resident: " + isResident);
            Console.WriteLine("Approx. Monthly Bill: ₹" + monthlyBill);
            Console.WriteLine("Rounded Monthly Bill: ₹" + roundedBill);

            // Comment examples
            // This is a single-line comment

            /*
             * This is a multi-line comment
             * explaining that identifiers like `age`, `monthlyBill`, and `isResident`
             * follow naming conventions and proper data types.
             */

            // End message
            Console.WriteLine("\nThank you for using the " + CityName + " portal!");
        }
    }

