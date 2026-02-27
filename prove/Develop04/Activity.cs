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
}