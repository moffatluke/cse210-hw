using System;
using System.Collections.Generic;
using System.IO; 

public class Journal
{
    //Attributes
    public List<Entry> _entries = new List<Entry>();
    //add entry method
    public void AddEntry(Entry userEntry)
    {
        _entries.Add(userEntry);
    }



    //save the entry to a file
    public void SaveFile(string fileName)
    {
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.Write(entry.FormatToFile());
            }
        }
    }



    //Loading a file
    public List<Entry> ReadFromFile(string fileName)
    {
        Console.WriteLine("Reading Enteries...");
        List<Entry> entries = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            //unformat file
            string [] parts = line.Split('|');
            string date = parts [0];
            string prompt = parts [1];
            string response = parts [2];
            Entry loadedFileEntry = new Entry(date, prompt, response);
        }
        return entries;
    }


//display method:
public void Display()
    {
        
    }

}