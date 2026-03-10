using System.ComponentModel;

public abstract class Goal
{
    //Attibutes
    private string _goalName;
    private string _description;
    private int _pointValue;

    //Constuctors

    public Goal(string goalName, string description, int pointValue)
    {
        _goalName = goalName;
        _description = description;
        _pointValue = pointValue;
    }

    //Methods
    //Abstract
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    //Getters:
    public string GetGoalName()
    {
        return _goalName;
    }
    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _pointValue;
    }

    public virtual string GetDetailsString()
    {
        string status = IsComplete() ? "[x]" : "[ ]"; 
        //Ternary Operator ('?') for this meaning that the first checked box is true and the second blank box is false. 
        // Thought it would be helpful here to check the boxes
        return $"{status} {_goalName} ({_description})";
    }

    public virtual string GetStringRepresentation() //used to help format the goals to be saved.
    {
        return $"{_goalName}|{_description}|{_pointValue}";
    }
}