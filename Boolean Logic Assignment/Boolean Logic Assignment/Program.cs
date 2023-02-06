using System;

namespace Boolean_Logic_Assignment
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Car Insurance Approvale Questionaire");
            //How old are you ? 
            Console.WriteLine("What is your age?");
            //Converts user input to int data type 
            int Age = Convert.ToInt32(Console.ReadLine());

            //Have you had a DUI
            Console.WriteLine("Have you ever had a DUI? TRUE or FALSE");
            //Converts user input to boolean data type
            bool DUI = Convert.ToBoolean(Console.ReadLine());

            //How many speeding tickets 
            Console.WriteLine("How many speeding tickets have you had?");
            //Converts user input to int data type
            int SpdTkt = Convert.ToInt32(Console.ReadLine());

            //variable result to be true = variable age must be greater than 15
            //                           = variable DUI must be false 
            //                           = variable SpdTkt must be less than or equal to 3
            bool result = (Age > 15 && DUI == false && SpdTkt <= 3);

            //Console Writes Qualified: + either true or false based on the above paramaters
            Console.WriteLine("Qualified:" + result);
            Console.ReadLine();
        }
    }
}
