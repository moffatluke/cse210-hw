using System;
using System.Collections.Generic;
using System.Threading;

public class Activity //this is the base class
{
    //Attributes:

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
//Methods

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);

        Console.WriteLine("How long, in seconds, would you like for your session? ");
            int input = int.Parse(Console.ReadLine());
            
            if (input >= 0)
            {
                SetDuration(input);
            }
            
            else
            {
                Console.WriteLine("Please enter a number greater than 0.");
                _seconds = 0;
            }
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        
        Console.WriteLine($"You did {_name} for {_seconds}");
    }

    public void SetDuration(int input)
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

    public int GetDuration()
    {
        return _seconds;
    }

public void ShowSpinner(int seconds)
    {
        string[] frames = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(frames[i]);
            Thread.Sleep(200);
            Console.Write("\b");
            i = (i + 1) % frames.Length;
        }
        Console.Write(" ");
        Console.Write("\b");
    }
    public void ShowCountdown(int seconds)
    {
        //todo
    }
}