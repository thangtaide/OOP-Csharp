using System;

class Atomic
{
    int number;
    string name;
    string symbol;
    double weight;
    public void setNumber(int n)
    {
        number = n;
    }
    public void setName(string name)
    {
        this.name = name;
    }
    public string getName()
    {
        return this.name;
    }
    public string getSymbol()
    {
        return symbol;
    }
    public void setSymbol(string s)
    {
        symbol = s;
    }
    public void setWeight(double w)
    {
        weight = w;
    }
    public void display()
    {
        Console.WriteLine("{0} {1} {2} {3}",number, symbol, name, weight);
    }
    public int getNumber()
    {
        return number;
    }
    public double getWeight()
    {
        return weight;
    }
}