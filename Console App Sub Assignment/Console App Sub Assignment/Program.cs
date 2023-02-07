using System;

namespace Console_App_Sub_Assignment
{
    class Program
    {
        static void Main()
        {
            //Asks the user a question
            Console.WriteLine("Pick a number");
            //age converts to int datatype(variable) named: age
            int num = Convert.ToInt32(Console.ReadLine());
         
            //while statement is true run loop
            while (num <100)
            {
                //while statement is true write : 
                Console.WriteLine("Number plus one= " + num);

                //This adds plus one to the variable every time the loops goes around
                num++;

                //if number is less than 101 than loop repeats. if it hits 101 then loop breaks.
                if (num > 101)
                    break;
            }
          

            Console.Read();
        }

    }
}

