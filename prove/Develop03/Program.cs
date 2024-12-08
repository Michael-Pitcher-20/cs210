using System;
using System.Security.Cryptography.X509Certificates;

//I had my friend and my brother in law help me
// I used chat gpt to help explain or show examples of parsing a text file and accessing that file
class Program
{
    static void Main(string[] args)
    {
        Scripture currentScripture = new Scripture();
        bool exitCase;
        do {
            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayText());
            Console.WriteLine("\nClick Enter to continue and hide, type quit to quit");
            string answer = Console.ReadLine();
            if (answer == "quit")
            {
                exitCase = true;
            }
            else
            {
                if (currentScripture.IsCompletelyHidden() == true)
                {
                    Console.WriteLine("Everything is now hidden.\n");
                    System.Environment.Exit(0);
                }
                else
                {
                    currentScripture.HideRandomWords();
                }
                exitCase = false;
            }
        } while (exitCase != true);
    }
}