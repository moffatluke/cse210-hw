public class Assignment
{
    //member varaibles
    protected string _studentName;
    private string _topic;

    //Constuctor:
    public Assignment (string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }


    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }
    
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}