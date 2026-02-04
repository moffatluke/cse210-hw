using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This will be the main loop");
        bool keepRunning = true;




        //MAIN LOOP

        //CALL Chain
        /*
        scipture.GetDisplayText()
            - Calls reference.GetDisplayText()
            - Calls word.getDisplayText() for each word
        Calls scriptrue.HidRandomWords(n)
            - Calls word.Hide() on selected words
        Calls scripture.IsCompletelyHidden()
            - Calls word.IsHidden() for each word
        */

        while (keepRunning)
        {
            Console.Clear();
            Console.WriteLine(Scripture.GetDisplayText());
        }
    }
}