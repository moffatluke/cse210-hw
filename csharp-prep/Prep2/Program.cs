using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter grade ");
        string userAnswer = Console.ReadLine();
        int score = int.Parse(userAnswer);
        string letter = "";

        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (score >= 70)
        {
            Console.WriteLine("You passed!!! CONGRADULATIONS!!");
        }
    }
}