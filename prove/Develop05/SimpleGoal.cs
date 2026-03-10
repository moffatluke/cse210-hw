public class SimpleGoal : Goal
{
    //attributes
    private bool _isComplete;
    //Constuctors
    //One for a brand new goal 
    //The other for a goal from a file

    public SimpleGoal(string goalName, string description, int pointValue) 
    : base(goalName, description, pointValue) //Use Goal class constuctor. 
    {
        _isComplete = false; //set to false becasue is is not done yet.
    }


    public SimpleGoal(string goalName, string description, int pointValue, bool IsComplete)
    : base( goalName, description, pointValue)
    {
        _isComplete = IsComplete;

    }

//Methods
    //update the goal's progress and completion state
    //return the points
    public override int RecordEvent()

    {
        if (!_isComplete)
        {
            _isComplete = true;
            return GetPoints();
        }
        return 0;
    }

    public override bool IsComplete()
    {   
        Console.WriteLine("");
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{GetGoalName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
    }

}