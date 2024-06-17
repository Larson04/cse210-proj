class Shpere : Circle
{
    public Cylinder(double r) : base(r) {    }

    public override double Area()
    {
        return base.Area() * 4;
    }
}