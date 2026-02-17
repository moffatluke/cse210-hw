public class WritingAssignment : Assignment {

    //Member attiubutes
    private string _title;
    

    //Constructor:
    WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    

    //Methods
    public string GetWritingInfromation()
    {
        return $"{_title} by {_studentName}";
    }
}

//this is a test of git hub.