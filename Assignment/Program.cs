using System;
using System.IO;
using Newtonsoft.Json;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            string choice;
            Menu m = new Menu();
            StudentsManager std = new StudentsManager();
            ClassManager cls = new ClassManager();
            FileStream fc = new FileStream("Class.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            fc.Close();
            using (BinaryReader reader = new BinaryReader(File.Open("Class.dat", FileMode.Open)))
            {
                if ((int)reader.BaseStream.Length <= 0)
                {
                }
                else
                {
                    cls.count = reader.ReadInt32();
                    for (int i = 0; i < cls.count; i++)
                    {
                        Class c = new Class();
                        c.IDClass = reader.ReadString();
                        c.Description = reader.ReadString();
                        c.Teacher = reader.ReadString();
                        c.Time = reader.ReadString();
                        c.Day = reader.ReadString();
                        cls.add(c);
                    }
                }
            }
            if (File.Exists("Student.dat"))
            {
            }
            else
            {
                FileStream fs = new FileStream("Student.dat", FileMode.CreateNew);
                fs.Close();
            }
            using (BinaryReader reader = new BinaryReader(File.Open("Student.dat", FileMode.Open)))
            {
                if ((int)reader.BaseStream.Length <= 0)
                {
                }
                else
                {
                    std.count = reader.ReadInt32();
                    for (int i = 0; i < std.count; i++)
                    {
                        Student s = new Student();
                        s.ID = reader.ReadString();
                        s.Name = reader.ReadString();
                        s.Address = reader.ReadString();
                        string date = reader.ReadString();
                        s.Date = Convert.ToDateTime(date);
                        s.IDClass = reader.ReadString();
                        s.count = reader.ReadInt32();
                        for (int j = 0; j < s.count; j++)
                        {
                            Scores scores = new Scores();
                            scores.Subject = reader.ReadString();
                            scores.Score = reader.ReadInt32();
                            s.scr.Add(scores);
                        }
                        std.add(s);
                    }
                }
            }
            do
            {
                m.menu();
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        Console.WriteLine("\n ...\nChúc các bạn sinh viên học tập tốt!");
                        break;
                    case "1":
                        string c1;
                        do
                        {
                            m.CN1();
                            c1 = Console.ReadLine();
                            switch (c1)
                            {
                                case "0":
                                    break;
                                case "1":
                                    m.CN11(std);
                                    m.Press();
                                    break;
                                case "2":
                                    m.CN12(std);
                                    break;
                                case "3":
                                    m.CN13(std);
                                    std.sort();
                                    break;
                                default:
                                    m.ErrorPress();
                                    break;
                            }
                        } while (c1 != "0");
                        break;
                    case "2":
                        string c2;
                        do
                        {
                            m.CN2();
                            c2 = Console.ReadLine();
                            switch (c2)
                            {
                                case "0":
                                    break;
                                case "1":
                                    m.CN21(cls);
                                    m.Press();
                                    break;
                                case "2":
                                    m.CN22(cls);
                                    break;
                                case "3":
                                    m.CN23(cls);
                                    m.check(cls, std);
                                    m.Press();
                                    cls.sort();
                                    break;
                                default:
                                    m.ErrorPress();
                                    break;
                            }
                        } while (c2 != "0");
                        break;
                    case "3":
                        string c3;
                        do
                        {
                            m.CN3();
                            c3 = Console.ReadLine();
                            switch (c3)
                            {
                                case "0":
                                    break;
                                case "1":
                                    m.CN31(std);
                                    break;
                                case "2":
                                    m.CN32(std);
                                    m.Press();
                                    break;
                                case "3":
                                    m.CN33(std);
                                    m.Press();
                                    break;
                                default:
                                    m.ErrorPress();
                                    break;
                            }
                        } while (c3 != "0");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Nhập sai! Mời chọn lại!");
                        Console.ReadKey();
                        break;
                }
            } while (choice != "0");
            using (BinaryWriter writer = new BinaryWriter(File.Open("Student.dat", FileMode.Open)))
            {
                writer.Write(std.count);
                for (int i = 0; i < std.count; i++)
                {
                    Student s = new Student();
                    s = std.display(i);
                    writer.Write(s.ID);
                    writer.Write(s.Name);
                    writer.Write(s.Address);
                    writer.Write(Convert.ToString(s.Date));
                    writer.Write(s.IDClass);
                    writer.Write(s.count);
                    for (int j = 0; j < s.count; j++)
                    {
                        writer.Write(s.scr[j].Subject);
                        writer.Write(s.scr[j].Score);
                    }
                }
            }
            using (BinaryWriter writer = new BinaryWriter(File.Open("Class.dat", FileMode.Open)))
            {
                writer.Write(cls.count);
                for (int i = 0; i < cls.count; i++)
                {
                    Class c = new Class();
                    c = cls.display(i);
                    writer.Write(c.IDClass);
                    writer.Write(c.Description);
                    writer.Write(c.Teacher);
                    writer.Write(c.Time);
                    writer.Write(c.Day);
                }
            }
            // Save with json
            // string fileS = JsonConvert.SerializeObject(std);
            // string fileC = JsonConvert.SerializeObject(cls);
        }
        public static string ChuanHoa(string str)
        {
            str = str.Trim().ToLower();
            while (str.Contains("  "))
                str.Replace("  ", " ");
            string[] arrStr = str.Split(' ');
            string s = "";
            foreach (string item in arrStr)
            {
                s += item.Substring(0, 1).ToUpper() + item.Substring(1) + " ";

            }
            return s.TrimEnd();
        }
    }
}
