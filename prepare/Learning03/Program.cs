using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Michael Pitcher", "Calculus");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Harry Potter", "Integrals", "9.8", "1-20");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Bilbo Baggins", "The ring", "The Hobbit:There and back again");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}