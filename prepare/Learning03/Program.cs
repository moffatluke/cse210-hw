using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Samples go here:");
        //here is where we can call the fraction class
        //make methods lets do 4 
        Fraction f1  = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());


        //sample output says to pass in 5 
        Fraction f2  = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3  = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4  = new Fraction(1, 3);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine("--------------------------------------------------------");


        //Loop time
        //need to get random numbers for the fractions
        Random random = new Random();

        //fraction #5 object
        Fraction f5 = new Fraction();

        //for-loop to loop through 20 random lines as requested
        for (int i =0; i<20; i++)
        {
            int topNum = random.Next(1, 11);
            int bottomNum = random.Next(1, 11);
            //pass in to class
            f5.SetTop(topNum);
            f5.Setbottom(bottomNum);
            //now display with loop counter for sanity
            Console.Write($"Fraction {i +1} | ");
            Console.Write($"String: {f5.GetFractionString()}");
            Console.WriteLine($"Decimal: {f5.GetDecimalValue()}");
        }

        Console.WriteLine("It worked!!");
    }
}