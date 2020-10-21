using System;
using System.Collections.Generic;
class Menu
{
    method m = new method();
    WorkingWithFile wwf = new WorkingWithFile();
    string[] _main = {"|             Chào mừng đến với VTC Academy           |","| 1. Quản lí danh sách sinh viên                      |",
    "| 2. Quản lí lớp học                                  |","| 3. Quản lí điểm thi                                 |",
    "| 0. Thoát chương trình                               |"};
    string[] _menu1 = {"|               Quản lí danh sách sinh viên           |","| 1. Xem danh sách sinh viên                          |",
    "| 2. Cập nhật thông tin sinh viên                     |","| 3. Thêm mới một sinh viên                           |",
    "| 0. Trở về menu chính                                |"};
    string[] _menu2 = {"|                 Quản lí lớp                         |","| 1. Xem danh sách lớp                                |",
    "| 2. Cập nhật thông tin lớp                           |","| 3. Thêm mới một lớp                                 |",
    "| 0. Trở về menu chính                                |"};
    string[] _menu3 = {"|               Quản lí điểm thi                      |","| 1. Nhập điểm thi                                    |",
    "| 2. Hiển thị điểm thi theo lớp                       |","| 3. Hiển thị điểm thi theo môn                       |",
    "| 0. Trở về menu chính                                |"};
    public void DisplayMenu(string[] menu)
    {
        Console.Clear();
        Console.WriteLine("+-----------------------------------------------------+");
        Console.WriteLine(menu[0]);
        Console.WriteLine("+-----------------------------------------------------+");
        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine(menu[i]);
        }
        Console.WriteLine("+-----------------------------------------------------+");
    }
    public string InpuChoice()
    {
        Console.Write("  Lựa chọn chức năng: ");
        return Console.ReadLine();
    }
    public void MainMenu()
    {
        DisplayMenu(_main);
        string choice = InpuChoice();
        switch (choice)
        {
            case "0":
                Console.WriteLine("\n ...\nChúc các bạn sinh viên học tập tốt!");
                break;
            case "1":
                Menu1();
                break;
            case "2":
                Menu2();
                break;
            case "3":
                Menu3();
                break;
            default:
                m.FalsePress(true);
                MainMenu();
                break;
        }
    }
    public void Menu1()
    {
        DisplayMenu(_menu1);
        StudentManager std = new StudentManager();
        string choice = InpuChoice();
        switch (choice)
        {
            case "0":
                MainMenu();
                break;
            case "1":
                Console.Clear();
                std.Display();
                m.Press();
                Menu1();
                break;
            case "2":
                Console.Clear();
                List<Student> s = wwf.GetFromFile<Student>("Student.json");
                Console.WriteLine("=========== Cập nhật thông tin sinh viên ============");
                if (s == null) Console.WriteLine("Danh sách trống! Mời nhập thông tin vào.");
                else
                {
                    do
                    {
                        std.UpdateFile(s);
                    } while (m.ContinueYN());
                }
                m.Press();
                Menu1();
                break;
            case "3":
                Console.Clear();
                do
                {
                    std.Insert();
                } while (m.ContinueYN());
                Menu1();
                break;
            default:
                m.FalsePress(true);
                Menu1();
                break;
        }
    }
    public void Menu2()
    {
        DisplayMenu(_menu2);
        string choice = InpuChoice();
        ClassManager cls = new ClassManager();
        switch (choice)
        {
            case "0":
                MainMenu();
                break;
            case "1":
                Console.Clear();
                cls.Display();
                m.Press();
                Menu2();
                break;
            case "2":
                Console.Clear();
                Console.WriteLine("=========== Cập nhật thông tin lớp ============");
                List<Class> c = wwf.GetFromFile<Class>("Class.json");
                if (c == null) Console.WriteLine("Danh sách trống! Mời nhập thông tin vào.");
                else
                {
                    do
                    {
                        cls.UpdateFile(c);
                    } while (m.ContinueYN());
                }
                m.Press();
                Menu2();
                break;
            case "3":
                Console.Clear();
                do
                {
                    cls.Insert();
                } while (m.ContinueYN());
                Menu2();
                break;
            default:
                m.FalsePress(true);
                Menu2();
                break;
        }
    }
    public void Menu3()
    {
        DisplayMenu(_menu3);
        SubjectManager sb = new SubjectManager();
        string choice = InpuChoice();
        switch (choice)
        {
            case "0":
                MainMenu();
                break;
            case "1":
                Console.Clear();
                List<Student> std = wwf.GetFromFile<Student>("Student.json");
                Console.WriteLine("================ Nhập điểm thi =================");
                if (std == null) Console.WriteLine("Danh sách trống! Mời nhập thông tin vào.");
                else
                {
                    do
                    {
                        sb.Insert(std);
                    } while (m.ContinueYN());
                }
                m.Press();
                Menu3();
                break;
            case "2":
                Console.Clear();
                List<Student> std1 = wwf.GetFromFile<Student>("Student.json");
                if (std1 == null) Console.WriteLine("Danh sách trống! Mời nhập thông tin vào.");
                else
                {
                    sb.DisplayByClass(std1);
                }
                m.Press();
                Menu3();
                break;
            case "3":
                Console.Clear();
                List<Student> std2 = wwf.GetFromFile<Student>("Student.json");
                if (std2 == null) Console.WriteLine("Danh sách trống! Mời nhập thông tin vào.");
                else
                {
                    sb.DisplayBySubject(std2);
                }
                m.Press();
                Menu3();
                break;
            default:
                m.FalsePress(true);
                Menu3();
                break;
        }
    }
}