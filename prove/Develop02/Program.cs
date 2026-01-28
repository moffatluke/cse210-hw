using System;

public class Program
{
    static void Main(string[] args)
    {
//main loop that will determine the functions of the program

        string userInput = "";
        //make journal
        Journal journal = new Journal();

        while ((userInput != "5") || (userInput != "Quit") || (userInput != "5."))
        {
            Console.WriteLine("Welcome to the Journal!");
            Console.WriteLine("_______________________");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine ("Please enter a command: ");
            Console.WriteLine("_______________________");
            Console.WriteLine("> ");
            userInput = Console.ReadLine();

            if ((userInput == "1") || (userInput == "1.") || (userInput == "Write") || (userInput == "write"))
            {
                //make object and then display prompt. 
                PromptGenerator gen = new PromptGenerator();
                string prompt = gen.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.WriteLine("> ");
                string userinputresponse = Console.ReadLine();
                Entry entry1 = new Entry(prompt, userinputresponse);
                journal.AddEntry(entry1);

            }
            else if ((userInput == "2") || (userInput == "2.") || (userInput == "Display") || (userInput == "display" ))
            {
                //display all the entries i
            }
            else if ((userInput == "3") || (userInput == "3.") || (userInput == "Load") || (userInput == "load" ))
            {
                //load file

            }
            else if ((userInput == "4") || (userInput == "4.") || (userInput == "Save") || (userInput == "save" ))
            {
                //Save file
                Console.WriteLine("Enter name for your file:");
                Console.Write("> ");
                string fileName = Console.ReadLine();
                journal.SaveFile(fileName);

                
            }
            else if ((userInput == "5") || (userInput == "Quit") || (userInput == "5."))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid command. Please try again");
            }
        }
    }
}