using System.Diagnostics.CodeAnalysis;

public class BreathingActivity : Activity
{
    //constructors
    public BreathingActivity ()
    : base(
        "Breathing Activity",
        "This activity will help you relax by guiding your breathing.", 0) //This is to pass the information to the parent class
    { 
    }

    //Methods
    public void Run()
    {
        DisplayStartingMessage(); //start like normal

        //set the numbers so there isn't a weird fast breath at the end or anything
        int inhaleSeconds = 5;
        int exhaleSeconds = 7;
        int cycleSeconds = inhaleSeconds + exhaleSeconds;

        int cycles = GetDuration() / cycleSeconds; //calc to see how many to do

        if (cycles <= 0) //check to see if there is enough time.
        {
            Console.WriteLine("Time too short for one full breath.");
            DisplayEndingMessage();
            return;
        }

        Console.Clear();
        Console.WriteLine("Breathe in for 5 seconds, out for 7 seconds.\n");


        for (int i = 0; i < cycles; i++) //for loop to iterate through the breathes
        {
            BreathIn(inhaleSeconds);
            BreathOut(exhaleSeconds);
        }

        DisplayEndingMessage(); //End like normal
    }
}

