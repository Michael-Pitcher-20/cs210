using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        int biggestNumber = 0;
        int sum = 0;
        double average;
        int smallestPositiveNumber = int.MaxValue;


        List<int> numbers = new List<int>();
        int answer = 1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (answer != 0)
        {
            Console.WriteLine("Enter number: ");
            answer = int.Parse(Console.ReadLine());
            numbers.Add(answer);
            
        }
        List<int> templist = new List<int>();

        foreach(int number in numbers)
        {
            if(number > biggestNumber)
            {
                biggestNumber = number;
            }
            sum = number + sum;
            if(number < smallestPositiveNumber && number > 0 && number != 0)
            {
                smallestPositiveNumber = number;
            }
        }
        numbers.Sort();
        average = sum / numbers.Count();
        Console.WriteLine($"The sum is: {sum}\n The average is : {average}\n The smallest positive number is: {smallestPositiveNumber}\n The sorted list is: ");
        foreach(int number in numbers)
        {
            Console.WriteLine($"{number}");
        }
    }
}