using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            string choice;
            StudentsManager std = new StudentsManager();
            do
            {
                Console.Clear();
                Console.WriteLine("+---------------------------------------------------------------------+");
                Console.WriteLine("|                    Chào mừng đến với VTC Academy                    |");
                Console.WriteLine("+---------------------------------------------------------------------+");
                Console.WriteLine("| 1. Quản lí danh sách sinh viên                                      |");
                Console.WriteLine("| 2. Quản lí lớp học                                                  |");
                Console.WriteLine("| 3. Quản lí điểm thi                                                 |");
                Console.WriteLine("+---------------------------------------------------------------------+");
                Console.Write("  Lựa chọn chức năng: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        Console.WriteLine("  Exit ...");
                        break;
                    case "1":
                        string c;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("+---------------------------------------------------------------------+");
                            Console.WriteLine("|                     Quản lí danh sách sinh viên                     |");
                            Console.WriteLine("+---------------------------------------------------------------------+");
                            Console.WriteLine("| 1. Xem danh sách sinh viên                                          |");
                            Console.WriteLine("| 2. Cập nhật thông tin sinh viên                                     |");
                            Console.WriteLine("| 3. Thêm một sinh viên                                               |");
                            Console.WriteLine("| 0. Trở về menu chính                                                |");
                            Console.WriteLine("+---------------------------------------------------------------------+");
                            Console.Write("  Lựa chọn chức năng: ");
                            c = Console.ReadLine();
                            switch (c)
                            {
                                case "0":
                                    break;
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("+----------------------------------------------------------------------+");
                                    Console.WriteLine("|                         Danh sách sinh viên                          |");
                                    Console.WriteLine("+----------------------------------------------------------------------+");
                                    Console.WriteLine("| Mã SV    | Họ và tên           | Địa chỉ         | Ngày Sinh | Lớp   |");
                                    Console.WriteLine("+----------------------------------------------------------------------+");
                                    std.display();
                                    Console.WriteLine("+----------------------------------------------------------------------+");
                                    Console.Write("Press any key to continue... ");
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    break;
                                case "3":
                                    Console.Clear();
                                    Console.WriteLine("===============Thêm mới một sinh viên================");
                                    std.add();
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Nhập sai! Mời chọn lại!");
                                    Console.ReadKey();
                                    break;
                            }
                        } while (c != "0");
                        break;
                    case "2":
                        break;
                    case "3":

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
