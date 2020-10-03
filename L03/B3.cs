using System;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int i, j, k, max = 0;
            string str;
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
                        Console.WriteLine("Bài tập 1: Find max number");
                        int[,] arr = new int[3,4];
                        Console.WriteLine("Dãy số ngẫu nhiên là:");
                        for(j=0; j<4; j++)
                        {
                            for(i=0; i<3; i++)
                            {
                                arr[i, j] = random.Next();
                                Console.Write("{0} | ", arr[i,j]);
                                if(max < arr[i,j]) max = arr[i,j];
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("\nSố lớn nhất trong dãy là: {0}", max);
                        Console.Write("Press any key to continue... ");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Bài tập 2: Array Searching");
                        Console.Write("Mời nhập vào 1 số từ 0 - 99 để searching: ");
                        int search, s = 0;
                        int[] arr1 = new int[10];
                        search = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Dãy số ngẫu nhiên đã được khởi tạo:");
                        for(i=0; i<10; i++)
                        {
                            arr1[i] = random.Next(0, 99);
                            Console.Write("{0} | ", arr1[i]);
                            if(search == arr1[i]) s++;
                        }
                        if(s > 0){
                            Console.WriteLine("\nSố vừa nhập xuất hiện {0} lần trong dãy.",s);
                        }else Console.WriteLine("\nSố vừa nhập không xuất hiện trong dãy.");
                        Console.Write("Press any key to continue... ");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Bài tập 3: Copy Array");
                        Console.Write("Enter string: ");
                        string str1 = "";
                        str = Console.ReadLine();
                        for(i = str.Length-1; i >= 0; i--)
                        {
                            str1 += str[i];
                        }
                        Console.WriteLine(str1);
                        Console.Write("Press any key to continue... ");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Bài tập 4: Count the number of digit in string");
                        Console.Write("Mời nhập chuỗi string: ");
                        str = Console.ReadLine();
                        string str2=null;
                        int sum=0;
                        for(i = 0; i<str.Length; i++)
                        {
                            if(str[i] > 48 && str[i] <= 57)
                            {
                                str2 = "";
                                while(str[i] > 48 && str[i] <= 57)
                                {
                                    str2 += str[i];
                                    i++;
                                }
                                sum += Convert.ToInt32(str2);
                            }
                        }
                        Console.WriteLine("Sum of all Digits in the String: "+ sum);
                        Console.Write("Press any key to continue... ");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Bài tập 5: Frequency of elements in array");
                        Console.Write("Input the number of elements to be stored in the array: ");
                        int n;
                        int[] arr3 = new int[99];
                        int[,] arr4 = new int[99,2];
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Input {0} elements in the array: ",n);
                        for(i=0; i<n;i++)
                        {
                            Console.Write("element - {0} : ", i);
                            arr3[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        k = 0;
                        for(i=0; i<n; i++)
                        {
                            if(k==0)
                            {
                                arr4[0,0] = arr3[i];
                                arr4[0,1] = 1;
                                k++;
                            }else{
                                for(j=0; j<k; j++)
                                {
                                    if(arr3[i] == arr4[j,0]){
                                        arr4[j,1] ++;
                                        break;
                                    }
                                    if(j == k-1)
                                    {
                                        arr4[k,0] = arr3[i];
                                        arr4[k,1] = 1;
                                        k++;
                                        j++;
                                    }
                                }
                            }
                        }
                        Console.WriteLine(k);
                        Console.WriteLine("Frequency of all elements of array:");
                        for(i=0; i<k; i++)
                        {
                            Console.WriteLine("{0} occurs {1} times", arr4[i,0], arr4[i,1]);
                        }
                        Console.Write("Press any key to continue... ");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Bài tập 6: Separate odd and even numbers");
                        Console.Write("Input the number of elements to be stored in the array: ");
                        int n1;
                        int[] arr5 = new int[99];
                        int[,] arr6 = new int[99,2];
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Input {0} elements in the array: ",n1);
                        j=0;
                        k=0;
                        for(i=0; i<n1;i++)
                        {
                            Console.Write("element - {0} : ", i);
                            arr5[i] = Convert.ToInt32(Console.ReadLine());
                            if(arr5[i]%2 == 0){
                                arr6[j,0] = arr5[i];
                                j++;
                            }else
                            {
                                arr6[k,1] = arr5[i];
                                k++;
                            }
                        }
                        Console.Write("The Even elements are:");
                        for(i=0; i<j; i++)
                        {
                            Console.Write(" "+arr6[i,0]);
                        }
                        Console.WriteLine();
                        Console.Write("The Odd elements are:");
                        for(i=0; i<k; i++)
                        {
                            Console.Write(" "+arr6[i,1]);
                        }
                        Console.WriteLine();
                        Console.Write("Press any key to continue... ");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Bài tập 7: Count the number of digit in string");
                        Console.Write("Mời nhập chuỗi: ");
                        int count = 0;
                        str = Console.ReadLine();
                        for(i=0; i<str.Length; i++)
                        {
                            if(str[i] == 'i'&& str[i+1]=='s')
                            {
                                count ++;
                                i++;
                            }
                        }
                        Console.WriteLine("Số lần xuất hiện của \"is\" la: "+count);
                        Console.Write("Press any key to continue... ");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Bài tập 8: Split strings in groups");
                        Console.Write("Mời nhập chuỗi: ");
                        str = Console.ReadLine();
                        string[] split = new string[10];
                        split = str.Split(" ");
                        j=1;
                        for(i=0; i<str.Length; i++)
                        {
                            if(str[i] == ' ') j++;
                        }
                        Console.WriteLine("Tách các từ:");
                        for(i=0; i<j; i++) Console.WriteLine(split[i]);
                        Console.Write("Press any key to continue... ");
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Bài tập 9: Count the words");
                        Console.Write("Mời nhập chuỗi: ");
                        str = Console.ReadLine();
                        for(i=0; i<str.Length; i++)
                        {
                            if(str[i]==' ' &&str[i-1] ==' '){
                                str = str.Replace("  "," ");
                                i--;
                            }
                        }
                        j=1;
                        for(i=0; i<str.Length; i++)
                        {
                            if(str[i] == ' ') j++;
                        }
                        if(str[0] == ' ') j--;
                        if(str[str.Length-1] ==' ') j--;
                        Console.WriteLine("Total number of words in the string is: "+j);
                        Console.Write("Press any key to continue... ");
                        Console.ReadKey();
                        break;
                    case 10:
                        Console.Clear();
                        Console.WriteLine("Bài tập 10: Find number of substring");
                        Console.Write("Input the original string: ");
                        str = Console.ReadLine();
                        Console.Write("Input the string to be searched for: ");
                        string Search;
                        Search = Console.ReadLine();
                        int count1 = 0;
                        for(i=0; i<str.Length; i++)
                        {
                            bool dk= true;
                            for(j=0; j<Search.Length; j++)
                            {
                                if(str[i+j] != Search[j]){
                                    dk = false;
                                    break;
                                }
                            }
                            if(dk) count1 ++;
                        }
                        Console.WriteLine("Số lần xuất hiện của \"{0}\" la: {1}",Search,count1);
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
