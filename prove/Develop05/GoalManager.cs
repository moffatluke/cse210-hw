using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;

public class GoalManager
{
    //Attributes
    private List<Goal> _goals;
    private int _score;

    //Constuctor
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    //Methods
    public void CreateGoal()
    {
        //menu for the user
        Console.Clear();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        //Need to sanatize the input so they chose a valid option
        string choice;
        do
        {
            Console.Write("Which type of Goal would you like to create? ");
            choice = Console.ReadLine();
            if (choice != "1" && choice != "2" && choice != "3")
                Console.WriteLine("Not a valid command. Please try again.");
        } while (choice != "1" && choice != "2" && choice != "3");


        Console.WriteLine("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.WriteLine("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.WriteLine("What is the amount of points associated with this goal? ");
        int pointValue = int.Parse(Console.ReadLine());



    //Now we need to add them to the _goals
        if (choice == "1")
        {
            _goals.Add(new SimpleGoal(goalName, description, pointValue));
        }

        else if (choice == "2")
        {
            _goals.Add(new EternalGoal(goalName, description, pointValue));
        }

        else if (choice == "3") //checklist goal needs a little more information
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(goalName, description, pointValue, target, bonus));
        }
    }

    public void ListGoals() //show the current goals being worked on
    {
        Console.WriteLine("The goals are:");

        //loop through to get the goals
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}"); //the goal name and the description of it
        }
    }

    public void RecordEvent()
    {
        ListGoals(); //list the goals

        Console.WriteLine("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine()); //change the string to a number

        Goal selectedGoal = _goals[choice -1]; //select the goal form the list we made
        int earned = selectedGoal.RecordEvent();

        _score = _score + earned; //add to the score

        //display the data
        Console.WriteLine($"You earned {earned} points!");
        Console.WriteLine($"You now have {_score} points");
    }

    public void SaveGoals(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score); //line 1 will be the score

            foreach (Goal goal in _goals) //loop to save them all
            {
                outputFile.WriteLine(goal.GetStringRepresentation()); //uses the format method to clean it up in the Goals.cs
            }
        }
    }

    //Same Idea as the jounral but need to skip line 1 because it is the score of the user and have 3 options
    public void LoadGoals(string fileName)
        {
        
        string[] lines = System.IO.File.ReadAllLines(fileName);
        // List<string> lines = new List<string>();

        // foreach(var line in file)
        //     {
        //         lines.Add(line);
        //     }

        _score += int.Parse(lines[0]);
        string[] parts; 
        
        // pipe will be the delimiter so commas in names and descriptions don't break it
        for (int i = 1; i < lines.Length; i++)
        {
            parts = lines[i].Split('|'); 
            
            string goalType = parts[0];

            if (goalType == "SimpleGoal")
            {
                string goalName = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);

                _goals.Add(new SimpleGoal(goalName, description, points, isComplete));
            }
            else if (goalType == "EternalGoal")
            {
                string goalName = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                _goals.Add(new EternalGoal(goalName, description, points));
            }
            else if (goalType == "ChecklistGoal")
                {
                    string goalName = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    int amountCompleted = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);

                    _goals.Add(new ChecklistGoal(goalName, description, points, amountCompleted, target, bonus));

                }
        }
    }


    //CREATIVE PART:
    //I made a level system and have a progress bar for the points. So the level is based off of your total points
    //every 300 points is a level.
    //This runs to display your level and how many point needed for the next level with progress bar
    public void DisplayLevelStatus() 
    {
        //we need to do some math to calculate the level based off their points they have
        const int pointsPerLevel = 300; //This is a constant number for the level and will not change
        int level = (_score / pointsPerLevel) + 1; //find the current level
        int pointsIntoLevel = _score % pointsPerLevel; //how far you are into that level
        int pointsToNextLevel = pointsPerLevel - pointsIntoLevel; //how much you have to go to the next level

        int barWidth = 20;
        int filled = (int)((double)pointsIntoLevel / pointsPerLevel * barWidth); //see how full the bar is
        string bar = new string ('█', filled) + new string('_', barWidth - filled); //draw the bar

        Console.WriteLine($"You are level {level} and {pointsToNextLevel} points till next level"); //show level and how far they are
        Console.WriteLine($"[{bar}]"); //make the bar print so we can see it
    }
}