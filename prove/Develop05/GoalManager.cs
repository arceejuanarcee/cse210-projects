using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _badgeLevel;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _badgeLevel = 1;
    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }

    public void ListGoalDetails()
    {
        int index = 1;
        int goalsAchieved = 0;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            if (goal.IsComplete())
            {
                goalsAchieved++;
            }
            index++;
        }
        Console.WriteLine($"Goals Achieved: {goalsAchieved}/{_goals.Count}");
        if (goalsAchieved == _goals.Count && _goals.Count > 0)
        {
            AwardBadge();
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select Goal Type: 1. Simple 2. Eternal 3. Checklist");
        string type = Console.ReadLine();

        Console.Write("Enter short name: ");
        string name = Console.ReadLine();

        Console.Write("Enter description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == "3")
        {
            Console.Write("Enter the number of times you intend to do this goal: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Enter the bonus points for exceeding the target: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Select the goal number to record an event:");
        ListGoalDetails();

        int goalNumber = int.Parse(Console.ReadLine()) - 1;

        if (goalNumber >= 0 && goalNumber < _goals.Count)
        {
            Goal selectedGoal = _goals[goalNumber];
            selectedGoal.RecordEvent();
            _score += selectedGoal.GetPoints();

            Console.WriteLine($"Recorded event for goal: {selectedGoal.GetShortName()}");
            Console.WriteLine($"New score: {_score}");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("Enter filename to save goals:");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter($"{filename}.txt"))
        {
            outputFile.WriteLine(_score);
            outputFile.WriteLine(_badgeLevel);
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("Enter filename to load goals:");
        string filename = Console.ReadLine();

        if (File.Exists($"{filename}.txt"))
        {
            string[] lines = File.ReadAllLines($"{filename}.txt");
            _score = int.Parse(lines[0]);
            _badgeLevel = int.Parse(lines[1]);
            _goals.Clear(); // Clear existing goals before loading

            for (int i = 2; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(",");
                string goalType = parts[0];

                if (goalType == "SimpleGoal")
                {
                    _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
                }
                else if (goalType == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                }
                else if (goalType == "ChecklistGoal")
                {
                    ChecklistGoal goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                    goal.SetAmountCompleted(int.Parse(parts[6])); // Set the amount completed directly
                    _goals.Add(goal);
                }
            }

            Console.WriteLine($"Loaded {lines.Length - 2} goals and {_score} points.");
        }
        else
        {
            Console.WriteLine("File not found. Returning to menu.");
        }
    }

    private void AwardBadge()
    {
        if (_badgeLevel < 10)
        {
            _badgeLevel++;
            Console.WriteLine($"Congratulations! You've earned a Level {_badgeLevel} badge for completing all your goals!");
        }
        else
        {
            Console.WriteLine("You are at the highest badge level! Keep up the good work!");
        }
    }
}
