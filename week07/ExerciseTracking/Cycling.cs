public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return GetMinutes() / GetPace();
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetMinutes()} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace():F2} min per km";
    }
}