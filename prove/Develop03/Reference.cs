using System.Collections.Concurrent;

public class Reference
{

    //This class is to store the scripture found and handle the verse range
    //Member Variables
    private string _book;
    private int _startVerse;
    private int _endVerse;
    private int _chapter;

    //CONSTRUCTORS:
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;   
    }

    //other one for multiple verses
    public Reference (string book, int chapter, int startVerse, string endVerse) //includes a ending verse
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = int.Parse(endVerse);
    }

//Methods
    public string GetDisplayText()
    {
        //if statements to check to see if it is multiple verses or just one
        if (_startVerse == _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }

        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}