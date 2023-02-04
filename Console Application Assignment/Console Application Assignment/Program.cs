using System;

namespace Console_Application_Assignment
{
    class Program
    {
        static void Main()
        {
            //User input times 50
            Console.WriteLine("Enter a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number times 50 is " + userNumber * 50);
            Console.ReadLine();

            //User input plus 25 
            Console.WriteLine("Enter another number: ");
            int anotherNumber = Convert.ToInt32(Console.ReadLine());
            int plus25 = 25;
            Console.WriteLine("Your number plus 25");
            Console.WriteLine(anotherNumber + plus25);
            Console.ReadLine();

            //User input divided by 12.5
            Console.WriteLine("Pick a number: ");
            double Num1 = Convert.ToDouble(Console.ReadLine());
            double dvd = 12.5;
            Console.WriteLine("This number divided by 12.5 is ");
            Console.WriteLine(Num1 / dvd);
            Console.ReadLine();

            //Checking to see if input is greater than 50
            Console.WriteLine("You know what to do *(Pick a number)*");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("This number is greater than 50(?)");
            bool trueOrfalse = Num2 > 50;
            Console.Write(trueOrfalse.ToString());
            Console.ReadLine();

            //Divide by 7 and see if there is a remainder (Modulas Operator)
            Console.WriteLine("Are you sick of picking numbers yet? Too bad. Enter another");
            double Num3 = Convert.ToDouble(Console.ReadLine());
            double Num4 = 7;
            Console.WriteLine("If divided by 7 has a remainder of " + Num3 % Num4);
            Console.ReadLine();

        }
    }
}
