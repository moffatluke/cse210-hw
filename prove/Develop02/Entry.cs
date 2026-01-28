using System.Xml.Serialization;



public class Entry
{
    //This class will load/save the enties

    public string _date;
    public string _prompt;
    public string _response;

    public Entry(string prompt, string response)
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        _prompt = prompt;
        _response = response;
    }
    
    public string GetEntry()
    {
        return $"Date: {_date}, {_prompt}, {_response}";
    }


    public string FormatToFile()
    {
        string format = $"{_date}|{_prompt}|{_response}\n";
        return format;
    }
}
