public abstract class Activity 
{
    private string _date;
    private int _activityLength; //in minutes

    public Activity(string date, int minutes)
    {
        _date = date;
        _activityLength = minutes;
    }
    public string GetDate()
    {
        return _date;
    }
    public int GetMinutes()
    {
        return _activityLength;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();
    
}