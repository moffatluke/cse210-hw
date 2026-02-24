public class Activity //this is the base class
{
    //Attributes:

    private string _name;
    private string _description;
    private int _durationsSeconds;



//Constuctors:

public Activity(string name, string description, int durationsSeconds)
    {
        _name = name;
        _description = description;
        _durationsSeconds = durationsSeconds;
        durationsSeconds  = 0;
    }
//Methods

    public void DisplayStartingMesseage()
    {
        //todo
    }

    public void DisplayEndingMesseage()
    {
        //todo
    }

    public void SetDuration(int seconds)
    {
        //todo
    }

    public void GetDuration()
    {
        //todo
    }

    public void ShowSpinner(int seconds)
    {
        //todo
    }

    public void ShowCountdown(int seconds)
    {
        //todo
    }
}