using System;
using System.Collections.Generic;

public class Scripture
{
    //Private Attributes

    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    //Constructor
    public Scripture (Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        //Need to split the text into sperate strings to hid them later. 
        //remove empry entries are to help with double spaces.
        string[] parts = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        //add the words
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }


        //Now rebuild the line with the hidden logic. 
        string wordsText = string.Join(" ", displayWords);
        return $"{_reference.GetDisplayText()} {wordsText}";
    }



    //check to see if eveything is hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
    //This will hid the words. Can set the amount being hidden at a time by passing in a number
    public void HideRandomWords(int count)
    {
        //use the for loop to iterate through the words
        for (int i = 0; i < count; i++)
        {
            //gets the total number of the words
            int index = _random.Next(_words.Count);
            //cals hide method to actully hide the words
            _words[index].Hide();
        }
    }
}