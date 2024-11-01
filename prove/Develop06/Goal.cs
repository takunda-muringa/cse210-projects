using System;

public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    public bool IsCompleted { get; protected set; } = false;

    public abstract void RecordEvent();
    public virtual string GetStringRepresentation()
    {
        return $"{GetType().Name}:{Name}:{Description}:{Points}:{IsCompleted}";
    }
}
