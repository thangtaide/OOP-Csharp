using System;
class Triangle: Shape
{
    double Base;
    double height;
    public Triangle(double Base, double height)
    {
        this.Base = Base;
        this.height = height;
    }
    public double Height
    {
        get { return height; }
        set { height = value; }
    }
    public double BASE
    {
        get { return Base; }
        set { Base = value; }
    }
    public override double getArea()
    {
        return Base*height/2;
    }
    public override string ToString()
    {
        return "Triangle with base = "+Base+", height = "+height+" and area = "+getArea();
    }
}