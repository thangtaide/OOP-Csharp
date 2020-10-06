using System;
abstract class Shape
{
    private double side;
    public double Side
    {
        get { return side; }
        set { side = value; }
    }
    
    abstract public double Area();
    abstract public double Area(double value);
}