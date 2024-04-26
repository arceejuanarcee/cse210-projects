using System;

class Program
{
    static void Main(string[] args)
    {
         DisplayWelcomeMessage();

        string userFirstName = PromptUserName();
        int userFavoriteNumber = PromptUserNumber();

        int squaredFavoriteNumber = SquareNumber(userFavoriteNumber);

        DisplayResult(userFirstName, squaredFavoriteNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your first name: ");
        string firstName = Console.ReadLine();

        return firstName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());

        return favoriteNumber;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string firstName, int squaredNumber)
    {
        Console.WriteLine($"{firstName}, the square of your favorite number is {squaredNumber}");
    }
}
