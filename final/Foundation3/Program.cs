using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Events:");
        Console.WriteLine();

        //Address
        Address addr1 = new Address("123 Main street", "New York City", "NY", "USA");
        Lecture l1 = new Lecture("Space out in Space", "Come learn about our solar system", "10/15/2027", "4;00 PM", addr1, "Tom Russell", 200);


        Address addr2 = new Address("1267 State St.", "Rexburg", "ID", "USA");
        Reception r1 = new Reception("Wedding", "Come join the celebration of these two wonderful people", "4/11/2026", "5-7 PM", addr2, "JohnDoe@gmail.com");

        Address addr3 = new Address("467 Park Place", "Vernon", "CA", "USA");
        OutdoorGathering o1 = new OutdoorGathering("Birthday Party", "Come celebrate with us!", "6/23/2028", "7:00 PM", addr3, "Cloudy");

        //Lecture
        Console.WriteLine("Lecture");
        Console.WriteLine(l1.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(l1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(l1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        //Reception
        Console.WriteLine("Reception");
        Console.WriteLine(r1.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(r1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(r1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        //Outdoor Gathering
        Console.WriteLine("Outdoor Gathering");
        Console.WriteLine(o1.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(o1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(o1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}