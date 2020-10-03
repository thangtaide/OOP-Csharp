using System;

namespace L06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangle");
            Console.WriteLine("====================");
            Rectangle rectangle = new Rectangle(6,4);
            Triangle triangle = new Triangle(6,4);
            Console.WriteLine(rectangle.ToString());
            Console.WriteLine("\nTriangle");
            Console.WriteLine("====================");
            Console.WriteLine(triangle.ToString());
        }
    }
}
