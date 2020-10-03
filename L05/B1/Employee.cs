using System;
class Employee : Person
{
    double salary;
    DateTime dateHired = new DateTime();
    public Employee()
    {

    }
    public Employee(string n, string a, int p, string e, int o, double s, DateTime d)
    {
        setAddress(a);
        setPhone(p);
        setName(n);
        setEmail(e);
        salary = s;
        dateHired = d;
    }
    public double getSalary()
    {
        return salary;
    }
    public String getDateHired()
    {
        return dateHired.Day + "/" + dateHired.Month + "/" + dateHired.Year;
    }
    public void setSalary(double s)
    {
        salary = s;
    }
    public void setDateHired(int y, int m, int d)
    {
        dateHired = new DateTime(y, m, d);
    }
    // public abstract void CalculateBonus();
    // public abstract void CalculateVacation();
    public override string ToString()
    {
        return base.ToString() + "\nSalary: " + salary + "Date hired: " + getDateHired();
    }
}