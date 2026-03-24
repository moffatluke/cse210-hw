public class Cycling : Activity
{
    //Attribute
    private double _speed; //miles per hour

    //Constuctor
    public Cycling(string date, int lengthMinutes, double speed) :
        base(date, lengthMinutes)
    {
        _speed = speed;
    }

    //Methods

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return (GetSpeed() / 60) * GetLengthMinutes();
    }
    

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}
