using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace BT3
{
    class People
    {
        public int SID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

    }
    class Student : People
    {
        public string Lop { get; set; }
        public string Khoa { get; set; }
        public double DiemTB { get; set; }

        public void HienThi()
        {
            Console.WriteLine("Ma Sinh Vien: " + SID);
            Console.WriteLine("Ho Ten: " + Name);
            Console.WriteLine("Tuoi: " + Age);
            Console.WriteLine("Gioi Tinh: " + Gender);
            Console.WriteLine("Lop: " + Lop);
            Console.WriteLine("Khoa: " + Khoa);
            Console.WriteLine("Diem trung binh: " + DiemTB);
        }
        public static void listStudent(int n)
        {
            Student std = new Student();
            List<Student> students = new List<Student>();
            Console.WriteLine("========== Nhập thông tin sinh viên ==========");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Sinh vien thu: " + i);
                Console.Write(" Ma Sinh Vien: ");
                std.SID = int.Parse(Console.ReadLine());
                Console.Write(" Ho Ten: ");
                std.Name = Console.ReadLine();
                Console.Write(" Tuoi: ");
                std.Age = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Gioi Tinh: ");
                std.Gender = Console.ReadLine();
                Console.Write(" Lop: ");
                std.Lop = Console.ReadLine();
                Console.Write(" Khoa: ");
                std.Khoa = Console.ReadLine();
                Console.Write(" Diem trung binh: ");
                std.DiemTB = Convert.ToDouble(Console.ReadLine());
                students.Add(std);
                std = new Student();
            }
            Console.WriteLine("========== Hiển thị thông tin sinh viên ==========");
            for (int i = 0; i < n; i++)
            {
                students.ElementAt(i).HienThi();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        public static void arrListStudent(int n)
        {
            Student std = new Student();
            ArrayList students = new ArrayList();
            Console.WriteLine("========== Nhập thông tin sinh viên ==========");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Sinh vien thu: " + i);
                Console.Write(" Ma Sinh Vien: ");
                std.SID = int.Parse(Console.ReadLine());
                Console.Write(" Ho Ten: ");
                std.Name = Console.ReadLine();
                Console.Write(" Tuoi: ");
                std.Age = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Gioi Tinh: ");
                std.Gender = Console.ReadLine();
                Console.Write(" Lop: ");
                std.Lop = Console.ReadLine();
                Console.Write(" Khoa: ");
                std.Khoa = Console.ReadLine();
                Console.Write(" Diem trung binh: ");
                std.DiemTB = Convert.ToDouble(Console.ReadLine());
                students.Add(std);
                std = new Student();
            }
            Console.WriteLine("========== Hiển thị thông tin sinh viên ==========");
            foreach (Student student in students)
            {
                student.HienThi();
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.Write("Nhap so sinh vien: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("1.List 2.Arraylist ");
                int kieu = int.Parse(Console.ReadLine());
                switch (kieu)
                {
                    case 1:
                        listStudent(n);
                        break;
                    case 2:
                        arrListStudent(n);
                        break;
                    default:
                        Console.WriteLine("Vui lòng nhập lại");
                        break;
                }

            }
        }
    }
}
