using System.Collections.Generic;

//this is the main librayr of all the scriptures for the program
//this has the refrence informaiton and the texts 
class ScriptureLibrary
{
    //Member varaibles:
    _scriptures = List<ScriptureOption> = new List<ScriptureOption>
    //_random : random

    private List<ScriptureOption> _scriptures = new List<ScriptureOption>
    {
        //John 3:16
        new ScriptureOption(
            new Reference ("John", 3, 16),
            "For God so loved the world that he gave his only begotten Son"
        ),

        //Proverbs 3:5-6
        new ScriptureOption(
            new Reference ("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart and lean not unto thine own understanding"
        )

        new ScriptureOption

    };
}