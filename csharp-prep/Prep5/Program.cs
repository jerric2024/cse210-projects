using System;

class Program
{
    static void Main(string[] args)
    {
        //Enter the functions for all tasks;
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favNumber);
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        //Display the welcome message;
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        //Request name and return to main;
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        //Request number and return to main;
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        //Calculate square and return to main;
        int calc = number * number;
        return calc;
    }

    static void DisplayResult(string name, int square)
    {
        //Display final message with name and square;
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}