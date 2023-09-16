using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //Define variables and lists
        List<int> numbers = new List<int>();
        int newNumber;
        int largest = 0;
        float sum = 0;
        float listAvg = 0;

        //Explain the task and request a number
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        do
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            newNumber = int.Parse(userInput);

            if (newNumber > largest)
            {
                largest = newNumber; //Keep track of largest number;
            }
            
            if (newNumber != 0)
            {
                numbers.Add(newNumber); //Add the number to the list;
            }
                        
        } while (newNumber != 0);
        
        //Calculate the sum of the numbers;
        foreach (int number in numbers)
        {
            sum += number;
        }

        listAvg = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {listAvg}");
        Console.WriteLine($"The max is: {largest}");


    }
}