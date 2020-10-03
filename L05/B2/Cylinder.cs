using System;
class Cylinder: Circle
{
    double height;
    public void setHeight(double h)
    {
        height = h;
    }
    public double getVolume()
    {
        return base.getArea()*height;
    }
    public double getArea()
    {
        return getRadius()*6.28*height+2*base.getArea();
    }
    public override string ToString()
    {
        return "\nRadius: "+getRadius()+"\nHeight: "+height+"\nColor: "+getColor()+"\nArea: "+getArea()+"\nVolume: "+getVolume();
    }
}