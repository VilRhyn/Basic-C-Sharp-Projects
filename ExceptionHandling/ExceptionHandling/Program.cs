using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //Console App Strings and Integers Assignment Submission

        //1. Create a list of integers.
        List<int> numbers = new List<int>() { 10, 20, 50, 100 };

        //Adding a console line, numbers in list 
        Console.WriteLine("The numbers in the list are 10, 20, 50, and 100.");

        //1a. Ask the user for a number to divide each number in the list by
        Console.WriteLine("Pick a number to divide into.");

        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(num1 + " divided by each number in the list is: ");

        //1b. Write a loop that takes each integer in the list, divides it by the number the user entered,
        //and displays the result to the screen.
        try
        {
            foreach (int number in numbers)
            {
                int result = number / num1;
                Console.WriteLine(result);
            }
        }
        catch (DivideByZeroException)//catch 
        {
            Console.WriteLine("Please do not divide by zero");//zero exception
        }
        catch (FormatException)//catch 
        {
            Console.WriteLine("Please type a whole number");//decimal/format(letter) exception
        }
        catch (Exception ex)//catch 
        {
            Console.WriteLine(ex.Message);//any other exception
        }
        finally//last section of a try/catch 
        {
            Console.ReadLine();//reads through till the end 
        }
        Console.WriteLine("The program has emerged from the try/catch block and continued on with program execution");
        Console.ReadLine();

    }
}