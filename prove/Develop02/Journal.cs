using System;
using System.Collections.Generic;
using System.IO; 

public class Journal
{
    
    //Attributes
    public List<Entry> Entries = new List<Entry>();

    //add entry method
    public void AddEntry(Entry userEntry)
    {
        Entries.Add(userEntry);
    }
    public void Display()
    {
        //this is to display the current entries
    }


    //save the entry to a file

    public void SaveFile(string fileName)
    {
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in Entries)
            {
                outputFile.Write(entry.FormatToFile());
            }
        }
    }



    //Loading a file

    // public static List <Entry> ReadFromFile()
    // {
    //     Console.WriteLine("Reading Enteries...");
    //     List<Entry> entries = new List<Entry>()
    //     string filename = "Entry.txt";

    //     string[] lines = System.IO.ReadAllLines(filename);

    //     foreach (string entry in enteries)
    //     {
    //         Console.WriteLine(Entry);
    //     }
    //     return entries;
    // }


}