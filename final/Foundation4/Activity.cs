using System.Data;

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

    //methods
    
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
        return "";
        //todo
    }
}