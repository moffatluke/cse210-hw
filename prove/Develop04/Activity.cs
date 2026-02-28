using System;
using System.Collections.Generic;
using System.Threading;

public class Activity //this is the base class
{
    //Attributes: -------------------------------------------
    private string _name;
    private string _description;
    private int _seconds;

//Constuctors:----------------------------------------------------
public Activity()
{
    _name = "";
    _description = "";
    _seconds = 0;
}

public Activity(string name, string description, int seconds)
    {
        _name = name;
        _description = description;
        _seconds = seconds;
        SetDuration(seconds);
    }
//Methods: ---------------------------------------------------------------

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);

        Console.Write("How long, in seconds, would you like for your session? ");
            int input = int.Parse(Console.ReadLine());
            
            if (input >= 0)
            {
                SetDuration(input);
            }

            else
            {
                Console.WriteLine("Please enter a number greater than 0.");
                _seconds = 0; //make sure it a valid number
            }

            Console.Clear();
            Console.Write("Get ready... ");
            ShowSpinner(3);
            Console.Clear();
    }


    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        ShowSpinner(2);
        Console.WriteLine($"You did {_name} for {_seconds} seconds!"); //display activity and duration
        ShowSpinner(4);
    }


    public void SetDuration(int input) //setter
    {
        //make sure that duration always works if not set to 30 seconds
        if (input > 0)
        {
            _seconds = input;
        }
        else
        {
            _seconds = 30;
        }
    }


    public int GetDuration() // Getter
    {
        return _seconds;
    }


    public void ShowSpinner(int seconds)
    {   
        //arry of the charcters used
        string[] frames = { "|", "/", "-", "\\" }; // '\\' is used to show a single
        DateTime endTime = DateTime.Now.AddSeconds(seconds); //calc when it should stop
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(frames[i]);
            Thread.Sleep(200);
            Console.Write("\b"); //backspace
            i = (i + 1) % frames.Length;
        }
        Console.Write(" ");
        Console.Write("\b");
    }
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i> 0; i--) //Iterate through the seconds
        {
            Console.Write(i);
            Thread.Sleep(1000); //1 second wait time
            Console.Write("\b \b"); //erase number before repeating the loop
        }
    }


    public void PauseUntil(DateTime endTime)
    {
        int secondsToWait = 6; //sets the wait to be there

        double remaining = (endTime - DateTime.Now).TotalSeconds;
        if (remaining <= 0) return;
        int actualWait = (int)Math.Min(secondsToWait, remaining);

        ShowSpinner(actualWait);
        Console.WriteLine();
    }


    //Creative Loader Animation:
    //I wanted a bar that ran next to the breathe words for a more fluid animation
    //I went to microsoft to see what they had. Had a lot of info about the Console.
    //How to change colors and other things. I had to google the white space bar for the green bar animation
    //https://learn.microsoft.com/en-us/dotnet/api/system.console?view=net-10.0
    //I also went to stack overflow for some ideas of how to make a good progressbar
    //Its like the ... animation in the video but with some extra steps.
    //https://stackoverflow.com/questions/24918768/progress-bar-in-console-application
    //basicly here is the idea:

    //Starts with an empty bar.
    //Adds one block each iteration.
    //Overwrites the same line each time.
    //Waits a small amount of time between updates.
    //Stops when the bar is fully filled.
    //The calls the breathe out methods and does the same thing in reverse
    //Makes sure there is time to do a breathe in the activity duration in the child class


    //the lines are documented below.

//the IRON LUNG

public void BreathIn(int seconds)
    {   
        int width = 30;  //fixed size of the bar
        ConsoleColor previous = Console.ForegroundColor; //save current color white so we can undo it later
        Console.ForegroundColor = ConsoleColor.Green;    //set green for the words and bar

        for (int i = 0; i <= width; i++) //i is how many blocks are filled. Stops at 30
        {
            string bar = new string('█', i).PadRight(width); //make the string for █ and repeats for the i. Pad right adds it on the right till it gets to 30
            Console.Write("\rBreathe in...  " + bar); // prints the animation adn replaces the previous version so it looks like the same line
            Thread.Sleep(seconds * 1000 / width); //makes sure it is timed well. divids the seconds by the width
        }

        Console.ForegroundColor = previous;  // restore color back to white text
        Console.WriteLine("\n"); //
    }
    public void BreathOut(int seconds)
    {   
        int width = 30;  // fixed size
        ConsoleColor previous = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Green;

        for (int i = width; i >= 0; i--) //same idea but in reverse (start with the width then move down).
        {
            string bar = new string('█', i).PadRight(width); //subtract the right █ instead of adding it
            Console.Write("\rBreathe out... " + bar);
            Thread.Sleep(seconds * 1000 / width);
        }

        Console.ForegroundColor = previous;
        Console.WriteLine("\n");
    }
}