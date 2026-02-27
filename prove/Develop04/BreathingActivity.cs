using System.Diagnostics.CodeAnalysis;

public class BreathingActivity : Activity
{
    //attributes


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
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        
        // main body
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(4);
            Console.WriteLine();
            Console.WriteLine(); //a bit more spacing

            Console.Write("Breathe out... ");
            ShowCountdown(6);
            Console.WriteLine();
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }
}

