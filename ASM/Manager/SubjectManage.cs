using System;
using System.Collections.Generic;
class SubjectManager
{
    method m = new method();
    WorkingWithFile wwf = new WorkingWithFile();
    public void Insert(List<Student> std)
    {
        Subjects sub = new Subjects();
        Boolean check = true;
        while (check)
        {
            string s, yn;
            Console.Write("Nhập mã sinh viên: ");
            int index = std.FindIndex(x => x.Id == Console.ReadLine());
            if (index != -1)
            {
                int c = -1;
                Boolean update = true;
                do
                {
                    Console.Write("Nhập môn thi: ");
                    s = Console.ReadLine();
                    if (std[index].Scr != null)
                    {
                        c = std[index].Scr.FindIndex(x => x.Subject == s);
                        if (c != -1)
                        {
                            do
                            {
                                Console.Write("Môn đã được nhập điểm. Đồng ý cập nhật điểm mới? (Y/N): ");
                                yn = Console.ReadLine();
                                if (yn.ToLower() != "n" && yn.ToLower() != "y")
                                    Console.WriteLine("Nhập sai! Mời nhập lại!");
                            } while (yn.ToLower() != "n" && yn.ToLower() != "y");
                            if (yn.ToLower() == "y") update = false;
                        }
                    }else std[index].Scr = new List<Subjects>();
                } while (c != -1 && update);
                sub.Subject = s;
                Boolean convert = true;
                do
                {
                    Console.Write("Nhập điểm: ");
                    string d = Console.ReadLine();
                    convert = int.TryParse(d, out int result);
                    if (convert)
                    {
                        if (result < 0 || result > 20)
                        {
                            Console.WriteLine("Bạn vừa nhập số điểm không hợp lệ(điểm phải trong khoảng 0-20). Mời nhập lại !\n");
                            convert = false;
                        }
                        else
                        {
                            sub.Score = result;
                            check = false;
                        }
                    }
                    else Console.WriteLine("Bạn vừa nhập không phải số. Mời nhập lại !\n");
                } while (!convert);
                if (c != -1) std[index].Scr[c] = sub;
                else
                {
                    std[index].Scr.Add(sub);
                }
            }
            else Console.WriteLine("Mã sinh viên vừa nhập không tồn tại!");
        }
        wwf.PushFromFile<Student>("Student.json", std);
    }
    public void DisplayByClass(List<Student> s)
    {
        StudentManager std = new StudentManager();
        Console.WriteLine("=================== Điểm thi theo lớp ====================");
        Console.Write("  Nhập mã lớp: ");
        string temp = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("+---------------------------------------------------------------+");
        Console.WriteLine("|                         Danh sách sinh viên                   |");
        Console.WriteLine("+---------------------------------------------------------------+");
        Console.WriteLine("| Mã lớp   | Tên sinh viên        | Môn thi   | Điểm | Đánh giá |");
        Console.WriteLine("+---------------------------------------------------------------+");
        std.displayByClass(temp, s);
        Console.WriteLine("+---------------------------------------------------------------+");
    }
    public void DisplayBySubject(List<Student> s)
    {
        StudentManager std = new StudentManager();
        Console.WriteLine("=================== Điểm thi theo môn ====================");
        Console.Write("  Nhập môn thi: ");
        string temp = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("+---------------------------------------------------------------+");
        Console.WriteLine("|                         Danh sách sinh viên                   |");
        Console.WriteLine("+---------------------------------------------------------------+");
        Console.WriteLine("| Mã lớp   | Tên sinh viên        | Môn thi   | Điểm | Đánh giá |");
        Console.WriteLine("+---------------------------------------------------------------+");
        std.displayBySubject(temp, s);
        Console.WriteLine("+---------------------------------------------------------------+");
    }
}