class Word
{
    //member variables
    private string _text;
    private bool _isHidden;

    //Constructors
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //Methods
    public void Hide()
    {
        //hid a word
        _isHidden = true;
    }


    public bool IsHidden()
        {
            //used to check if words are hidden
            return _isHidden;
        }


//main method of this class
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            //replaces characters with ______ by finding the length of the word
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }


}