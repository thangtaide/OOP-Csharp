using System;

class Rectangle
{

    int Width;
    int Height;
    public Rectangle()
    {

    }
    public Rectangle(int a, int b)
    {
        
    }
    public void display()
    {
        for (int j = 0; j < Width; j++)
        {
            for (int i = 0; i < Height; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
    public int getArea()
    {
        return Height * Width;
    }
    public void setHeight(int a)
    {
        Height = a;
    }
    public int getPerimeter()
    {
        return (Height + Width) * 2;
    }
    public int getHeight()
    {
        return Height;
    }
    public int getWidth()
    {
        return Width;
    }
    public void setWidth(int b)
    {
        Width = b;
    }
}