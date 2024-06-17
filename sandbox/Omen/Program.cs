namespace Omen;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        List<Roundshape> shapes = new List<Roundshape>();
        shapes.Add(new Circle(1.0));
        shapes.Add(new Cylinder(1.0, 2.0));
        shapes.Add(new Sphere(1.0));

        foreach (Roundshape shape in shapes)
        {
            Console.WriteLine(shape.Area());
        }
    }
}
