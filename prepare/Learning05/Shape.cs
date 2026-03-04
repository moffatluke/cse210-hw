using System.Drawing;

public abstract class Shape //Base class for all shapes
{
    //Attibutes
    private string _color;

    //Constuctors
    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public abstract double GetArea(); //Every shape has a area
}