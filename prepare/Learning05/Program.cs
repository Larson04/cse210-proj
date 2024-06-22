using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");


        Square square = new Square("blue", 5);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circle("red", 2));
        shapes.Add(new Square("green", 4));
        shapes.Add(new Rectangle("yellow", 3, 6));
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}