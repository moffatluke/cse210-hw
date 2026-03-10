using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        while (true)
        {
            Console.Clear();
            goalManager.DisplayLevelStatus();
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();

            if (input == "1")
            {
                goalManager.CreateGoal();
            }
            else if (input == "2")
            {
                goalManager.ListGoals();
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine(); //wait before clearing
            }
            else if (input == "3")
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                goalManager.SaveGoals(fileName);
            }
            else if (input == "4")
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                goalManager.LoadGoals(fileName);
            }
            else if (input == "5")
            {
                goalManager.RecordEvent();
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();

            }
            else if (input == "6")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid command. Press Enter to try again.");
                Console.ReadLine();
            }
            Console.WriteLine();
        }
    }
}