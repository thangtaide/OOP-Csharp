using System;
using System.Collections.Generic;
class StudentsManager
{
    List<Student> students = new List<Student>();
    public int count = 0;
    public void add()
    {
        string yn = "";
        do
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Student s = new Student();
            Boolean check = false;
            do
            {
                Console.Write("Nhập mã sinh viên: ");
                s.ID = Console.ReadLine();
                for (int i = 0; i < count; i++)
                {
                    if (s.ID.Equals(students[i].ID))
                    {
                        Console.WriteLine("Mã sinh viên đã tồn tại! Mời nhập lại.");
                        check = true;
                        break;
                    }
                    check = false;
                }
            } while (check);
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
        string yn = "";
        do
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            string s;
            int i;
            Boolean check;
            do
            {
                Console.Write("Nhập mã sinh viên: ");
                s = Console.ReadLine();
                // i = students.FindIndex(x => x.ID == s);
                check = false;
                foreach (Student item in students)
                {
                    if(item.ID == s)
                    {
                        Console.Write("Nhập tên sinh viên: ");
                        item.Name = Console.ReadLine();
                        check = true;
                        break;
                    }
                }
                if(!check) Console.WriteLine("Mã sinh viên không tồn tại. Mời nhập lại !");
            } while (!check);
            Console.Write("Nhập tên sinh viên: ");
            students[i].Name = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            students[i].Address = Console.ReadLine();
            Boolean convert = true;
            do
            {
                Console.Write("Nhập ngày sinh: ");
                string d = Console.ReadLine();
                convert = DateTime.TryParse(d, out DateTime result);
                if (convert) students[i].Date = result;
                else Console.WriteLine("Bạn vừa nhập không phải ngày tháng. Mời nhập lại !\n");
            } while (!convert);
            Console.Write("Nhập mã lớp: ");
            students[i].IDClass = Console.ReadLine();
            do
            {
                Console.Write("Bạn có muốn tiếp tục?(Y/N): ");
                yn = Console.ReadLine();
                if (yn.ToLower() != "n" && yn.ToLower() != "y")
                    Console.WriteLine("Nhập sai! Mời nhập lại!");
            } while (yn.ToLower() != "n" && yn.ToLower() != "y");
        } while (yn.ToLower() != "n");
    }
    public void addScore()
    {
        string yn = "";
        do
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            string s;
            int index = 0;
            do
            {
                Console.Write("Nhập mã sinh viên: ");
                s = Console.ReadLine();
                index = students.FindIndex(x => x.ID == s);
                if (index == -1) Console.WriteLine("Mã sinh viên không tồn tại. Mời nhập lại !");
            } while (index == -1);
            Scores temp = new Scores();
            int check;
            Boolean sub = true;
            do
            {
                Console.Write("Nhập môn thi: ");
                s = Console.ReadLine();
                check = students[index].scr.FindIndex(x => x.Subject == s);
                if (check != -1)
                {
                    do
                    {
                        Console.Write("Môn đã được nhập điểm. Đồng ý cập nhật điểm mới? (Y/N): ");
                        yn = Console.ReadLine();
                        if (yn.ToLower() != "n" && yn.ToLower() != "y")
                            Console.WriteLine("Nhập sai! Mời nhập lại!");
                    } while (yn.ToLower() != "n" && yn.ToLower() != "y");
                    if(yn.ToLower() == "y") sub = false;
                }
            } while (check != -1 && sub);
            temp.Subject = s;
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
                    else temp.Score = result;
                }
                else Console.WriteLine("Bạn vừa nhập không phải số. Mời nhập lại !\n");
            } while (!convert);
            if(check != -1) students[index].scr[check] = temp;
            else{
                students[index].scr.Add(temp);
                students[index].count++;
            }
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
    public void display()
    {
        for (int i = 0; i < count; i++)
        {
            students[i].display();
        }
    }
    public void displayByClass(string idClass)
    {
        for (int i = 0; i < count; i++)
        {
            if (students[i].IDClass == idClass)
                for (int j = 0; j < students[i].count; j++)
                {
                    students[i].displayScore(j);
                }
        }
    }
    public string idClass(int index)
    {
        return students[index].IDClass;
    }
    public void displayBySubject(string subject)
    {
        for (int i = 0; i < count; i++)
        {
            for (int j = 0; j < students[i].count; j++)
            {
                if (students[i].scr[j].Subject == subject) students[i].displayScore(j);
            }
        }
    }
    public Student display(int index)
    {
        return students[index];
    }
    public void add(Student s)
    {
        students.Add(s);
    }
    public void sort()
    {
        students.Sort((x,y) => x.ID.CompareTo(y.ID));
    }
}