class Cylinder : Circle
{
    private double _height;
    public Cylinder(double r, double h) : base(r)
    {
        _height = h;
    }

    public override double Area()
    {
        return base.Area() * 2 + 2 * Math.PI * _radius * _height;
    }
    
}