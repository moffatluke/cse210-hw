public class Reception : Event
{
    //Attributes
    private string _rsvpEmail;

    //Constuctor
    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail) :
    base("Reception", title, description, date, time, address) // Hard code Reception so it is the same everytime.
    {
        _rsvpEmail = rsvpEmail;
    }

    //Methods
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\n RSVP EMAIL: {_rsvpEmail}";
    }
}