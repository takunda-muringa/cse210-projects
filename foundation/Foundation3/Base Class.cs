public class Activity
{
    private DateTime _date;
    private int _duration; // in minutes

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual double GetDistance() => 0;
    public virtual double GetSpeed() => 0;
    public virtual double GetPace() => 0;

    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString()} ({_duration} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }

    protected int GetDuration() => _duration;
}
