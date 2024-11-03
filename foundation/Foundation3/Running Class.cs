public class Running : Activity
{
    private double _distance; // in miles

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;
    public override double GetSpeed() => (GetDistance() / GetDuration()) * 60;
    public override double GetPace() => GetDuration() / GetDistance();
}
