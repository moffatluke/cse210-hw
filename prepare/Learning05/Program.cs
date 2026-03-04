using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the Shape Learning Activity");

        //Create out shape objects
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6);
        shapes.Add (s3);
        

        //Now we can iterate through them to show them

        foreach (Shape s in shapes)
        {
            string color = s.GetColor(); //get the color for the shape
            double area = s.GetArea(); //get the area for that same shape

            Console.WriteLine($"The {color} shape has an area of {area}."); //display all shapes
        }
    }
}

