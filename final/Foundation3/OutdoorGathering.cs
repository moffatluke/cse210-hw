public class OutdoorGathering : Event
{
    //Attributes
    private string _weatherForecast;

    //Constuctor
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast) :
    base("Outdoor Gathering", title, description, date, time, address) // Hard code Reception so it is the same everytime.
    {
        _weatherForecast = weatherForecast;
    }

    //methods
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\n Weather Forecast: {_weatherForecast}";
    }
}