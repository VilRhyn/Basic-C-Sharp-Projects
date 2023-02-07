using System;

namespace Branching_Sub_Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight.");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 51)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else if(packageWeight < 51)
            {

                Console.WriteLine("Please enter the package width");
                int packageWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package height");
                int packageHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length");
                int packageLength = Convert.ToInt32(Console.ReadLine());


                int packageCost = (packageWidth * packageHeight * packageLength) * packageWeight;

                Console.WriteLine("Your estimated total for shipping this package is $" + packageCost / 100 + " Thank you!"); 
            }

            Console.ReadLine();

        }
    }
}
