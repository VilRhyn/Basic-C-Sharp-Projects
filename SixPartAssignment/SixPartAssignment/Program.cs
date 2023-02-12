using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //---------------------------Console App Assignment Part 1------------------------------------//
        //1.	A one-dimensional array of strings.
        string[] colors = { "Blue ", "Red ", "Yellow ", "Green ", "Purple ", "Orange ", "Pink " };

        //2.    Ask the user to input some text.
        Console.WriteLine("Please enter the name of a colour");

        //Creates a variable for the user input 
        string userinput = Console.ReadLine();

        //3.	A loop that iterates through each string in the array and adds the user's text input
        //to the end of each string. This step will not output anything to the console, but will update
        //each array element by appending the user's text.

        for (int i = 0; i < colors.Length; i++)
        {
            colors[i] += userinput;
        }


        //4.	then create a second loop that prints off each string in the array one at a time.
        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }

        //--------------------------Console App Assignment Part 2------------------------------//
        //1.     An infinite loop 
        int steps = 0;
        for (; ; )
        {
            if (steps == 101)
            {
                break;//asking the infinite loop to stop once the number hits 100
            }
            Console.WriteLine(steps);
            steps++;
        }
        Console.ReadLine();

        //--------------------------Console App Assignment Part 3----------------------------//
        //1.   A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
        for (int a = 0; a < 5; a++)
        {
            Console.WriteLine(a);//3. Save and execute
        }

        //3.  Add another loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
        for (int b = 0; b <= 10; b++)
        {
            Console.WriteLine(b);
        }

        Console.ReadLine();

        do
        { //to repeat the loop later

            //-------------------Console App Assignment Part 4--------------------------//


            // 1.A list of strings where each item in the list is unique.
            List<string> studentNames = new List<string>() { "Melyssa", "Jess", "Rhyn", "Hela", "Nick", "Ben", "Trisha" };

            //2.	Ask the user to input text to search for in the list.
            Console.WriteLine("Please input a name to check if there is a match in the database.");
            string responseName = Console.ReadLine();

            //3.	A loop that iterates through the list and *see 3a.
            bool nameGuess = false;
            for (int index = 0; index < studentNames.Count; index++)
            {
                string name = studentNames[index];

                if (name == responseName)
                {
                    nameGuess = true;
                    //4.	Add code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list.
                    Console.WriteLine("The name \"{0}\" had a match at index {1}", name, index);
                   
                }
              
            }
            if (nameGuess == false)
            {
                Console.WriteLine("There were no matches for that name.");
            }
            //3a.    then displays the index of the list item that contains matching text on the screen.
            else
            {
                Console.WriteLine("There is at least 1 match with the following name: " + responseName);
                // 5.Add code that stops the loop from executing once a match has been found.

                break;
            }
       

        } while (true);//Reapeat questionaire loop 
        
        Console.ReadLine();

        //--------------------Console App Assignment Part 5--------------------------------//

        //1.   A list of strings that has at least two identical strings in the list. 
        List<string> studentNames1 = new List<string>() { "John", "Jacob", "Jingle", "Heimer", "Schmidt", "Jacob" };

        //Ask the user to select text to search for in the list.
        Console.WriteLine("Please input a criminal name to check if there is a match in the database.");
        string responseName1 = Console.ReadLine();

        //2.     Create a loop that iterates through the list and then displays the indices of the list that contain matching text on the screen.
  
        bool nameGuess1 = false;
        for (int index1 = 0; index1 < studentNames1.Count; index1++)
        {
            string name1 = studentNames1[index1];

            if (name1 == responseName1)
           
            {
                nameGuess1 = true;

                Console.WriteLine("The name \"{0}\" had a match at index {1}", name1, index1);
            
            }
        }
        //3.      Add code to the loop to check if the user put in text that isn't on the list and,
        if (nameGuess1 == false)
        {

            // 3a.      if they did, tells the user their input is not on the list.

            Console.WriteLine("There were no matches for that name.");
        }
        else
        {
            Console.WriteLine("There is at least 1 match with the following name: " + responseName1);
         // 2a..  Ensure to remove any break statements that may prevent your code from returning multiple matches.
        }
        // // (You do not need to provide any additional chances for the user to enter text.)
        Console.ReadLine();


        //----------Console App Assignment Part 6 Submission-----------------//

        //1.	Create a list of strings that has at least two identical strings in the list. 
        List<string> Letters = new List<string>() { "A", "B", "C", "D", "E", "A", "F", "C" };

        //2.     2.	Create a foreach loop that evaluates each item in the list, and displays a message showing
        //the string and whether or not it has already appeared in the list.
        foreach (string Letter in Letters) //for each letter in the list ... write it 
        {
            Console.WriteLine(Letter);
        }

        //this tells the duplicate items in the list using a hashset
        HashSet<string> hashset = new HashSet<string>();
        IEnumerable<string> duplicates = Letters.Where(e => !hashset.Add(e));

        Console.WriteLine("Duplicate elements are: " + String.Join(",", duplicates));


        Console.ReadLine();
        //I know its not exactly like the photo.. but does the same thing 
    }
}


