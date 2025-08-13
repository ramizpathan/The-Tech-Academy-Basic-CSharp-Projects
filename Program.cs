
using System; // For Console input/output

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Step 2: Ask for package weight
            Console.Write("Please enter the package weight: ");
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // Step 3: Check if weight is too heavy
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // End the program
            }

            // Step 4: Ask for package width
            Console.Write("Please enter the package width: ");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            // Step 5: Ask for package height
            Console.Write("Please enter the package height: ");
            decimal height = Convert.ToDecimal(Console.ReadLine());

            // Step 6: Ask for package length
            Console.Write("Please enter the package length: ");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // Step 7: Check if total dimensions exceed limit
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // End the program
            }

            // Step 8: Calculate quote
            decimal quote = (width * height * length * weight) / 100;

            // Step 9: Display quote
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
            Console.WriteLine("Thank you!");
        }
    }
}
