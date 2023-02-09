using System;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
    {
        int[] numArray = { 5, 45, 89, 778, 4562, 48515 };//Creating a number array (index 0 - 5)
        string[] stringArray = { "You picked index 0", "You picked index 1", "You picked index 2", "You picked index 3", "You picked index 4", "You picked index 5" };//Create a  string array

        Console.WriteLine("Pick a [index] number");//Writes to console <
        int numPicked = Convert.ToInt32(Console.ReadLine());//Converts user input to int

        //creating if else statement for user input 
        if (numPicked == 0)
        {
            Console.WriteLine(numArray[0]); //<-- Variable [index]);
        }
        else if (numPicked == 1)
        {
            Console.WriteLine(numArray[1]);
        }
        else if (numPicked == 2)
        {
            Console.WriteLine(numArray[2]);
        }
        else if (numPicked == 3)
        {
            Console.WriteLine(numArray[3]);
        }
        else if (numPicked == 4)
        {
            Console.WriteLine(numArray[4]);
        }

        else if (numPicked >= 5)//Any number (5 or above) Console writes :
        {
            Console.WriteLine("You did not pick a valid index number");
        }

        Console.WriteLine("Please pick another index number for our string array");//string array instead of int
        int numPicked2 = Convert.ToInt32(Console.ReadLine());//converts user input to int for index

        if (numPicked2 == 0)//repeat 
        {
            Console.WriteLine(stringArray[0]);
        }
        else if (numPicked2 == 1)
        {
            Console.WriteLine(stringArray[1]);
        }
        else if (numPicked2 == 2)
        {
            Console.WriteLine(stringArray[2]);
        }
        else if (numPicked2 == 3)
        {
            Console.WriteLine(stringArray[3]);
        }
        else if (numPicked2 == 4)
        {
            Console.WriteLine(stringArray[4]);
        }

        else if (numPicked2 >= 5)//if number 5 or greater than console writes:
        {
            Console.WriteLine("You did not pick a valid index number");
        }

        List<int> intList = new List<int>();//creating (instantiating) a list 
        intList.Add(5);//list values (indicies)
        intList.Add(10);
        intList.Add(15);

        Console.WriteLine("Pick one last number");//Console Write
        int numPicked3 = Convert.ToInt32(Console.ReadLine());//Converts user input to int

        if (numPicked3 == 0) // if these numbers are picked write this:
        {
            Console.WriteLine("Number at index 0 is " + intList[0]);
        }

       else if (numPicked3 == 1)
        {
            Console.WriteLine("Number at index 1 is " + intList[1]);
        }
        else if (numPicked3 == 2)
        {
            Console.WriteLine("Number at index 2 is " + intList[2]);
        }

        else if (numPicked3 >= 3)//Or else do this
        {
            Console.WriteLine("You picked an invalid index number");
        }
        Console.ReadLine();//Pauses to read.
    }
}

