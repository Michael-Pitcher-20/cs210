using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
    
        Console.WriteLine("Please enter your name: ");
        string username = Console.ReadLine();
        DisplayPersonalMessage(username);
        Console.WriteLine("Please enter your favorite number: ");
        int favoritenumber = int.Parse(Console.ReadLine());
        Square(favoritenumber, username);
    }
    static void Square(int input,string username)
    {
        DisplayPersonalMessage(username);
        int Square = input * input;
        Console.WriteLine($"Your favorite number squared is {Square} ");

    }
static void DisplayMessage()
{
    Console.WriteLine("Welcome to the program!");
}

static void DisplayPersonalMessage(string username)
{
    Console.WriteLine($"Hello {username}");
}
}