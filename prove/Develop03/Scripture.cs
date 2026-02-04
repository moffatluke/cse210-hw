using System.Runtime.InteropServices;
using System.Xml.Serialization;

public class Scripture
{
    //Private Attributes

    private string _reference;
    private List<string> _words = new List<string>();
    private string _random;

    //Constructors

    public Scripture(string reference, string text)
    {
        _reference = reference;
        text = words(_words.Split());

    }


    //Methods

    public void GetDisplayText(ScriptureLibrary verse);
    {
        //todo
        //Calls the reference and the words for the reference
        Reference.GetDisplayText();
        Word.GetDisplayText();
    }

    public void HideRandomWords(int count)
    {
        //todo

    }

    public void IsCompletelyHidden()
    {
        //Todo
    }

}
