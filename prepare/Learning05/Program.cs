using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            // Notice that all shapes have a GetColor method from the base class
            string color = s.GetColor();

            // Notice that all shapes have a GetArea method, but the behavior is
            // different for each type of shape
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }



        // Square square = new Square();
        // Console.WriteLine("Square area: " + square.GetArea());
        // Console.WriteLine("Square color: " + square.GetColor());

        // Rectangule rectangule = new Rectangule();
        // Console.WriteLine("Rectangule area: " + rectangule.GetArea());

        // Circle circle = new Circle();
        // Console.WriteLine("Circle area: " + circle.GetArea());
    }
}