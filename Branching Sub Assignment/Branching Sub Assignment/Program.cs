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
            
            //shuts down the program if weight is too heavy
            if (packageWeight >= 50) 
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }    

           //user input variables 
            Console.WriteLine("Please enter the package width");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            //creating packageDimension variable 
            int packageDimensions = packageWidth + packageHeight + packageLength;
          
            if (packageDimensions < 50)
            {
                //creating a math equation for timesing the width, heigh, and length together, then timesing it by the weight of the package 
                int packageCost = (packageWidth * packageHeight * packageLength) * packageWeight;

                //Shows user how much estimated cost will be 
                Console.WriteLine("Your estimated total for shipping this package is $" + packageCost / 100 + " Thank you!");
            }

            //if dimensions greater than or equal to 50 than write : 
            else if (packageDimensions >= 50) ;
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
                    Console.ReadLine();
        }
    }
}
