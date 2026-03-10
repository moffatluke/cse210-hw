using System.Diagnostics.Contracts;

public class EternalGoal : Goal
{

    //Constuctors

    public EternalGoal(string goalName, string description, int pointValue)
    : base(goalName, description, pointValue)
    {
    }


    //Methods
    public override int RecordEvent()
    {
        return GetPoints();
    }
    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{GetGoalName()}|{GetDescription()}|{GetPoints()}";
    }

}