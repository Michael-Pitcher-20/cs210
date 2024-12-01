using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;
    private Random _random;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What is something you are grateful for?",
            "What was the highlight of your day?",
            "What are you most excited for this week?",
            "How did your day go? Why do you believe it went that way?",
            "What is something that is going bad that you can use to your gain?"
        };
        
        
    }

    public string GeneratePrompt()
    {
        _random = new Random();
        int index = _random.Next(_prompts.Count); 
        return _prompts[index];
    }
}
