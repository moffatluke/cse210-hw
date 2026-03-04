using System.ComponentModel.DataAnnotations;

public class Rectangle : Shape
{
    //Attributes
    private double _length;
    private double _width;
    
    //Consuctor
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }
    //Method to find the area for a square
    public override double GetArea()
    {
        return _length * _width;
    }
}