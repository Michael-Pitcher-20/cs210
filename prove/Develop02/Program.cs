using System;
using System.Collections.Generic;
// I exceeded the requirements by adding a fourth part of the entry being a note or title that you can insery into each journal entry.
public class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            MainMenu();

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GeneratePrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.WriteLine("Enter your journal entry: ");
                    string entryText = Console.ReadLine();
                    Console.WriteLine("Enter a note/title to remember this entry.");
                    string noteText = Console.ReadLine();
                    journal.AddEntry(new Entry(DateTime.Now.ToString("yyyy-MM-dd"), prompt, entryText, noteText));
                    Console.WriteLine("Entry submitted. Consider saving.");
                    break;

                case "2":
                    Console.WriteLine("Displaying all entries: ");
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine();
                    try
                    {
                        journal.SaveToFile(saveFilename);
                        Console.WriteLine($"Entries successfully saved to {saveFilename}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error saving to file: {ex.Message}");
                    }
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine();
                    loadFilename = loadFilename+ ".txt";
                    try
                    {
                        journal.LoadFromFile(loadFilename);
                        Console.WriteLine($"Entries successfully loaded from {loadFilename}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error loading from file: {ex.Message}");
                    }
                    break;

                case "5":
                    Console.WriteLine("Exiting Journal...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }

    public static void MainMenu()
    {
        Console.WriteLine("Please choose one of the following choices: ");
        Console.WriteLine("1. Write a new journal entry");
        Console.WriteLine("2. Display all journal entries");
        Console.WriteLine("3. Save entries to a file");
        Console.WriteLine("4. Load entries from a file");
        Console.WriteLine("5. Quit");
    }
}
