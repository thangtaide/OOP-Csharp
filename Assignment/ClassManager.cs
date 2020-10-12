using System;
using System.Collections.Generic;
class ClassManager
{
    List<Class> cls = new List<Class>();
    public int count = 0;
    public void add()
    {
        string yn = "";
        do
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Class c = new Class();
            Boolean check = false;
            do
            {
                Console.Write("Nhập mã lớp: ");
                c.IDClass = Console.ReadLine();
                for (int i = 0; i < count; i++)
                {
                    if (c.IDClass.Equals(cls[i].IDClass))
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
            c.Teacher = Console.ReadLine();
            Console.Write("Nhập thời gian học: ");
            c.Time = Console.ReadLine();
            Console.Write("Nhập ngày học: ");
            c.Day = Console.ReadLine();
            cls.Add(c);
            count++;
            Console.WriteLine();
            do
            {
                Console.Write("Bạn có muốn tiếp tục?(Y/N): ");
                yn = Console.ReadLine();
                if (yn.ToLower() != "n" && yn.ToLower() != "y")
                    Console.WriteLine("Nhập sai! Mời nhập lại!");
            } while (yn.ToLower() != "n" && yn.ToLower() != "y");
        } while (yn.ToLower() != "n");
    }
    public void update()
    {
        string yn = "";
        do
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            string c;
            int i;
            do
            {
                Console.Write("Nhập mã mã lớp: ");
                c = Console.ReadLine();
                i = cls.FindIndex(x => x.IDClass == c);
                if (i == -1) Console.WriteLine("Mã lớp không tồn tại. Mời nhập lại !");
            } while (i == -1);
            Console.Write("Sửa mô tả lớp: ");
            cls[i].Description = Console.ReadLine();
            Console.Write("Sửa giảng viên: ");
            cls[i].Teacher = Console.ReadLine();
            Console.Write("Sửa thời gian học: ");
            cls[i].Time = Console.ReadLine();
            Console.Write("Sửa ngày học: ");
            cls[i].Day = Console.ReadLine();
            do
            {
                Console.Write("Bạn có muốn tiếp tục?(Y/N): ");
                yn = Console.ReadLine();
                if (yn.ToLower() != "n" && yn.ToLower() != "y")
                    Console.WriteLine("Nhập sai! Mời nhập lại!");
            } while (yn.ToLower() != "n" && yn.ToLower() != "y");
        } while (yn.ToLower() != "n");
    }
    public string idClass(int index)
    {
        return cls[index].IDClass;
    }
    public void display()
    {
        for (int i = 0; i < count; i++)
        {
            cls[i].display();
        }
    }
    public void add(Class c)
    {
        cls.Add(c);
    }
}