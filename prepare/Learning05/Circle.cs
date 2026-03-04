using System.Runtime.Intrinsics.X86;

public class Circle : Shape
{
    //Attributes
    private double _radius;
    
    //Consuctor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    //Method to find the area for a square
    public override double GetArea()
    {
        return Math.Round(Math.PI * _radius * _radius , 2); //Round to two decimal places
    }
}