using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalScore = 0;

    static void Main()
    {
        LoadGoals();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("1. Create New Goal\n2. Record Goal Event\n3. Display Goals\n4. Save and Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal();
                    break;
                case "2":
                    RecordGoalEvent();
                    break;
                case "3":
                    DisplayGoals();
                    break;
                case "4":
                    SaveGoals();
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void CreateNewGoal()
    {
        Console.WriteLine("Select Goal Type: 1. Simple 2. Eternal 3. Checklist");
        string goalType = Console.ReadLine();
        Goal newGoal = null;

        Console.Write("Enter Goal Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Goal Description: ");
        string description = Console.ReadLine();
        Console.Write("Enter Goal Points: ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == "1")
        {
            newGoal = new SimpleGoal { Name = name, Description = description, Points = points };
        }
        else if (goalType == "2")
        {
            newGoal = new EternalGoal { Name = name, Description = description, Points = points };
        }
        else if (goalType == "3")
        {
            Console.Write("Enter Required Count for Checklist Goal: ");
            int requiredCount = int.Parse(Console.ReadLine());
            Console.Write("Enter Bonus Points: ");
            int bonusPoints = int.Parse(Console.ReadLine());
            newGoal = new ChecklistGoal { Name = name, Description = description, Points = points, RequiredCount = requiredCount, BonusPoints = bonusPoints };
        }

        if (newGoal != null)
        {
            goals.Add(newGoal);
            Console.WriteLine("Goal created successfully!");
        }
    }

    static void RecordGoalEvent()
    {
        DisplayGoals();
        Console.Write("Enter the number of the goal to record an event for: ");
        int goalNumber = int.Parse(Console.ReadLine());

        if (goalNumber >= 0 && goalNumber < goals.Count)
        {
            Goal selectedGoal = goals[goalNumber];
            selectedGoal.RecordEvent();
            totalScore += selectedGoal.Points;
            Console.WriteLine($"Current Score: {totalScore}");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    static void DisplayGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Goal goal = goals[i];
            string status = goal.IsCompleted ? "[X]" : "[ ]";
            Console.WriteLine($"{i}. {status} {goal.Name}: {goal.Description} ({goal.Points} points)");
            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"   Progress: {checklistGoal.CurrentCount}/{checklistGoal.RequiredCount}");
            }
        }
    }

    static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    static void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            string[] lines = File.ReadAllLines("goals.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                if (type == "SimpleGoal")
                {
                    goals.Add(new SimpleGoal { Name = name, Description = description, Points = points });
                }
                else if (type == "EternalGoal")
                {
                    goals.Add(new EternalGoal { Name = name, Description = description, Points = points });
                }
                else if (type == "ChecklistGoal")
                {
                    int requiredCount = int.Parse(parts[4]);
                    int currentCount = int.Parse(parts[5]);
                    int bonusPoints = int.Parse(parts[6]);
                    goals.Add(new ChecklistGoal { Name = name, Description = description, Points = points, RequiredCount = requiredCount, CurrentCount = currentCount, BonusPoints = bonusPoints });
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
    }
}
