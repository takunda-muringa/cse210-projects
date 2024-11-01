public class SimpleGoal : Goal
{
    public override void RecordEvent()
    {
        IsCompleted = true;
    }
}
