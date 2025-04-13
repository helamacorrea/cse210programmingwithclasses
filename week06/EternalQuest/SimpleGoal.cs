public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name,description,points)
    {
        _isComplete = false;
    }
    public SimpleGoal(string name, string description, int points, bool completed) : base(name,description,points)
    {
        _isComplete = completed;
    }
    public override int IsCheckListFull()
    {
        return 0;
    }
    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetName()}**{GetDescription()}**{GetPoints()}**{_isComplete}";
    }


}