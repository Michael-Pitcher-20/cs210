using System;
using System.Diagnostics.Metrics;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        _description = "This activity will help you reflect on the good things" +
            "in your life by having you list as many things as you can in a certain area";
        _name = "Listing";
        DisplayStartingMessage();
        _prompts = new List<string>{"Who are people that you appreciate?",
                                    "What are personal strengths of yours?",
                                    "Who are people that you have helped this week?",
                                    "When have you felt the Holy Ghost this month?",
                                    "Who are some of your personal heroes?"};
        _count = 0;

    }
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get Ready..\n");
        ShowSpinner(2);
        Console.WriteLine("\nList as many responses as you can to the following prompt: ");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("\nYou may begin in: ");
        ShowCountDown(4);
        GetListFromUser();
        DisplayEndingMessage();




    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        return prompt;
    }
    public void GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            _count += 1;
        }
        Console.WriteLine($"You have listed {_count} things!");
    }
}