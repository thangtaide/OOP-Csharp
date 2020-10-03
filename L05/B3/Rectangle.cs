using System;
class Rectangle: Shape
{
    double width = 1.0;
    double length = 1.0;
    public Rectangle()
    {

    }
    public Rectangle(double width, double length)
    {
        this.length = length;
        this.width = width;
    }
    public Rectangle(double width, double length, string color, Boolean filled)
    {
        this.length = length;
        this.width = width;
        this.setFilled(filled);
        this.setColor(color);
    }
    public void setWidth(double width)
    {
        this.width = width;
    }
    public double getWidth()
    {
        return width;
    }
    public void setLength(double length)
    {
        this.length = length;
    }
    public double getLength()
    {
        return length;
    }
    public double getArea()
    {
        return length*width;
    }
    public double getPerimeter()
    {
        return 2*(length+width);
    }
    public override string ToString()
    {
        return "A Rectangle with width = "+width+", length = "+length+", area = "+getArea()
        +", perimeter = "+getPerimeter()+", which is a subclass of"+base.ToString();
    }
}