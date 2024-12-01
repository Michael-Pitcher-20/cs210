using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{

    public Journal()
    {
        _entries = new List<Entry>();
    }
    private List<Entry> _entries;

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

  public void SaveToFile(string filename)
    {
        try
        {
            if (!filename.EndsWith(".txt"))
            {
                filename += ".txt";
            }

            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in _entries)
                {
                    writer.WriteLine($"{entry.GetDate()}|{entry.GetPrompt()}|{entry.GetEntry()}|{entry.GetNote()}");
                }
            }

            Console.WriteLine("Journal saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal to file: {ex.Message}");
        }
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 4)
                {
                    _entries.Add(new Entry(parts[0], parts[1], parts[2], parts[3]));
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");

        }
    }
}