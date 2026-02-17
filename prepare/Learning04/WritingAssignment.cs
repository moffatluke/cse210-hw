public class WritingAssignment : Assignment {

    //Member attiubutes
    private string _title;
    

    //Constructor:
    public WritingAssignment(string studentName, string topic, string title) 
        : base(studentName, topic)
    {
        _title = title;
    }
    

    //Methods
    public string GetWritingInformation()
    {
        string studentName = GetStudentName();

        return $"{_title} by {_studentName}";
    }
}