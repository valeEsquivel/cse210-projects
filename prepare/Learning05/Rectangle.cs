using System;

class Rectangle: Shape
{
    private double _length  = 0;
    private double _width  = 0;

    public Rectangle()
    {
    }

    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea() {
        return _length * _width;
    }
}