using System;
using System.Collections.Generic;
class StudentsManager
{
    List<Student> students = new List<Student>();
    int count = 0;
    public void add()
    {
        string yn = "";
        do
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Student s = new Student();
            Console.Write("Nhập mã sinh viên: ");
            s.ID = Console.ReadLine();
            Console.Write("Nhập tên sinh viên: ");
            s.Name = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            s.Address = Console.ReadLine();
            Boolean convert = true;
            do
            {
                Console.Write("Nhập ngày sinh: ");
                string d = Console.ReadLine();
                convert = DateTime.TryParse(d, out DateTime result);
                if (convert) s.Date = result;
                else Console.WriteLine("Bạn vừa nhập không phải ngày tháng. Mời nhập lại !\n");
            } while (!convert);
            Console.Write("Nhập mã lớp: ");
            s.IDClass = Console.ReadLine();
            students.Add(s);
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

    }
    public void display()
    {
        for (int i = 0; i < count; i++)
        {
            students[i].display();
        }
    }
}