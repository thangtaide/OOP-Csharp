using System;
using System.Collections.Generic;
class ClassManager
{
    method m = new method();
    WorkingWithFile wwf = new WorkingWithFile();
    public Class CreateNew(List<Class> cls)
    {
        if (cls == null) cls = new List<Class>();
        Class c = new Class();
        Boolean check = false;
        do
        {
            Console.Write("Nhập mã lớp: ");
            c.IdClass = Console.ReadLine();
            for (int i = 0; i < cls.Count; i++)
            {
                if (c.IdClass.Equals(cls[i].IdClass))
                {
                    Console.WriteLine("Mã lớp đã tồn tại! Mời nhập lại.");
                    check = true;
                    break;
                }
                check = false;
            }
        } while (check);
        Console.Write("Nhập mô tả lớp: ");
        c.Description = Console.ReadLine();
        Console.Write("Nhập giảng viên: ");
        c.Teacher = m.ChuanHoa(Console.ReadLine());
        Console.Write("Nhập thời gian học: ");
        c.Time = Console.ReadLine();
        Console.Write("Nhập ngày học: ");
        c.Day = Console.ReadLine();
        return c;
    }
    public Class CreateNew(List<Class> cls, string idclass)
    {
        if (cls == null) cls = new List<Class>();
        Class c = new Class();
        c.IdClass = idclass;
        Console.Write("Nhập mô tả lớp: ");
        c.Description = Console.ReadLine();
        Console.Write("Nhập giảng viên: ");
        c.Teacher = m.ChuanHoa(Console.ReadLine());
        Console.Write("Nhập thời gian học: ");
        c.Time = Console.ReadLine();
        Console.Write("Nhập ngày học: ");
        c.Day = Console.ReadLine();
        return c;
    }
    public List<Class> Insert()
    {
        List<Class> cls = wwf.GetFromFile<Class>("Class.json");
        Class s = CreateNew(cls);
        if (cls != null)
        {
            cls.Add(s);
        }
        else
        {
            cls = new List<Class>();
            cls.Add(s);
        }
        wwf.PushFromFile<Class>("Class.json", cls);
        return cls;
    }
    public List<Class> Insert(string idclass)
    {
        List<Class> cls = wwf.GetFromFile<Class>("Class.json");
        Class s = CreateNew(cls, idclass);
        if (cls != null)
        {
            cls.Add(s);
        }
        else
        {
            cls = new List<Class>();
            cls.Add(s);
        }
        wwf.PushFromFile<Class>("Class.json", cls);
        return cls;
    }
    public Class Update(Class c)
    {
        Console.Write("Sửa mô tả lớp: ");
        c.Description = Console.ReadLine();
        Console.Write("Sửa giảng viên: ");
        c.Teacher = m.ChuanHoa(Console.ReadLine());
        Console.Write("Sửa thời gian học: ");
        c.Time = Console.ReadLine();
        Console.Write("Sửa ngày học: ");
        c.Day = Console.ReadLine();
        return c;
    }
    public void UpdateFile(List<Class> cls)
    {
        Boolean check = true;
            while (check)
            {
                Console.Write("Nhập mã lớp: ");
                int index = cls.FindIndex(x => x.IdClass == Console.ReadLine());
                if (index != -1)
                {
                    cls[index] = Update(cls[index]);
                    check = false;
                    if (m.UpdateYN()) wwf.PushFromFile<Class>("Class.json", cls);
                }
                else Console.WriteLine("Mã lớp vừa nhập không tồn tại!");
            }
    }
    public void Display()
    {
        List<Class> cls = wwf.GetFromFile<Class>("Class.json");
        if (cls == null)
        {
            Console.WriteLine("Danh sách trống!");
        }
        else
        {
            Console.WriteLine("+----------------------------------------------------------------------------------------+");
            Console.WriteLine("|                                 Danh sách lớp                                          |");
            Console.WriteLine("+----------------------------------------------------------------------------------------+");
            Console.WriteLine("| Mã lớp  | Mô tả                   | Giảng viên          | Giờ học         | Ngày học   |");
            Console.WriteLine("+----------------------------------------------------------------------------------------+");
            for (int i = 0; i < cls.Count; i++)
            {
                cls[i].display();
            }
            Console.WriteLine("+----------------------------------------------------------------------------------------+");
        }
    }
    
}