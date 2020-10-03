using System;
class Circle
{
    double radius;
    string color;
    public double getRadius()
    {
        return radius;
    }
    public string getColor()
    {
        return color;
    }
    public double getArea()
    {
        return radius*radius*3.14;
    }
    public void setRadius(double r)
    {
        radius = r;
    }
    public void setColor(string c)
    {
        color = c;
    }
    public override string ToString()
    {
        return "\nRadius: "+radius+"\nColor: "+color+"\nArea: "+getArea();
    }
}