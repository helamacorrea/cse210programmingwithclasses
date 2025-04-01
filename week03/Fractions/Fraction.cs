public class Fraction 
{
    private int _top = 0;

    private int _bottom = 0;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bot)
    {
        _top = top;
        _bottom = bot;
    }

    public int GetTop()
    {
        return _top;
    }

    public int GetBot()
    {
        return _bottom;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        double decimalValue = Convert.ToDouble(_top)/Convert.ToDouble(_bottom);
        return Math.Round(decimalValue,2);
    }

    public void SetTop(int number)
    {
        _top = number;
    }

    public void SetBot(int number)
    {
        _bottom = number;
    }
}   