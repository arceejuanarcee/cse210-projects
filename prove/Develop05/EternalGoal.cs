public class EternalGoal : Goal
{
    private bool _isComplete;

    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        _points += 100; // Incremental points for eternal goals, adjust as needed
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"{(_isComplete ? "[X]" : "[ ]")} {_shortName}: {_description} - {_points} points (eternal)";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{_shortName},{_description},{_points}";
    }
}
