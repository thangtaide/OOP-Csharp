using System;

namespace Lap04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Rectangle rec = new Rectangle();
            Console.Write("Mời nhập height: ");
            rec.setHeight(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Mời nhập width: ");
            rec.setWidth(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Chu vi hình chữ nhật là: " + rec.getPerimeter());
            Console.WriteLine("Diện tích hình chữ nhật là: " + rec.getArea());
            rec.display();
        }
    }
}
