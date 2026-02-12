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
            entries.Add(loadedFileEntry);
        }
        return entries;
    }

//display method:
public void Display()
    {
        Console.WriteLine("Displaying entries...");

        //if they have no entries
        if (_entries.Count ==0)
        {
            Console.WriteLine();
            Console.WriteLine("No entries to display.");
            Console.WriteLine();
            return;
        }

        //grab the correct data from the entries and display them
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date}");;
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"Response: {entry._response}");
            Console.WriteLine("--------------------");
            Console.WriteLine();
        }
    }

}