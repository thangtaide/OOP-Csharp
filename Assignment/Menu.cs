using System;
class Menu
{
    public void menu()
    {
        Console.Clear();
        Console.WriteLine("+---------------------------------------------------------------------+");
        Console.WriteLine("|                    Chào mừng đến với VTC Academy                    |");
        Console.WriteLine("+---------------------------------------------------------------------+");
        Console.WriteLine("| 1. Quản lí danh sách sinh viên                                      |");
        Console.WriteLine("| 2. Quản lí lớp học                                                  |");
        Console.WriteLine("| 3. Quản lí điểm thi                                                 |");
        Console.WriteLine("| 0. Thoát chương trình                                               |");
        Console.WriteLine("+---------------------------------------------------------------------+");
        Console.Write("  Lựa chọn chức năng: ");
    }
    public void CN1()
    {
        Console.Clear();
        Console.WriteLine("+-----------------------------------------------------------+");
        Console.WriteLine("|               Quản lí danh sách sinh viên                 |");
        Console.WriteLine("+-----------------------------------------------------------+");
        Console.WriteLine("| 1. Xem danh sách sinh viên                                |");
        Console.WriteLine("| 2. Cập nhật thông tin sinh viên                           |");
        Console.WriteLine("| 3. Thêm mới một sinh viên                                 |");
        Console.WriteLine("| 0. Trở về menu chính                                      |");
        Console.WriteLine("+-----------------------------------------------------------+");
        Console.Write("  Lựa chọn chức năng: ");
    }
    public void Press()
    {
        Console.Write("Press any key to continue... ");
        Console.ReadKey();
    }
    public void ErrorPress()
    {
        Console.WriteLine("Nhập sai! Mời chọn lại!");
        Console.ReadKey();
    }
    public void CN11(StudentsManager std)
    {
        Console.Clear();
        if (std.count == 0) Console.WriteLine("Danh sách sinh viên trống!");
        else
        {
            Console.WriteLine("+--------------------------------------------------------------------------+");
            Console.WriteLine("|                         Danh sách sinh viên                              |");
            Console.WriteLine("+--------------------------------------------------------------------------+");
            Console.WriteLine("| Mã SV    | Họ và tên            | Địa chỉ            | Ngày Sinh | Lớp   |");
            Console.WriteLine("+--------------------------------------------------------------------------+");
            std.display();
            Console.WriteLine("+--------------------------------------------------------------------------+");
        }
    }
    public void CN12(StudentsManager std)
    {
        Console.Clear();
        if (std.count == 0)
        {
            Console.WriteLine("Danh sách sinh viên trống!");
            Press();
        }
        else
        {
            Console.WriteLine("=========== Cập nhật thông tin sinh viên ============");
            std.update();
        }
    }
    public void CN13(StudentsManager std)
    {
        Console.Clear();
        Console.WriteLine("============== Thêm mới một sinh viên ===============");
        std.add();
    }
    public void CN2()
    {
        Console.Clear();
        Console.WriteLine("+-----------------------------------------------------+");
        Console.WriteLine("|                 Quản lí lớp                         |");
        Console.WriteLine("+-----------------------------------------------------+");
        Console.WriteLine("| 1. Xem danh sách lớp                                |");
        Console.WriteLine("| 2. Cập nhật thông tin lớp                           |");
        Console.WriteLine("| 3. Thêm mới một lớp                                 |");
        Console.WriteLine("| 0. Trở về menu chính                                |");
        Console.WriteLine("+-----------------------------------------------------+");
        Console.Write("  Lựa chọn chức năng: ");
    }
    public void CN21(ClassManager cls)
    {
        Console.Clear();
        if (cls.count == 0) Console.WriteLine("Danh sách lớp trống!");
        else
        {
            Console.WriteLine("+----------------------------------------------------------------------------------------+");
            Console.WriteLine("|                                 Danh sách lớp                                          |");
            Console.WriteLine("+----------------------------------------------------------------------------------------+");
            Console.WriteLine("| Mã lớp  | Mô tả                   | Giảng viên          | Giờ học         | Ngày học   |");
            Console.WriteLine("+----------------------------------------------------------------------------------------+");
            cls.display();
            Console.WriteLine("+----------------------------------------------------------------------------------------+");
        }
    }
    public void CN22(ClassManager cls)
    {
        Console.Clear();
        if (cls.count == 0)
        {
            Console.WriteLine("Danh sách lớp trống!");
            Press();
        }
        else
        {
            Console.WriteLine("============= Cập nhật thông tin lớp =============");
            cls.update();
        }
    }
    public void CN23(ClassManager cls)
    {
        Console.Clear();
        Console.WriteLine("================ Thêm mới một lớp =================");
        cls.add();
    }
    public void CN3()
    {
        Console.Clear();
        Console.WriteLine("+-----------------------------------------------------+");
        Console.WriteLine("|               Quản lí điểm thi                      |");
        Console.WriteLine("+-----------------------------------------------------+");
        Console.WriteLine("| 1. Nhập điểm thi                                    |");
        Console.WriteLine("| 2. Hiển thị điểm thi theo lớp                       |");
        Console.WriteLine("| 3. Hiển thị điểm thi theo môn                       |");
        Console.WriteLine("| 0. Trở về menu chính                                |");
        Console.WriteLine("+-----------------------------------------------------+");
        Console.Write("  Lựa chọn chức năng: ");
    }
    public void CN31(StudentsManager std)
    {
        Console.Clear();
        Console.Clear();
        if (std.count == 0)
        {
            Console.WriteLine("Danh sách sinh viên trống!");
            Press();
        }
        else
        {
            Console.WriteLine("================ Nhập điểm thi =================");
            std.addScore();
        }
    }
    public void CN32(StudentsManager std)
    {
        Console.Clear();
        if (std.count == 0) Console.WriteLine("Danh sách sinh viên trống!");
        else
        {
            Console.WriteLine("=================== Điểm thi theo lớp ====================");
            Console.Write("  Nhập mã lớp: ");
            string temp = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("+---------------------------------------------------------------+");
            Console.WriteLine("|                         Danh sách sinh viên                   |");
            Console.WriteLine("+---------------------------------------------------------------+");
            Console.WriteLine("| Mã lớp   | Tên sinh viên        | Môn thi   | Điểm | Đánh giá |");
            Console.WriteLine("+---------------------------------------------------------------+");
            std.displayByClass(temp);
            Console.WriteLine("+---------------------------------------------------------------+");
        }
    }
    public void CN33(StudentsManager std)
    {
        Console.Clear();
        if (std.count == 0) Console.WriteLine("Danh sách sinh viên trống!");
        else
        {
            Console.WriteLine("=================== Điểm thi theo môn ====================");
            Console.Write("  Nhập môn thi: ");
            string temp = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("+---------------------------------------------------------------+");
            Console.WriteLine("|                         Danh sách sinh viên                   |");
            Console.WriteLine("+---------------------------------------------------------------+");
            Console.WriteLine("| Mã lớp   | Tên sinh viên        | Môn thi   | Điểm | Đánh giá |");
            Console.WriteLine("+---------------------------------------------------------------+");
            std.displayBySubject(temp);
            Console.WriteLine("+---------------------------------------------------------------+");
        }
    }
    public void check(ClassManager cls, StudentsManager std)
    {
        std.check(cls);
    }
}