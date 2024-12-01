using System;

public class Entry
{
    //Sets each member to a name
    private string _date;
    private string _promptText;
    private string _entryText;

    private string _noteText;

    // Sets each string as a variable in Entry
    public Entry(string date, string promptText, string entryText, string noteText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        _noteText = noteText;
    }

   // Function to Display date, prompt, and entry
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine($"Note: {_noteText}");
    }

  
    public string GetDate() => _date;
    public string GetPrompt() => _promptText;
    public string GetEntry() => _entryText;
    public string GetNote() => _noteText;
}
