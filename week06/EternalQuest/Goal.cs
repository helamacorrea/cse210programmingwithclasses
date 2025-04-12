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
    public virtual string GetDetailsString()
    {
        //checkbox, the short name, and description.
        // and for the check list class also the
        //  numberof times the goal was accomplished
        return "";
    }
    public abstract string GetStringRepresentation(); //in a way to save to a file





    

}