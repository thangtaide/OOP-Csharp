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
                    }
                    else std[index].Scr = new List<Subjects>();
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
    public void Display(List<Student> s, int choice)
    {
        StudentManager std = new StudentManager();
        bool check = true;
        string temp = "";
        if (choice == 1)
        {
            Console.WriteLine("=================== Điểm thi theo lớp ====================");
            Console.Write("  Nhập mã lớp: ");
            temp = Console.ReadLine();
            check = checkNullClass(s, temp);
        }
        else if (choice == 2)
        {
            Console.WriteLine("=================== Điểm thi theo môn ====================");
            Console.Write("  Nhập môn thi: ");
            temp = Console.ReadLine();
            check = checkNullSubject(s, temp);
        }
        if (check)
        {
            Console.Clear();
            Console.WriteLine("+---------------------------------------------------------------+");
            Console.WriteLine("|                         Danh sách sinh viên                   |");
            Console.WriteLine("+---------------------------------------------------------------+");
            Console.WriteLine("| Mã lớp   | Tên sinh viên        | Môn thi   | Điểm | Đánh giá |");
            Console.WriteLine("+---------------------------------------------------------------+");
            if (choice == 1) std.displayByClass(temp, s);
            else if (choice == 2) std.displayBySubject(temp, s);
            Console.WriteLine("+---------------------------------------------------------------+");
        }
        else
        {
            if (choice == 1) Console.WriteLine("\nDanh sách điểm theo lớp vừa nhập trống!\n");
            else if (choice == 2) Console.WriteLine("\nDanh sách điểm theo môn vừa nhập trống!\n");
        }
    }
    public Boolean checkNullSubject(List<Student> s, string text)
    {
        for (int i = 0; i < s.Count; i++)
        {
            if (s[i].Scr != null)
            {
                if (s[i].Scr.FindIndex(x => x.Subject == text) != -1) return true;
            }
        }
        return false;
    }
    public Boolean checkNullClass(List<Student> s, string text)
    {
        for (int i = 0; i < s.Count; i++)
        {
            if (s[i].IdClass == text && s[i].Scr != null) return true;
        }
        return false;
    }
}