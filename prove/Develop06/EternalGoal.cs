public class EternalGoal : Goal
{
    public override void RecordEvent()
    {
        // For eternal goals, just award points without marking as complete
        Console.WriteLine($"You earned {Points} points!");
    }
}
