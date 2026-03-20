public class Lecture : Event
{
    //Attributes
    private string _speaker;
    private int _capacity;

    //Constructor
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) :
    base("Lecture", title, description, date, time, address) // Hard code lecture so it is the same everytime.
    {
        _speaker = speaker;
        _capacity = capacity;
    }


    //Methods
    //Overrides

    ////Full details - Lists all of the above, plus type of event and information specific to that event type. 
    // For lectures, this includes the speaker name and capacity.
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\n Speaker: {_speaker}\n Capacity: {_capacity}";
    }
}