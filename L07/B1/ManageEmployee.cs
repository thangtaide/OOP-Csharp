using System;
class ManageEmployee
{
    Employee[] employee = new Employee[20];
    string yn = "";
    private int number=0;
    public void update()
    {
        do
        {
            Employee e = new Employee();
            Console.Write("Enter name: ");
            e.Name = Console.ReadLine();
            employee[number] = e;
            number ++;
            Console.Write("Continue? (Y/N)");
            yn = Console.ReadLine();
        } while (yn.ToUpper() != "N");
    }
    public void display()
    {
        Console.WriteLine("Number of employee: "+number);
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine(employee[i].Name);
        }
    }
}