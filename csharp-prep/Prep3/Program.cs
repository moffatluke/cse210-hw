using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        /*These comments are for me to think through this
        Basicly this is the starting block that
        makes the number and saves it as a varaible
        */
        Random numberGenerator = new Random();
        int magicNumber = numberGenerator.Next(1, 101);



        /*
        Now I need the to create the loop 
        - prompts the user for a guess
        - checks it agains the set magic number
        - compares the values and writes a line to the user
        - then asks the user to guess again
        - if the number is correct it displays a congrats message
        */
        //declare the guess variable and set it 
        int guess = -1;

        do
        { 

            Console.Write("Guess the Magic Number? ");
            guess = int.Parse(Console.ReadLine()); 

            if (guess >= magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess <= magicNumber)
            {
            Console.WriteLine("Higher");
            }
            
        }
        while (guess != magicNumber);
        Console.WriteLine("You guessed it!");
    }
}