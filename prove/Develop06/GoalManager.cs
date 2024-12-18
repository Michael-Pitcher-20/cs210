using System;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager() {}

    private void DotDotDot()
    {
        Console.Write(Convert.ToChar(176));
        Thread.Sleep(500);
        Console.Write(Convert.ToChar(176));
        Thread.Sleep(500);
        Console.Write(Convert.ToChar(176));
        Thread.Sleep(500);
        Console.Write(Convert.ToChar(176));
        Thread.Sleep(500);
        Console.Write("\b\b\b   \b\b\b");
    }

    public void CreateGoal()
    {
        Console.WriteLine("What type of Goal would you like to create?");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("\nWhat would you like to name it? ");
                string tempNameSimple = Console.ReadLine();
                Console.WriteLine("Describe your goal: ");
                string tempDescriptionSimple = Console.ReadLine();
                Console.WriteLine("How many points should this goal be worth? ");
                int tempPointsSimple = int.Parse(Console.ReadLine());
                _goals.Add(new SimpleGoal(tempNameSimple, tempDescriptionSimple, tempPointsSimple, false));
                break;
            case 2:
                Console.WriteLine("\nWhat would you like to name it? ");
                string tempNameEternal = Console.ReadLine();
                Console.WriteLine("Describe your goal: ");
                string tempDescriptionEternal = Console.ReadLine();
                Console.WriteLine("How many points should this goal be worth? ");
                int tempPointsEternal = int.Parse(Console.ReadLine());
                _goals.Add(new EternalGoal(tempNameEternal, tempDescriptionEternal, tempPointsEternal));
                break;
            case 3:
                Console.WriteLine("\nWhat would you like its name to be? ");
                string tempNameCheck = Console.ReadLine();
                Console.WriteLine("Describe your goal: ");
                string tempDescriptionCheck = Console.ReadLine();
                Console.WriteLine("How many points should this goal give? ");
                int tempPointsCheck = int.Parse(Console.ReadLine());
                Console.WriteLine("How many completions are required for the bonus? ");
                int tempTargetCheck = int.Parse(Console.ReadLine());
                Console.WriteLine("How many points should the bonus be worth? ");
                int tempBonusCheck = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(tempNameCheck, tempDescriptionCheck, tempPointsCheck, tempTargetCheck, tempBonusCheck, 0));
                break;
            default:
                Console.WriteLine("UNKNOWN ERROR");
                break;
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou Currently Have: {_score} Points\n");
    }
    public void ListGoals()
    {
        Console.WriteLine("Current Goals: ");
        int tempGoalIndex = 1;
        foreach (Goal goal in _goals)
        {
            switch (goal.GetGoalType())
            {
                case "SimpleGoal":
                    Console.WriteLine($" {tempGoalIndex}. {goal.GetDisplayText()}");
                    break;
                case "EternalGoal":
                    Console.WriteLine($" {tempGoalIndex}. {goal.GetDisplayText()}");
                    break;
                case "ChecklistGoal":
                    Console.WriteLine($" {tempGoalIndex}. {goal.GetDisplayText()}");
                    break;
                default:
                    Console.WriteLine("UNKNOWN ERROR");
                    break;
            }
            tempGoalIndex += 1;
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("What is the index of the goal you completed?");
        int goalIndex = int.Parse(Console.ReadLine());
        _score += _goals[goalIndex - 1].GetPoints();
        _goals[goalIndex - 1].RecordEvent();
    }
    public void LoadGoals(string fileName)
    {
        _goals.Clear();
        try
        {
            string[] fileLines = File.ReadAllLines(fileName);
            foreach (string line in fileLines)
            {
                string[] parts = line.Split("><");
                switch (parts[0])
                {
                    case "SimpleGoal":
                        SimpleGoal currentLoadingSimpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                        _goals.Add(currentLoadingSimpleGoal);
                        break;
                    case "EternalGoal":
                        EternalGoal currentLoadingEternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                        _goals.Add(currentLoadingEternalGoal);
                        break;
                    case "ChecklistGoal":
                        ChecklistGoal currentLoadingChecklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                        _goals.Add(currentLoadingChecklistGoal);
                        break;
                    default:
                        Console.WriteLine("UNKNOWN ERROR");
                        break;
                }
            }
        }    
        catch (Exception x)
        {
            Console.WriteLine(x.Message);
        }
    }
    public void SaveGoals(string fileName)
    {
        using (StreamWriter currentFile = new StreamWriter(fileName))
        {
            foreach (Goal currentGoal in _goals)
            {
                currentFile.WriteLine(currentGoal.GetStringRepresentation());
            }
        }
    }
    public void DeleteGoal(int goalIndex)
    {
        _goals.RemoveAt((goalIndex - 1));
    }

    public void DisplayMenu()
    {
        Console.Clear();
        DisplayPlayerInfo();
        Console.WriteLine("Goals Menu");
        Console.WriteLine("   1. Create a New Goal");
        Console.WriteLine("   2. List your Goals");
        Console.WriteLine("   3. Record your Progress");
        Console.WriteLine("   4. Load a Goal File");
        Console.WriteLine("   5. Save Goals To a File");
        Console.WriteLine("   6. Delete a Goal");
        Console.WriteLine("   0. Quit");
        Console.Write("\nOption Choice: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.Clear();
                CreateGoal();
                Console.WriteLine("Press Enter to Continue: "); Console.ReadKey(); break;
            case 2:
                Console.Clear();
                ListGoals();
                Console.WriteLine("Press Enter to Continue: "); Console.ReadKey(); break;
            case 3:
                Console.Clear();
                RecordEvent();
                Console.WriteLine("Press Enter to Continue: "); Console.ReadKey(); break;
            case 4:
                Console.Clear();
                Console.WriteLine("Enter the name of the file you'd like to load:");
                LoadGoals(Console.ReadLine());
                Console.WriteLine("Press Enter to Continue: "); Console.ReadKey(); break;
            case 5:
                Console.Clear();
                Console.WriteLine("Enter the name of a file you'd like to save:");
                SaveGoals(Console.ReadLine());
                Console.WriteLine("Press Enter to Continue: "); Console.ReadKey(); break;
            case 6:
                Console.Clear();
                Console.WriteLine("Enter the index number of the goal you'd like to delete:");
                DeleteGoal(int.Parse(Console.ReadLine()));
                Console.WriteLine("Press Enter to Continue: "); Console.ReadKey(); break;
            case 0:
                Console.Clear();
                Console.WriteLine("\n   Goodbye!\n");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Error Occurred, Try Again");
                DotDotDot(); break;
        }
    }
}