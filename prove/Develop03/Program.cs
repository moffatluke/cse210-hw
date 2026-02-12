using System;

class Program
{
    static void Main(string[] args)
    {
        //setting new libraries
        ScriptureLibrary library = new ScriptureLibrary("library.txt");
        //get random method being called to get a random scripture
        Scripture scripture = library.GetRandom();
        //set the program to running
        bool running = true;

        while (running)
        {
            // If the current scripture is fully hidden, load a new one
            if (scripture.IsCompletelyHidden())
            {
                scripture = library.GetRandom();
                continue;
            }
            

            Console.Clear();
            //display the text
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to hide words or type 'quit' to exit: ");
            //clean the input so it 'quit' always works
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
            {
                //turn off the program
                running = false;
            }
            else
            {
                //pressing enter hides 3 words. We can change the difficulty by changing the counter
                scripture.HideRandomWords(3);
            }
        }
    }
}
