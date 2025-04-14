public class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {   
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / GetMinutes() * 60;
    }
    public override double GetPace()
    {
        return GetMinutes() / _distance;
    }
    public override string GetSummary()
    {
        //example: 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km
        return $"{GetDate()} Running ({GetMinutes()} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}