using System;
class Square: Shape
{
    public override double Area()
    {
        return base.Side*base.Side;
    }
    public override double Area(double value)
    {
        return Math.Sqrt(value);
    }
}