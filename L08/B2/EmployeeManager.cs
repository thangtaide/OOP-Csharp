using System;
using System.Collections.Generic;
using System.Collections;

class EmployeeManager
{
    List<Employee> employees = new List<Employee>();
    public void add()
    {
        Employee e = new Employee();
        Console.Write("Enter name: ");
        e.Name = Console.ReadLine();
        Console.Write("Enter age: ");
        e.Age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter salary: ");
        e.Salary = Convert.ToDouble(Console.ReadLine());
        employees.Add(e);
    }
    public void delete()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        employees.Remove(employees.Find(x => x.Name.Contains(name)));
    }
    public override string ToString()
    {
        return base.ToString();
    }
}