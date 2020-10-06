using System;
class Cube: Shape
{
    public override double Area()
    {
        return base.Side*base.Side*6;
    }
    public override double Area(double value)
    {
        return Math.Sqrt(value/6);
    }
}