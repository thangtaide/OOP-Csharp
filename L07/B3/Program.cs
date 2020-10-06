using System;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Mời nhập ngày: ");
            string a = Console.ReadLine();
            DayOfWeek day = new DayOfWeek();
            Console.WriteLine(day.Days(a));
        }
    }
}
