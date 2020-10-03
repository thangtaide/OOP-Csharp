using System;
class Circle: Shape
{
    double radius = 1.0;
    public Circle()
    {

    }
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public Circle(double radius, string color, Boolean filled)
    {
        this.radius = radius;
        this.setColor(color);
        this.setFilled(filled);
    }
    public double getRadius()
    {
        return radius;
    }
    public void setRadius(double radius)
    {
        this.radius = radius;
    }
    public double getArea()
    {
        return radius*radius*3.14;
    }
    public double getPerimeter()
    {
        return radius*6.28;
    }
    public override string ToString()
    {
        return "A Circle with radius = "+radius+", area = "+getArea()+", perimeter = "
        +getPerimeter()+", which is a subclass of"+base.ToString();
    }
}