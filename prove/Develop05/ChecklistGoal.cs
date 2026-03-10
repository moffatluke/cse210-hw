using System.Diagnostics.Contracts;

public class ChecklistGoal : Goal
{
    //Attributes
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    //Constuctors
    //One for brand new goals
    //the other for loaded goals
    public ChecklistGoal(string goalName, string description, int pointValue, int amountCompleted, int target, int bonus) 
    : base(goalName, description, pointValue) //Use Goal class constuctor. 
    {
        //Attributes for this class only:
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string goalName, string description, int pointValue, int target, int bonus) 
    : base(goalName, description, pointValue) //Use Goal class constuctor. 
    {
        _target = target;
        _bonus = bonus;
    }



    //Methods
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override int RecordEvent()
    {
        bool wasComplete = IsComplete();

        _amountCompleted++;

        if (!wasComplete && _amountCompleted >= _target)
        {
            return GetPoints() + _bonus;
        }

        return GetPoints();
    }
    

    public int GetTarget()
    {
        return _target;
    }
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public int GetBonus()
    {
        return _bonus;
    }
    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[x]" : "[ ]"; 
        //Ternary Operator ('?') for this meaning that the first checked box is true and the second blank box is false. 
        // Thought it would be helpful here to check the boxes
        return $"{status} {GetGoalName()} ({GetDescription()}) -- currently completed: {GetAmountCompleted()}/{GetTarget()}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetGoalName()}|{GetDescription()}|{GetPoints()}|{_amountCompleted}|{_target}|{_bonus}";
    }

}