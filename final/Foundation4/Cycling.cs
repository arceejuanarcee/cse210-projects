using System;

public class Cycling : Activity
{
    private double _speedInMph;

    public Cycling(DateTime date, int lengthInMinutes, double speedInMph)
        : base(date, lengthInMinutes)
    {
        _speedInMph = speedInMph;
    }

    public override double GetDistance()
    {
        return (_speedInMph * LengthInMinutes) / 60;
    }

    public override double GetSpeed()
    {
        return _speedInMph;
    }

    public override double GetPace()
    {
        return 60 / _speedInMph;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Cycling: Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
