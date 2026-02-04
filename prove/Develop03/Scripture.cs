using System.Xml.Serialization;

public class Scripture
{
    //Private Attributes

    private string _reference;
    private List<string> _words = new List<string>();
    private string _random;

    //Constructors
    
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        text = words(_words.Split());

    }


    //Methods

    public Scripture GetDisplayText()
    {
        //todo
    }

    public void Scripture HideRandomWords(int count)
    {
        //todo
        
    }

}
