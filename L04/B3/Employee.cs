using System;

class Employee
{
    string first;
    string last;
    string add;
    long sin;
    double salary;
    double bonus;
    public void setName()
    {
        Console.Write("First name: ");
        first = Console.ReadLine();
        Console.Write("Last name: ");
        last = Console.ReadLine();
    }
    public void setAddress(string a)
    {
        add = a;
    }
    public void setSin(long s)
    {
        sin = s;
    }
    public void setSalary(double b)
    {
        salary = b;
    }
    public void setBonus(int p)
    {
        bonus = salary * p/100;
    }
    public override string ToString()
    {
        return"Name: "+last+" "+first+"\nAddress: "+add+"\nSin: "+sin+"\nSalary: "+salary+"\nBonus: "+bonus;
    }
}