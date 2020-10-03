using System;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Enter number of atomics: ");
            int count;
            count = Convert.ToInt32(Console.ReadLine());
            Atomic[] atomics = new Atomic[10];
            
            string number;
            bool check;
            for (int i = 0; i < count; i++)
            {
                Atomic temp = new Atomic();
                do
                {
                    Console.Write("\nEnter atomic number: ");
                    number = Console.ReadLine();
                    check = true;
                    for (int j = 0; j < number.Length; j++)
                    {
                        if (number[j] < 48 || number[j] > 57)
                        {
                            Console.WriteLine("Giá trị nhập sai, mời nhập lại!");
                            check = false;
                            break;
                        }
                    }
                } while (!check);
                temp.setNumber(Convert.ToInt32(number));
                Console.Write("Enter symbol: ");
                temp.setSymbol(Console.ReadLine());
                Console.Write("Enter full name: ");
                temp.setName(Console.ReadLine());
                Console.Write("Enter atomic weight: ");
                temp.setWeight(Convert.ToDouble(Console.ReadLine()));
                atomics[i] = temp;
            }
            Console.WriteLine("\nAtomic Information");
            Console.WriteLine("==========================");
            for(int i=0; i<count; i++)
            {
                atomics[i].display();
            }
        }
    }
}
