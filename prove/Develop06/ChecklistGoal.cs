public class ChecklistGoal : Goal
{
    public int CurrentCount { get; set; }

    public int RequiredCount { get; set; }
    //public int CurrentCount { get; private set; } = 0;
    public int BonusPoints { get; set; }

    public override void RecordEvent()
    {
        CurrentCount++;
        if (CurrentCount >= RequiredCount)
        {
            IsCompleted = true;
            Console.WriteLine($"You completed the checklist goal and earned a bonus of {BonusPoints} points!");
        }
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()}:{RequiredCount}:{CurrentCount}:{BonusPoints}";
    }
}
