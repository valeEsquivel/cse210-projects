using System;

class Shape
{
    private string _color = "white";

    public Shape()
    {
    }

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea() {
        return -1;
    }
}