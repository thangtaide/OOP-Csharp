using System;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            double inch, cm;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            int choice;
            do{
                Console.Clear();
                Console.WriteLine("==================================");
                Console.WriteLine("Chọn 0 để exit");
                Console.Write("Bài tập số: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice){
                    case 0:
                        Console.WriteLine("Exit ...");
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Bài tập 1: Employee Information");
                        string name, andress;
                        int number;
                        Console.Write("Tên bạn là: ");
                        name = Console.ReadLine();
                        Console.Write("Địa chỉ: ");
                        andress = Console.ReadLine();
                        Console.Write("Số điện thoại: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n==================================");
                        Console.Write("Tên: {0}\nĐịa chỉ: {1}\nSố điện thoại: {2}\n", name, andress, number);
                        Console.WriteLine("==================================");
                        Console.Write("Press any key to continue... ");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Bài tập 2: Find max number");
                        Console.Write("Mời nhập vào 3 số: ");
                        int a, b, c, max;
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        c = Convert.ToInt32(Console.ReadLine());
                        max = a;
                        if(max < b) max = b;
                        if(max < c) max = c;
                        Console.WriteLine("\nSố lớn nhất trong 3 số là: "+max);
                        Console.Write("Press any key to continue... ");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Bài tập 3: Multiplication of an integer");
                        Console.Write("Enter n: ");
                        int n, i;
                        n = Convert.ToInt32(Console.ReadLine());
                        for(i = 1; i < 10; i++)
                        {
                            Console.WriteLine("{0} x {1} = {2}", n, i, n*i);
                        }
                        Console.Write("Press any key to continue... ");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Bài tập 4: Tax in New York City");
                        Console.Write("Mời nhập giá: ");
                        double price, tax, total;
                        price = Convert.ToDouble(Console.ReadLine());
                        tax = price*0.0825;
                        total = price*1.0825;
                        Console.WriteLine("Tiền thuế phải trả: "+ tax);
                        Console.WriteLine("Tổng tiền phải trả: "+ total);
                        Console.Write("Press any key to continue... ");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Bài tập 5: Pay for employee");
                        Console.Write("Tổng số giờ làm việc: ");
                        double hours, BasePay, Pay;
                        hours = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Lương cơ bản mỗi giờ: ");
                        BasePay = Convert.ToDouble(Console.ReadLine());
                        Pay = BasePay * hours;
                        Console.WriteLine("Lương của nhân viên: "+Pay);
                        Console.Write("Press any key to continue... ");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Bài tập 6: Warning messages");
                        double BPay, Hours;
                        Console.Write("Lương cơ bản mỗi giờ: ");
                        BPay = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Tổng số giờ làm việc mỗi tuần: ");
                        Hours = Convert.ToDouble(Console.ReadLine());
                        if(BPay < 5.15) Console.WriteLine("\nWarning!!!\nLương cơ bản quá thấp!!!");
                        else Console.WriteLine("\nLương cơ bản hợp lí");
                        if(Hours > 56) Console.WriteLine("\nWarning!!!\nThời gian làm việc mỗi tuần quá nhiều!!!");
                        else Console.WriteLine("Thời gian làm việc phù hợp");
                        Console.Write("Press any key to continue... ");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Bài tập 7: Centimeters - inch");
                        Console.Write("Mời nhập giá trị inch: ");
                        inch = float.Parse(Console.ReadLine());
                        cm = inch* 2.54;
                        Console.WriteLine("\n{0} inch = {1} cm", inch, cm);
                        Console.Write("Press any key to continue... ");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Bài tập 8: Day of Week");
                        Console.WriteLine("Chọn 0 để thoát chương trình");
                        int days;
                        do{
                            Console.Write("\nMời nhập lựa chọn: ");
                            days = Convert.ToInt32(Console.ReadLine());
                            switch(days){
                                case 0:
                                    Console.WriteLine("Exit Day of Week program ...");
                                    break;
                                case 1:
                                    Console.WriteLine("Monday");
                                    break;
                                case 2:
                                    Console.WriteLine("Tuesday");
                                    break;
                                case 3:
                                    Console.WriteLine("Wednesday");
                                    break;
                                case 4:
                                    Console.WriteLine("Thursday");
                                    break;
                                case 5:
                                    Console.WriteLine("Friday");
                                    break;
                                case 6:
                                    Console.WriteLine("Saturday");
                                    break;
                                case 7:
                                    Console.WriteLine("Sunday");
                                    break;
                                default:
                                    Console.WriteLine("Lựa chọn không hợp lệ!!!");
                                    break;
                            }
                        }while(days != 0);
                        Console.Write("Press any key to continue... ");
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Bài tập 9: Display prime numbers");
                        Console.Write("Mời nhập n: ");
                        int n1, j;
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Danh sách số nguyên tố từ 0 -> {0} là:", n1);
                        Console.Write("2 | 3 | ");
                        for(j = 4; j <= n1; j++)
                        {
                            bool dk = true;
                            for(int k = 2; k <= Math.Sqrt(j); k++)
                            {
                                if(j%k == 0) dk = false;
                            }
                            if(dk) Console.Write("{0} | ",j);
                        }
                        Console.WriteLine();
                        Console.Write("Press any key to continue... ");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Nhập sai! Mời chọn lại!");
                        Console.ReadKey();
                    break;
                }
            }while(choice != 0);
        }
    }
}
