using System;

namespace B2
{
    class TestCylinder
    {
        static void Main(string[] args)
        {
            Cylinder c = new Cylinder();
            Console.Write("Enter radius: ");
            c.setRadius(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Enter height: ");
            c.setHeight(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Enter color: ");
            c.setColor(Console.ReadLine());
            Console.WriteLine("\nCylinder information");
            Console.Write("==========================");
            Console.WriteLine(c.ToString());
        }
    }
}
