using System;
using System.Collections.Generic;
class StudentManager
{
    method m = new method();
    WorkingWithFile wwf = new WorkingWithFile();
    public Student CreateNew(List<Student> std)
    {
        if (std == null) std = new List<Student>();
        Student s = new Student();
        Boolean check = false;
        do
        {
            Console.Write("Nhập mã sinh viên: ");
            s.Id = Console.ReadLine();
            for (int i = 0; i < std.Count; i++)
            {
                if (s.Id.Equals(std[i].Id))
                {
                    Console.WriteLine("Mã sinh viên đã tồn tại! Mời nhập lại.");
                    check = true;
                    break;
                }
                check = false;
            }
        } while (check);
        Console.Write("Nhập tên sinh viên: ");
        s.Name = m.ChuanHoa(Console.ReadLine());
        Console.Write("Nhập địa chỉ: ");
        s.Address = Console.ReadLine();
        Boolean convert = true;
        do
        {
            Console.Write("Nhập ngày sinh: ");
            string d = Console.ReadLine();
            convert = DateTime.TryParse(d, out DateTime result);
            if (convert) s.Birthday = result;
            else Console.WriteLine("Bạn vừa nhập không phải ngày tháng. Mời nhập lại !\n");
        } while (!convert);
        Console.Write("Nhập mã lớp: ");
        s.IdClass = checkIdClass();
        return s;
    }
    public List<Student> Insert()
    {
        List<Student> std = wwf.GetFromFile<Student>("Student.json");
        Student s = CreateNew(std);
        if (std != null)
        {
            std.Add(s);
        }
        else
        {
            std = new List<Student>();
            std.Add(s);
        }
        wwf.PushFromFile<Student>("Student.json", std);
        return std;
    }
    public Student Update(Student s)
    {
        Console.Write("Sửa tên sinh viên: ");
        s.Name = m.ChuanHoa(Console.ReadLine());
        Console.Write("Sửa địa chỉ: ");
        s.Address = Console.ReadLine();
        Boolean convert = true;
        do
        {
            Console.Write("Sửa ngày sinh: ");
            string d = Console.ReadLine();
            convert = DateTime.TryParse(d, out DateTime result);
            if (convert) s.Birthday = result;
            else Console.WriteLine("Bạn vừa nhập không phải ngày tháng. Mời nhập lại !\n");
        } while (!convert);
        Console.Write("Sửa mã lớp: ");
        s.IdClass = checkIdClass();
        return s;
    }
    public void UpdateFile(List<Student> std)
    {
        Boolean check = true;
        while (check)
        {
            Console.Write("Nhập mã sinh viên: ");
            int index = std.FindIndex(x => x.Id == Console.ReadLine());
            if (index != -1)
            {
                std[index] = Update(std[index]);
                check = false;
                if (m.UpdateYN()) wwf.PushFromFile<Student>("Student.json", std);
            }
            else Console.WriteLine("Mã sinh viên vừa nhập không tồn tại!");
        }
    }
    public void Display()
    {
        List<Student> std = wwf.GetFromFile<Student>("Student.json");
        if (std == null)
        {
            Console.WriteLine("Danh sách trống!");
        }
        else
        {
            Console.WriteLine("+--------------------------------------------------------------------------+");
            Console.WriteLine("|                         Danh sách sinh viên                              |");
            Console.WriteLine("+--------------------------------------------------------------------------+");
            Console.WriteLine("| Mã SV    | Họ và tên            | Địa chỉ            | Ngày Sinh | Lớp   |");
            Console.WriteLine("+--------------------------------------------------------------------------+");
            for (int i = 0; i < std.Count; i++)
            {
                std[i].display();
            }
            Console.WriteLine("+--------------------------------------------------------------------------+");

        }
    }
    public void displayByClass(string idClass, List<Student> std)
    {
        for (int i = 0; i < std.Count; i++)
        {
            if (std[i].IdClass == idClass)
            {
                if(std[i].Scr != null)
                for (int j = 0; j < std[i].Scr.Count; j++)
                {
                    std[i].displayScore(j);
                }
            }
        }
    }
    public void displayBySubject(string subject, List<Student> std)
    {
        for (int i = 0; i < std.Count; i++)
        {
            if(std[i].Scr != null)
            for (int j = 0; j < std[i].Scr.Count; j++)
            {
                if (std[i].Scr[j].Subject == subject) std[i].displayScore(j);
            }
        }

    }
    public string checkIdClass()
    {
        bool check;
        string s;
        do
        {
            s = Console.ReadLine();
            List<Class> cls = wwf.GetFromFile<Class>("Class.json");
            if (cls == null) cls = new List<Class>();
            int i = cls.FindIndex(x => x.IdClass == s);
            if (i == -1)
            {
                Console.Write("Mã lớp chưa được mở! Bạn có muốn tạo mới lớp?(Y/N): ");
                string yn;
                do
                {
                    yn = Console.ReadLine();
                    if (yn.ToLower() == "y")
                    {
                        ClassManager c = new ClassManager();
                        c.Insert(s);
                        check = false;
                    }
                    else if (yn.ToLower() == "n")
                    {
                        Console.Write("Mời bạn nhập lại mã lớp: ");
                        check = true;
                    }
                    else
                    {
                        Console.Write("Nhập sai! Mời nhập lại: ");
                        check = true;
                    }
                } while (yn.ToLower() != "y" && yn.ToLower() != "n");
            }
            else
                check = false;
        } while (check);
        return s;
    }
}