public class MathAssignment : Assignment
{
    //attributes
    private string _section;
    private string _problems;


    //Constuctor
    public MathAssignment(string studentName, string topic, string section, string problems) : base(studentName, topic)
    {
        _section = section;
        _problems = problems;
    }

    //methods

    public string GetHomeworkList()
    {   
        return $"Section {_section} Problems {_problems}";
    }
} 