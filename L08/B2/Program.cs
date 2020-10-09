using System;
using System.Collections.Generic;
namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Dao Van X", 21, 10));
            employees.Add(new Employee("Dao Van A", 23, 5));
            employees.Add(new Employee("Dao Van T", 32, 8.5));
            employees.Add(new Employee("Dao Van Z", 15, 9.5));
            employees.Add(new Employee("Dao Van E", 24, 7));
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            employees.Remove(employees.Find(x => x.Name.Contains(name)));
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(employees[i].ToString());
            }
        }
    }
}
