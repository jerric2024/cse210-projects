using System;

class Program
{
    static void Main(string[] args)
    {
        //Define variables;
        int guess;
        
        /*Get the magic number;
        Console.Write("What is the magic number? ");
        string userInput1 = Console.ReadLine();
        int number = int.Parse(userInput1);*/

        //Supply a random magic number between 1 and 100;
        Console.WriteLine("I have the magic number. ");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        //Loop through guesses until magic number is guessed;
        do
        {
            Console.Write("What is your guess? ");
            string userInput2 = Console.ReadLine();
            guess = int.Parse(userInput2);

            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != number);
        



    }
}