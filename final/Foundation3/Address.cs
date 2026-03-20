public class Address // Just used the address class from the other activity so I wouldn't have to rewrite
{
    //Attributes
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    //Constructor

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}\n {_city}, {_stateOrProvince}\n {_country}";
    }
}