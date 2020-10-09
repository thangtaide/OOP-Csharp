using System;
class Employee
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private int age;
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    private double salary;
    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }
    public override string ToString()
    {
        return "Name: "+name+"\nAge: "+age+"\nSalary: "+salary;
    }
    public Employee(string name, int age, double salary)
    {
        this.name=name;
        this.age=age;
        this.salary=salary;
    }
    public Employee()
    {
        
    }
}