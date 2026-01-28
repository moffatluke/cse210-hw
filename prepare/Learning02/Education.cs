//education for resume

public class Education
{
    public string _school;
    public string _awardYear;
    public string _level;


    public void getDiscription()
    {
        Console.WriteLine($"{_school}, {_awardYear}-{_level}");
    }
}