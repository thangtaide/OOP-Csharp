using System;

namespace B3
{
    class ShapeDemo
    {
        static void Main(string[] args)
        {
            string choice, Choice;
            do
            {
                Console.Clear();
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Shape");
                Console.WriteLine("2. Circle");
                Console.WriteLine("3. Rectangle");
                Console.WriteLine("4. Square");
                Console.Write("Choice: ");
                Choice = Console.ReadLine();
                switch (Choice)
                {
                    case "0":
                        break;
                    case "1":
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Shape\n");
                            Console.WriteLine("0. Exit");
                            Console.WriteLine("1. Default values");
                            Console.WriteLine("2. Different values");
                            Console.Write("Choice: ");
                            choice = Console.ReadLine();
                            switch (choice)
                            {
                                case "0":
                                    break;
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("Default values");
                                    Shape s = new Shape("green", true);
                                    Console.WriteLine(s.ToString());
                                    Console.Write("\nPress any key to continue ...");
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    Console.Clear();
                                    Console.WriteLine("Different values");
                                    Shape shape = new Shape();
                                    Console.Write("Enter color: ");
                                    shape.setColor(Console.ReadLine());
                                    Console.Write("Filled? (true/false): ");
                                    shape.setFilled(Convert.ToBoolean(Console.ReadLine()));
                                    Console.WriteLine(shape.ToString());
                                    Console.Write("\nPress any key to continue ...");
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("\nPress failed, try again");
                                    Console.ReadKey();
                                    break;
                            }
                        } while (choice != "0");
                        break;
                    case "2":
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Circle\n");
                            Console.WriteLine("0. Exit");
                            Console.WriteLine("1. Default values");
                            Console.WriteLine("2. Different values");
                            Console.Write("Choice: ");
                            choice = Console.ReadLine();
                            switch (choice)
                            {
                                case "0":
                                    break;
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("Default values");
                                    Circle c = new Circle();
                                    Console.WriteLine(c.ToString());
                                    Console.Write("\nPress any key to continue ...");
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    Console.Clear();
                                    Console.WriteLine("Different values");
                                    Circle circle = new Circle();
                                    Console.Write("Enter color: ");
                                    circle.setColor(Console.ReadLine());
                                    Console.Write("Filled? (true/false): ");
                                    circle.setFilled(Convert.ToBoolean(Console.ReadLine()));
                                    Console.Write("Enter radius: ");
                                    circle.setRadius(Convert.ToDouble(Console.ReadLine()));
                                    Console.WriteLine(circle.ToString());
                                    Console.Write("\nPress any key to continue ...");
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("\nPress failed, try again");
                                    Console.ReadKey();
                                    break;
                            }
                        } while (choice != "0");
                        break;
                    case "3":
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Rectangle\n");
                            Console.WriteLine("0. Exit");
                            Console.WriteLine("1. Default values");
                            Console.WriteLine("2. Different values");
                            Console.Write("Choice: ");
                            choice = Console.ReadLine();
                            switch (choice)
                            {
                                case "0":
                                    break;
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("Default values");
                                    Rectangle r = new Rectangle();
                                    Console.WriteLine(r.ToString());
                                    Console.Write("\nPress any key to continue ...");
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    Console.Clear();
                                    Console.WriteLine("Different values");
                                    Rectangle rectangle = new Rectangle();
                                    Console.Write("Enter color: ");
                                    rectangle.setColor(Console.ReadLine());
                                    Console.Write("Filled? (true/false): ");
                                    rectangle.setFilled(Convert.ToBoolean(Console.ReadLine()));
                                    Console.Write("Enter length: ");
                                    rectangle.setLength(Convert.ToDouble(Console.ReadLine()));
                                    Console.Write("Enter width: ");
                                    rectangle.setWidth(Convert.ToDouble(Console.ReadLine()));
                                    Console.WriteLine(rectangle.ToString());
                                    Console.Write("\nPress any key to continue ...");
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("\nPress failed, try again");
                                    Console.ReadKey();
                                    break;
                            }
                        } while (choice != "0");
                        break;
                    case "4":
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Square\n");
                            Console.WriteLine("0. Exit");
                            Console.WriteLine("1. Default values");
                            Console.WriteLine("2. Different values");
                            Console.Write("Choice: ");
                            choice = Console.ReadLine();
                            switch (choice)
                            {
                                case "0":
                                    break;
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("Default values");
                                    Square s = new Square();
                                    Console.WriteLine(s.ToString());
                                    Console.Write("\nPress any key to continue ...");
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    Console.Clear();
                                    Console.WriteLine("Different values");
                                    Square square = new Square();
                                    Console.Write("Enter color: ");
                                    square.setColor(Console.ReadLine());
                                    Console.Write("Filled? (true/false): ");
                                    square.setFilled(Convert.ToBoolean(Console.ReadLine()));
                                    Console.Write("Enter side: ");
                                    square.setSide(Convert.ToDouble(Console.ReadLine()));
                                    Console.WriteLine(square.ToString());
                                    Console.Write("\nPress any key to continue ...");
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("\nPress failed, try again");
                                    Console.ReadKey();
                                    break;
                            }
                        } while (choice != "0");
                        break;
                    default:
                        Console.WriteLine("\nPress failed, try again");
                        Console.ReadKey();
                        break;
                }

            } while (Choice != "0");
        }
    }
}
