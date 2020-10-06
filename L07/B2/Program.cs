using System;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("1. Square\n2. Cube\n");
            Square square = new Square();
            double s;
            Cube cube = new Cube();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Square");
                    Console.Write("Mời nhập cạnh: ");
                    square.Side = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Mời nhập diện tích: ");
                    s = square.Area(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Area: {0}\nSide: {1}", square.Area(), s);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Square");
                    Console.Write("Mời nhập cạnh: ");
                    cube.Side = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Mời nhập diện tích: ");
                    s = cube.Area(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Area: {0}\nSide: {1}", cube.Area(), s);
                    break;
                default:
                    break;
            }
        }
    }
}
