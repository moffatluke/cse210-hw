using System;

public class Fraction
{
    //attributes
    private int _top;
    private int _bottom;

    //CONSTRUCTORS:


    //user input constuctor
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //whole number
    public Fraction(int num)
    {
        _top = num;
        _bottom = 1;
    }

    //defalt
    public Fraction()
    {
        _top =1;
        _bottom =1;
    }
//________________________________________________________________


//Setters

public void SetTop(int top)
    {
        _top = top;
    }

    public void Setbottom(int bottom)
    {
        if (_bottom !=0)
        {
            _bottom = bottom;
        }

        else
        {
            _bottom = 1;
        }
    }



//GETTERS

    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }


    //Methods to do the 'math'

    public string GetFractionString()
    {
        string input = $"{_top}/{_bottom}";
        return input;
    }



    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

}



