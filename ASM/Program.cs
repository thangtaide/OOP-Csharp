using System;

namespace ASM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.ReadKey();
            Menu m = new Menu();
            m.MainMenu();
        }
    }
}
