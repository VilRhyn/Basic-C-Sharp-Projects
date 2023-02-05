using System;

namespace MathComparisonSubAssignment
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Anonymous Income Comparison");
            Console.WriteLine("Person 1");
            Console.WriteLine("What is you hourly rate? Ex: 12");
            //psn1Hourly/Hours needs to be read as an interger for operations later on 
            int psn1Hourly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours do you work a week? Ex 20");
            int psn1Hours = Convert.ToInt32(Console.ReadLine());

            //Variable psn1Wkly= hrs * hrly = weekly
           int psn1Wkly = (psn1Hourly * psn1Hours);

            

            Console.WriteLine("Person 2");
            Console.WriteLine("What is you hourly rate? Ex: 12");
            int psn2Hourly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours do you work a week? Ex 20");
            int psn2Hours = Convert.ToInt32(Console.ReadLine());

            int psn2Wkly = (psn2Hourly * psn2Hours);

       

            //This equations is weekly income times 52 weeks in a year 
            int psn1AnSal = psn1Wkly * 52;
            int psn2AnSal = psn2Wkly * 52;

            Console.WriteLine("Annual salary of Person 1: ");
            Console.WriteLine(psn1AnSal);
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 2: ");
            Console.WriteLine(psn2AnSal);
            Console.ReadLine();

            Console.WriteLine("Person 1 makes more money than Person 2");
            Console.Write(psn1AnSal > psn2AnSal);
            bool trueORfalse = Convert.ToBoolean(Console.ReadLine());
            Console.ReadLine();
            
        }
    }
}
