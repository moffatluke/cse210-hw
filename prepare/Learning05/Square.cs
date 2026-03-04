public class Square : Shape
{
    //Attributes
    private double _side; //It needs to have sides
    
    //Consuctor
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
    //Method to find the area for a square
    public override double GetArea()
    {
        return _side * _side;
    }
}