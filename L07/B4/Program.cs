using System;
using Order;
using Customer;

namespace B4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cus customer = new Cus();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Enter name: ");
            customer.name = Console.ReadLine();
            int a;
            Console.Clear();
            Console.WriteLine("1. Grocery Items\n2. Bakery Products");
            Console.Write("Enter your choice: ");
            a = Convert.ToInt32(Console.ReadLine());
            switch(a)
            {
                case 1:
                Grocery grocery = new Grocery();
                Console.WriteLine("Your name: "+customer.name);
                Console.WriteLine(grocery.ToString());
                break;
                case 2:
                Bakery bakery = new Bakery();
                Console.WriteLine("Your name: "+customer.name);
                Console.WriteLine(bakery.ToString());
                break;
                default:
                break;
            }
        }
    }
}
