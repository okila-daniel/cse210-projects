
using System;

class Program
{
    static void Main(string[] args)
    {
        // Display the welcome message
        DisplayWelcome();

        // Ask for the user's name
        string name = PromptUserName();

        // Ask for the user's favorite number
        int number = PromptUserNumber();

        // Calculate the square of the number
        int square = SquareNumber(number);

        // Display the result
        DisplayResult(name, square);
    }

    // Displays a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Asks for and returns the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    // Asks for and returns the user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    // Squares the number and returns the result
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Displays the final result
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
