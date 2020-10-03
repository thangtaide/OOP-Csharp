using System;
class Shape
{
    string color = "red";
    Boolean filled = true;
    public Shape()
    {

    }
    public Shape(string color, Boolean filled)
    {
        this.color = color;
        this.filled = filled;
    }
    public string getColor()
    {
        return color;
    }
    public void setColor(string color)
    {
        this.color = color;
    }
    public Boolean isFilled()
    {
        return filled;
    }
    public void setFilled(Boolean filled)
    {
        this.filled = filled;
    }
    public override string ToString()
    {
        return "\nA shape with color of "+color+" and "+(filled?"filled":"not filled");
    }
}