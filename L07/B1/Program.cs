using System;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            ManageEmployee manage= new ManageEmployee();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            manage.update();
            Console.Clear();
            manage.display();
        }
    }
}
