using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab01
{
    class Student
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;
        public Student() //Constructor mac dinh
        {
            SID = 1;
            TenSV = "Nguyen Van Nam";
            Khoa = "CNTT";
            DiemTB = 7;
        }
        public Student(Student stu) //Constructor sao chep
        {
            SID = stu.SID;
            TenSV = stu.TenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }
        //Constructor tham so
        public Student(int id, string ten, string kh, float dtb)
        {
            SID = id;
            TenSV = ten;
            Khoa = kh;
            DiemTB = dtb;
        }
        //Cac Property cho tung thuoc tinh cua lop
        public int StudentID //Property dai dien cho thuoc tinh SID
        {
            get { return SID; } //Lay du lieu
            set { SID = value; } //Gan du lieu
        }
        public String Name
        {
            get { return TenSV; }
            set { TenSV = value; }
        }
        public String Faculty
        {
            get { return Khoa; }
            set { Khoa = value; }
        }
        public float Mark
        {
            get { return DiemTB; }
            set { DiemTB = value; }
        }
        //Xuat
        public void Nhap1SV()
        {
            Console.Write("Nhap Ma SV:");
            SID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap Ho Ten:");
            TenSV = Console.ReadLine();
            Console.Write("Nhap Khoa:");
            Khoa = Console.ReadLine();
            Console.Write("Nhap Diem TB:");
            DiemTB = Convert.ToSingle(Console.ReadLine());
        }
        public void NhapDS(Student[] DSSV, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap Thong Tin SV THU " + (i + 1));
                DSSV[i] = new Student();
                DSSV[i].Nhap1SV();
            }
        }
        //Phuong thuc hien thi du lieu
        public void Xuat1SV()
        {
            Console.WriteLine("MSSV:{0}", this.SID);
            Console.WriteLine("Ten SV:{0}", this.TenSV);
            Console.WriteLine("Khoa:{0}", this.Khoa);
            Console.WriteLine("Diem TB:{0}", this.DiemTB);
        }
        public void XuatDS(Student[] DSSV, int n)
        {
            for (int i = 0; i < n; i++)
            {
                DSSV[i].Xuat1SV();
            }
        }
    }
    class Tester
    {
        public static void Main()
        {
            Student[] DSSV;
            int n;
            Student sv;
            sv = new Student();
            Console.Write("Nhap so luong SV: ");
            n = int.Parse(Console.ReadLine());
            DSSV = new Student[n]; //tao mang n phan tu
            // Nhap DS Sinh vien
            Console.WriteLine("\n ====NHAP DS SINH VIEN====");
            sv.NhapDS(DSSV,n);

            //Xuat DS Sinh vien
            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            sv.XuatDS(DSSV, n);
            Console.ReadLine();
        }
    }
}

