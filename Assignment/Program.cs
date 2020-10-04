using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("+--------------------------------------------------------------------+");
            DateTime d = new DateTime(1999,3,21);
            Console.WriteLine(d.ToShortDateString());
        }
    }
}
