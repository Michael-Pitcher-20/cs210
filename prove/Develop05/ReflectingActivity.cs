using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity()
    {
        
        _description = "This activity will help you reflect on times in your life" +
        " when you have shown strength and resilience. This will help you recognize the" +
        " \npower you have and how you can use it in other aspects of your life.";
        _name = "Reflecting";
        _prompts = new List<string>{"Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."};
        _questions = new List<string>{"- Why was this experience meaningful to you?",
                                    "- Have you ever done anything like this before?",
                                    "- How did you get started?",
                                    "- How did you feel when it was complete?",
                                    "- What made this time different than other times when you were not as successful?",
                                    "- What is your favorite thing about this experience?",
                                    "- What could you learn from this experience that applies to other situations?",
                                    "- What did you learn about yourself through this experience?",
                                    "- How can you keep this experience in mind in the future?"};
        DisplayStartingMessage();
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Thread.Sleep(1000);
        DisplayPrompt();
        Console.ReadLine();
        Console.WriteLine("Now ponder the following questions as they related to this experience.\n");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(4);
        DisplayQuestions();
        Console.Clear();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        return prompt;

    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        string question = _questions[random.Next(_questions.Count)];
        return question;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: \n");
        Console.WriteLine(GetRandomPrompt() + "\n");
        Console.WriteLine("When you have something in mind, press any key to continue.");
    }
    public void DisplayQuestions()
    {
        Console.Clear();
        int counter = _duration;
        while (counter >= 0)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(2);
            Console.WriteLine();
            counter -= 8;
        }

    }
}