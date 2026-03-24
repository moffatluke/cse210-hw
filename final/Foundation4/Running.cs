public class Running : Activity
{
    //Attribute
    private double _distance; //miles per hour

    //Constuctor
    public Running(string date, int lengthMinutes, double distance) :
        base(date, lengthMinutes)
    {
        _distance = distance;
    }

    //Methods
    public override double GetDistance()
    {
        return _distance;
    }
    
    public override double GetSpeed()
    {
        return (_distance / GetLengthMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetLengthMinutes() / _distance;
    }
}