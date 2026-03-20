using System.Net.Security;

public class Address
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


    //Methods
    public bool IsInUSA()
    {
        return _country == "USA";
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}\n {_city}, {_stateOrProvince}\n {_country}";
    }
}