using System;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Employee emp = new Employee();
            emp.setName();
            Console.Write("Address: ");
            emp.setAddress(Console.ReadLine());
            Console.Write("Sin: ");
            emp.setSin(long.Parse(Console.ReadLine()));
            Console.Write("Salary: ");
            emp.setSalary(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Bonus: ");
            emp.setBonus(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("========================");
            Console.WriteLine(emp.ToString());
        }
    }
}
