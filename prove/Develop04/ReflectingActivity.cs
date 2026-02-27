using System.Collections.Generic;
using System.Threading;

public class ReflectingActivity : Activity
{
    //attributes
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random = new Random();
    
    //Constuctors
        public ReflectingActivity ()
    : base(
        "Reflecting Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0) //This is to pass the information to the parent class
    {
        _prompts = new List<string> //list of the starting prompts
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string> //list of the follow up questions
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    //Methods
    public void Run()
    {
        DisplayStartingMessage();

        string prompt = _prompts[_random.Next(_prompts.Count)];

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue. ");
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience. ");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.Clear();


        // Start the timed question loop
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        int questionDuration = 6; //make sure it doesn't loop through with not enough time

        while (DateTime.Now < endTime)
        {
            double remaining = (endTime - DateTime.Now).TotalSeconds;
            if (remaining < questionDuration)
            {
                break;
            }
            string question = _questions[_random.Next(_questions.Count)];
            
            Console.Write($"> {question} ");
            ShowSpinner(questionDuration); // spinner pause, won't run past endTime
            Console.WriteLine();
        }
        Console.Clear();
        DisplayEndingMessage();
    }
}
