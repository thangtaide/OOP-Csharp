using System;
class Square: Rectangle
{
    public Square()
    {

    }
    public Square(double side)
    {
        setLength(side);
        setWidth(side);
    }
    public Square(double side, string color, Boolean filled)
    {
        setLength(side);
        setWidth(side);
        setColor(color);
        setFilled(filled);
    }
    public void setSide(double side)
    {
        setLength(side);
        setWidth(side);
    }
    public double getSide()
    {
        return getLength();
    }
}