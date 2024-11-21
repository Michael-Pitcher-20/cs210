using System;

class Program
{
    static void Main(string[] args)
    {

        Random random = new Random();
        int randomMagic = random.Next(1, 100);
        int answer = randomMagic - 1;

        while (answer != randomMagic)
        {

            Console.Write("What is the magic number?:");
            answer = int.Parse(Console.ReadLine());

            if (answer < randomMagic)
            {
                Console.WriteLine("Greater");
            }
            else if (answer > randomMagic)
            {
                Console.WriteLine("Less");
            }
            else
            {
                Console.WriteLine("You guessed the magic number!");
            }
        }
    }
}