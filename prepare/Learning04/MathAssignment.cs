public class MathAssignment : Assignment
{
    //todo

    //attributes
    private string _section;
    private string _problems;


    //Constuctor
    public MathAssignment(string studentName, string topic, string section, string problems) : base(studentName, topic)
    {
        _section = section;
        _problems = problems;
    }
} 