using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //calling all functions
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserFavNumber();
        int yearBorn = PromptUserBirthyear();
        int squaredUserNumber = SquareNumber(userNumber);
        int age = CalcAge(yearBorn);
        DisplayResult(userName, squaredUserNumber, age);

//Begining function to welcome them!! :))
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }
//Get name of user
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
//Get favorite numbr of user
        static int PromptUserFavNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favNumber = int.Parse(Console.ReadLine());
            return favNumber;
        }
//Get the users birth year
        static int PromptUserBirthyear()
        {
            Console.Write("Please enter the year you were born: ");
            int birthyear = int.Parse(Console.ReadLine());
            return birthyear;
        }

//Square the favorite number  
        static int SquareNumber(int userNumber)
        {
            return userNumber * userNumber;

        }

//Calculate the age of the user 
//This seemed easier and cleaner to do the math elseware and not in the DisplayResult function. 
        static int CalcAge(int yearBorn)
        {
            
            return 2026 - yearBorn;
        }        
        

//Display all informaiton back to the user. No math just print statements with passed in arguments.
        static void DisplayResult(string name, int squaredUserNumber, int age)
        {
            Console.WriteLine($"{name}, the square of your number is {squaredUserNumber}");
            Console.WriteLine($"{name}, you will turn {age} this year.");
        }
    }
}