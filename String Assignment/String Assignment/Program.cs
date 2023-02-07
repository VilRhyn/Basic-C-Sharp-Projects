using System;
using System.Text;

namespace String_Assignment
{
    class Program
    {
        static void Main()
        {
            //Building a string via string builder. String is called myStringBuilder
            StringBuilder myStringBuilder = new StringBuilder("Time to party,", 25);//Initial display
           myStringBuilder.Append("and party...");//Adds text to String
            myStringBuilder.Append("and party some more");//Adds more text to growing string
            Console.WriteLine(myStringBuilder);
            

            //Initializing
            string hi = "Hello, World";
            string name = "Melanie";
            string num = "seven";
            string color = "Sunset";

            Console.WriteLine(hi.ToUpper());//Converts Hello, World to uppercase
            Console.WriteLine(name + "'s favorite number is: " + num + ", and her favorite colour is: " + color);//Concatenating 3 strings

            Console.ReadLine();
        }
    }
}
