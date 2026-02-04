using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This will be the main loop");
        bool isRunning = true;
        string userInput = "";


    //main loop
    while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("Select a scripture to memorize:");
            Console.WriteLine("1. John 3:16");
            Console.WriteLine("2. Proverbs 3:5-6");
            Console.WriteLine("3. Random");
            Console.WriteLine("Type a number or type 'quit' to exit.");
            Console.WriteLine("> ");

            userInput = Console.ReadLine();

            //quit mechanic
            if (userInput == "quit")
            {
                Console.WriteLine("Bye for now!");
                isRunning = false;
                break;
            }

            if scripture

        }



    }
}