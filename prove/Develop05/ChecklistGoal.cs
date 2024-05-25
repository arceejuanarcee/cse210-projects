public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _isComplete;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            _points += _bonus;
            _isComplete = true;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }

    public override string GetDetailsString()
    {
        return $"{(_isComplete ? "[X]" : "[ ]")} {_shortName}: {_description} - {_points} points. Completed: {_amountCompleted}/{_target}. Bonus: {_bonus}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }
}
