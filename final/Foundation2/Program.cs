using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Order Summary");
        Console.WriteLine();
        
        //Address:
        Address addr1 = new Address("123 Main street", "New York", "NY", "USA");

        //Customer:
        Customer cust1 = new Customer("John Doe", addr1);

        //Order:
        Order order1 = new Order(cust1);

        //Add products
        order1.AddProduct(new Product("Xbox", "ID-526", 699.99, 2));
        order1.AddProduct(new Product("Playstation", "ID-888", 999.99, 2));
        order1.AddProduct(new Product("Steam Machine", "ID-987", 1199.99, 2));
        //print it all
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"{order1.GetTotalCost():C}"); 
        //The :C auto rounds it to 2 decimal places and adds the dollar sign. It is for formating currency. 
        //Seemed better than writing a lot more to do the same thing. 
        //Learned from a rabbit hole of stack overflow
        //https://stackoverflow.com/questions/20040619/what-does-1c-in-c-sharp-mean-when-found-inside-a-string
        //https://blog.stevex.net/string-formatting-in-csharp/

        Console.WriteLine();
        Console.WriteLine();


        //Address:
        Address addr2 = new Address("345 Colour St.", "London", "N/A", "England");

        //Customer:
        Customer cust2 = new Customer("Jane Doe", addr2);

        //Order:
        Order order2 = new Order(cust2);

        //Add products
        order2.AddProduct(new Product("Mop", "ID-897", 999.99, 2));
        order2.AddProduct(new Product("Vaccum", "ID-034", 699.99, 2));
        //print it all
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"{order2.GetTotalCost():C}");

        Console.WriteLine();
    }
}