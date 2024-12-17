using System;
using System.Diagnostics.Metrics;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        DisplayStartingMessage();
        _description = "This activity will help you relaxby walking you" +
        "through breathing in and out slowly. Clear your mind and focus on breathing.";
        _name = "Breathing";
        Thread.Sleep(1000);
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get Ready..\n");
        Thread.Sleep(3000);
        int counter = _duration;
        while (counter >= 0)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            counter -= 4;
            Console.WriteLine("Breathe out...");
            ShowCountDown(7);
            counter -= 7;
        }
        Console.Clear();
        DisplayEndingMessage();
        
    }
}