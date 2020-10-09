using System;
using System.Collections;
using System.Collections.Generic;
namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            List<int> sorted = new List<int>(10);
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Nhập số thứ {0}: ", i+1);
                sorted.Add(Convert.ToInt32(Console.ReadLine()));
            }
            sorted.Sort();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} |",sorted[i]);
            }
        }
    }
}
