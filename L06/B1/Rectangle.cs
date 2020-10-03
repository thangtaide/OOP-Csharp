using System;
class Rectangle: Shape
{
    double length;
    double width;
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }
    public double Length
    {
        get { return length; }
        set { length = value; }
    }
    public double Width
    {
        get { return width; }
        set { width = value; }
    }
    public override double getArea()
    {
        return length*width;
    }
    public override string ToString()
    {
        return "Rectangle with length = "+length+", width = "+width+" and area = "+getArea();
    }
}