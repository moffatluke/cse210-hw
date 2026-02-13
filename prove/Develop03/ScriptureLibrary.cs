using System;
using System.Collections.Generic;
using System.IO;
//uses ideas from journal project for reading the file. 
public class ScriptureLibrary 
{
    //member attributes
    private List<Reference> _references;
    private List<string> _texts;
    private Random _random;

    public ScriptureLibrary(string fileName)
    {
        //use library text file for this project
        _random = new Random();
        ReadFromFile("library.txt");
    }

    private void ReadFromFile(string fileName)
    {
        Console.WriteLine("Reading the Scriptures...(You should too!)");

        _references = new List<Reference>();
        _texts = new List<string>();

        //same idea as the journal program
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            //unformat text to make it readable 
            string[] parts = line.Split('|'); 
            string book = parts[0];
            int chapter = int.Parse(parts[1]);
            int startVerse = int.Parse(parts[2]);
            string endVersePart = parts[3];
            string text = parts[4];

            Reference reference;

            //check verses
            if (endVersePart == "")
            {
                //send to the constuctor
                reference = new Reference(book, chapter, startVerse);
            }

            else
            {
                //send to the other constuctor if there are multiple verses
                reference = new Reference(book, chapter, startVerse, endVersePart);
            }

            //Add the data
            _references.Add(reference);
            _texts.Add(text);
        }
    }

    public Scripture GetRandom()
    {
        int index = _random.Next(_references.Count);
        return new Scripture(_references[index], _texts[index]);
    }
}
