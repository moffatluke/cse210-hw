public abstract class Event
{
    //Member Variables
    private string _type;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;


//Constuctor

    public Event(string type, string title, string description, string date, string time, Address address)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

//Methods

    //Standard details - Lists the title, description, date, time, and address.
    public string GetStandardDetails()
    {
        return $"Title: {_title}\n Description: {_description}\n Date: {_date}, {_time}\n \n{_address.GetFullAddress()}";
    }


    //Short description - Lists the type of event, title, and the date.
    public string GetShortDescription()
    {
        return $"Event type: {_type} \n Title: {_title}\n Date: {_date}";
    }

    //Full details - Lists all of the above, plus type of event and information specific to that event type. 
    // For lectures, this includes the speaker name and capacity. 
    // For receptions this includes an email for RSVP. 
    // For outdoor gatherings, this includes a statement of the weather.
    public abstract string GetFullDetails(); //Brother Tuck said it was fine to Polymorphism for this method.
}