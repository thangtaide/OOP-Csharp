using System;
using System.IO;
namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            string choice;
            Menu m = new Menu();
            StudentsManager std = new StudentsManager();
            ClassManager cls = new ClassManager();
            
            do
            {
                m.menu();
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        Console.WriteLine("\n ...\nChúc các bạn sinh viên học tập tốt!");
                        break;
                    case "1":
                        string c1;
                        do
                        {
                            m.CN1();
                            c1 = Console.ReadLine();
                            switch (c1)
                            {
                                case "0":
                                    break;
                                case "1":
                                    m.CN11(std);
                                    m.Press();
                                    break;
                                case "2":
                                    m.CN12(std);
                                    break;
                                case "3":
                                    m.CN13(std);
                                    break;
                                default:
                                    m.ErrorPress();
                                    break;
                            }
                        } while (c1 != "0");
                        break;
                    case "2":
                        string c2;
                        do
                        {
                            m.CN2();
                            c2 = Console.ReadLine();
                            switch (c2)
                            {
                                case "0":
                                    break;
                                case "1":
                                    m.CN21(cls);
                                    m.Press();
                                    break;
                                case "2":
                                    m.CN22(cls);
                                    break;
                                case "3":
                                    m.CN23(cls);
                                    m.check(cls, std);
                                    m.Press();
                                    break;
                                default:
                                    m.ErrorPress();
                                    break;
                            }
                        } while (c2 != "0");
                        break;
                    case "3":
                        string c3;
                        do
                        {
                            m.CN3();
                            c3 = Console.ReadLine();
                            switch (c3)
                            {
                                case "0":
                                    break;
                                case "1":
                                    m.CN31(std);
                                    break;
                                case "2":
                                    m.CN32(std);
                                    m.Press();
                                    break;
                                case "3":
                                    m.CN33(std);
                                    m.Press();
                                    break;
                                default:
                                    m.ErrorPress();
                                    break;
                            }
                        } while (c3 != "0");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Nhập sai! Mời chọn lại!");
                        Console.ReadKey();
                        break;
                }
            } while (choice != "0");
            
        }
    }
}
