public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract int IsCheckListFull();
    public virtual string GetDetailsString()
    {
        //checkbox, the short name, and description.
        // and for the check list class also the
        //  numberof times the goal was accomplished
        string checkBox;
        if (IsComplete())
        {
            checkBox = "[v]";
        }
        else
        {
            checkBox = "[ ]";
        }
        return $"{checkBox} {_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation(); //in a way to save to a file
    public string GetName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
  
    public int GetPoints()
    {
        return _points;
    }
    



    

}