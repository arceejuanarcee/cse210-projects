using System;

public class Running : Activity
{
    private double _distanceInMiles;

    public Running(DateTime date, int lengthInMinutes, double distanceInMiles)
        : base(date, lengthInMinutes)
    {
        _distanceInMiles = distanceInMiles;
    }

    public override double GetDistance()
    {
        return _distanceInMiles;
    }

    public override double GetSpeed()
    {
        return (_distanceInMiles / LengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        return LengthInMinutes / _distanceInMiles;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Running: Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
