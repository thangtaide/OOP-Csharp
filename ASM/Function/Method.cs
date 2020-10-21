using System;
class method
{
    public string ChuanHoa(string s)
    {
        s = s.Trim().ToLower();
        while (s.Contains("  "))
        {
            s.Replace("  ", " ");
        }
        string[] s1 = s.Split(" ");
        s = "";
        foreach (string item in s1)
        {
            s += item.Substring(0, 1).ToUpper() + item.Substring(1) + " ";
        }
        return s.TrimEnd();
    }
    public Boolean UpdateYN()
    {
        while (true)
        {
            Console.Write("\nBạn có muốn cập nhật thông tin?(Y/N): ");
            string yn = Console.ReadLine();
            if (yn.ToLower() == "y")
            {
                Console.WriteLine("\nThông tin đã được cập nhật!");
                return true;
            }
            else if (yn.ToLower() == "n")
            {
                Console.WriteLine("\nThông tin chưa được cập nhật!");
                return false;
            }
            else Console.WriteLine("Nhập sai! Mời nhập lại!");
        }
    }
    public Boolean ContinueYN()
    {
        while (true)
        {
            Console.Write("\nBạn có muốn tiếp tục?(Y/N): ");
            string yn = Console.ReadLine();
            if (yn.ToLower() == "y")
            {
                return true;
            }
            else if (yn.ToLower() == "n")
            {
                return false;
            }
            else FalsePress(false);
        }
    }
    public void Press()
    {
        Console.Write("Press any key to continue... ");
        Console.ReadKey();
    }
    public void FalsePress(bool b)
    {
        Console.WriteLine("Nhập sai! Mời nhập lại!");
        if(b) Console.ReadKey();
    }
}