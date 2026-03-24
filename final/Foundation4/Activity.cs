public abstract class Activity
{
    //attributes
    private string _date;
    private int _lengthMinutes;

    //Constuctor
    public Activity(string date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    //Methods
    // GETTERS ----------------------------------
    public string GetDate()
    {
        return _date;
    }

    public int GetLengthMinutes()
    {
        return _lengthMinutes;
    }

    // ABSTRACT --------------------------------------------------------------
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // GET SUMMARY -------------
    public string GetSummary()
    {
        return $"{GetDate()} {GetType().Name} ({GetLengthMinutes()} min) - Distance: {GetDistance():0.00} miles, Speed: {GetSpeed():0.00} mph, Pace: {GetPace():0.00} min per mile";
    }
    // Used :0.00 after some of the methods to format them. It round them and only displays the two decimal palces. 
    //learned on https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
    //Used GetType().Name to get the name of the the activity. 
}