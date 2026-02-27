using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to mindfulness!");
        //while loop menu
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("> ");

            string input = Console.ReadLine();
            


            if (input == "1" || input == "breathing")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();

            }

            else if (input == "2" || input == "reflecting")
            {
                ReflectingActivity activity= new ReflectingActivity();
                activity.Run();
            }

            else if (input == "3" || input == "listing")
            {
                ListingActivity activity= new ListingActivity();
                activity.Run();
            }
            
            else if (input == "4" || input == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
                
            else
            {
                Console.WriteLine("Invalid command. Press Enter to try again.");
                Console.ReadLine();
            }
        }
    }
} 