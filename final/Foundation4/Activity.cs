using System;

public abstract class Activity
{
    private DateTime _date;
    private int _lengthInMinutes;

    protected Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public DateTime Date
    {
        get { return _date; }
    }

    public int LengthInMinutes
    {
        get { return _lengthInMinutes; }
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} ({_lengthInMinutes} min)";
    }
}
