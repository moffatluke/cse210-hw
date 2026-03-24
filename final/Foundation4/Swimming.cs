public class Swimming : Activity
{
    //Attribute:
    private int _laps;

    //Consotuctor
    public Swimming(string date, int lengthMinutes, int laps) :
    base(date, lengthMinutes)
    {
        _laps = laps;
    }

    //Methods
    public override double GetDistance()
    {
        return _laps * 0.03107;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetLengthMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetLengthMinutes () / GetDistance();
    }
}