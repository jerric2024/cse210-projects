using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //Define variables;
        string letter;
        string sign;
        bool pass;
        
        //Request and format input from user;
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);
        int mod = percent % 10;

        //Check whether a grade is '+' or '-';
        if (mod >=7)
        {
            sign = "+";
        }
        else if (mod <3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
        
        //Check what grade is and whether passed;
        if (percent >= 97)
        {
            letter = "A";
            pass = true;
            sign = "";
        }
        else if (percent >= 90)
        {
            letter = "A";
            pass = true;
        }
        else if (percent >= 80)
        {
            letter = "B";
            pass = true;
        }
        else if (percent >= 70)
        {
            letter = "C";
            pass = true;
        }
        else if (percent >=60)
        {
            letter = "D";
            pass = false;
        }
        else
        {
            letter = "F";
            pass = false;
            sign = "";
        }

        //Print out statement to user;
        if (pass == true)
        {
            Console.WriteLine($"Great job! You got a {letter}{sign}!");
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine($"Oh no! You got a {letter}{sign}!");
            Console.WriteLine("You did not pass!");
        }

    }
}