using System;


namespace Daily_Report
{
    class Program
    {
        static void Main()
        {
            //First Line
                Console.WriteLine("Academy of Learning Career College");
            //Second Line
                Console.WriteLine("Student Daily Report");
            //Console.WriteLine("Please save your data according to its proper data type");
            //Your Name?
                Console.WriteLine("What is your name?");
                string yourName = Console.ReadLine();
            //Responsive Reply + Next Question 
                Console.WriteLine("Hello " + yourName + ". What course are you on?");
                string yourCourse = Console.ReadLine();
            //Question C Page #
                Console.WriteLine("Wow " + yourCourse + "! What page number?");
                string yourPage = Console.ReadLine();
            //Converting string to integer 
                int currentPage = Convert.ToInt32(yourPage);
            // Next question to answer with a boolean 
                Console.WriteLine(yourPage + " Do you need help with anything? Please answer \"true\" or \"false\"");
                string trueorfalse = Console.ReadLine();
            //Converting String to Boolean
                 bool torf = Convert.ToBoolean(trueorfalse);
            //Last few questions
            Console.WriteLine("Are there any positive experiences you'd like to share?");
            string experiences = Console.ReadLine();
            Console.WriteLine("Is there other feedback you'd like to provide?");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string yourTodayHours = Console.ReadLine();
            //Convert String to Int
            int currentHours = Convert.ToInt32(yourTodayHours);
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
