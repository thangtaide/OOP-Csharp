using System;
using Exceptions;
namespace B5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter salary: ");
            Salary salary = new Salary();
            double s = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter bonus: ");
            double b = Convert.ToDouble(Console.ReadLine());
            try
            {
                salary.press(s, b);
                Console.Clear();
                Console.WriteLine("Your name: " + name);
                Console.WriteLine(salary.ToString());
            }
            catch (LectureGetsLess e)
            {
                Console.WriteLine(e.Message);
            }
            catch (BonusIsMore e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
