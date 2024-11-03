public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance() => _laps * 50 / 1000.0 * 0.62; // in miles
    public override double GetSpeed() => (GetDistance() / GetDuration()) * 60;
    public override double GetPace() => GetDuration() / GetDistance();
}
