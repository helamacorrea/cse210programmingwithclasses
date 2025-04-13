public class CheckListGoal : Goal 
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name,description,points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public CheckListGoal(string name, string description, int points, int target, int bonus, int amount) : base(name,description,points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amount;

    }

    public int GetBonus()
    {
        return _bonus;
    }
    public override int IsCheckListFull()
    {
        int signal;
        if (_amountCompleted == _target)
        {
            signal = _bonus;
            
        }
        else 
        {
            signal = 0;
        }
        return signal;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
    }
    public override bool IsComplete()
    {
        bool isComplete;
        if (_amountCompleted >= _target)
        {
            isComplete = true;
        }
        else
        {
            isComplete = false;
        }
        return isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{GetName()}**{GetDescription()}**{GetPoints()}**{_bonus}**{_target}**{_amountCompleted}";
    }
    public override string GetDetailsString()
    {
        string checkBox;
        if (IsComplete())
        {
            checkBox = "[v]";
        }
        else
        {
            checkBox = "[ ]";
        }
        return $"{checkBox} {GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }
}