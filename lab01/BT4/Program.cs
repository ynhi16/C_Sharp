using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    class ConNguoi
    {
        public string hoTen { get; set; }
        public int namSinh { get; set; }
        public string bangCap { get; set; }

        public virtual void Nhap()
        {
            Console.Write("Ho ten: "); 
            hoTen = Console.ReadLine();
            Console.Write("Nam sinh: "); 
            namSinh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bang cap: "); 
            bangCap = Console.ReadLine();
        }
        public virtual void HienThi()
        {
            Console.Write("Ho ten: ");
            Console.Write(hoTen);
            Console.Write("Nam sinh: ");
            Console.Write(namSinh);
            Console.Write("Bang cap ");
            Console.Write(bangCap);
        }
    }
    class NhaQuanLy:ConNguoi
    {
        public string chucVu { get; set; }
        public int soNgayCong { get; set; }
        public int bacLuong { get; set; }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Chuc Vu: ");
            chucVu = Console.ReadLine();
            Console.Write("So Ngay Cong: ");
            soNgayCong = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bac Luong: ");
            bacLuong = Convert.ToInt32(Console.ReadLine());
        }
        public override void HienThi()
        {
            base.HienThi();
            Console.Write("Chuc Vu: ");
            Console.Write(chucVu);
            Console.Write("So Ngay Cong: ");
            Console.Write(soNgayCong);
            Console.Write("Bac Luong: ");
            Console.Write(bacLuong);
        }
    }
    class NhaKhoaHoc : NhaQuanLy
    {      
        
        public int soBaiCongBo { get; set; }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("So Bai Cong Bo: ");
            soBaiCongBo = Convert.ToInt32(Console.ReadLine());
        }
        public override void HienThi()
        {
            base.HienThi();
            Console.Write("So Bai Cong Bo: ");
            Console.Write(soBaiCongBo);
        }
        public void Luong()
        {
            double luong;
            luong = soNgayCong * bacLuong;
            Console.WriteLine("Luong: " + luong);
        }
    }
    class NhanVien: ConNguoi
    {
        public double luong { get; set; }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Luong Trong Thang: ");
            luong = Convert.ToInt32(Console.ReadLine());
        }
        public override void HienThi()
        {
            base.HienThi();
            Console.Write("Luong Trong Thang: ");
            Console.Write(luong);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ConNguoi nv = new ConNguoi();
            List<ConNguoi> nhanvien = new List<ConNguoi>();
            Console.Write("Nhap so luong nhan vien:  ");
            int soLuong = int.Parse(Console.ReadLine());
            for (int i = 1; i <= soLuong; i++)
            {
                Console.WriteLine();
                Console.WriteLine("1. Nha khoa hoc");
                Console.WriteLine("2. Nha quan ly");
                Console.WriteLine("3. Nhan vien phong thi nghiem");
                Console.Write("Chọn đối tượng ");
                int model = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("======= Nhap thong tin nhan vien thu  {0} =======", i);
                switch (model)
                {
                    case 1:
                        Console.WriteLine("Them nha khoa hoc ");
                        nv = new NhaKhoaHoc();
                        break;
                    case 2:
                        Console.WriteLine("Them nha quan ly");
                        nv = new NhaQuanLy();
                        break;
                    case 3:
                        Console.WriteLine("Them nhan vien phong thi nghiem");
                        nv = new NhanVien();
                        break;
                }
                nv.Nhap();
                nhanvien.Add(nv);
            }
            Console.WriteLine("========== Hien thi thong tin nhan vien ==========");
            for (int i = 0; i < soLuong; i++)
            {
                nhanvien.ElementAt(i).HienThi();
                Console.WriteLine();
            }
            Console.WriteLine("========== Tong luong chi tra ==========");
            int luongQuanLy = 0, luongNKH = 0;
            double luongNhanVien = 0;

            for (int i = 0; i < soLuong; i++)
            {
                var staff1 = nhanvien.ElementAt(i);
                if (staff1 is NhanVien)
                {
                    luongNhanVien += (staff1 as NhanVien).luong;
                }
                else if (staff1 is NhaKhoaHoc)
                {
                    luongNKH += (staff1 as NhaKhoaHoc).bacLuong * (staff1 as NhaKhoaHoc).soNgayCong;
                }
                else
                {
                    luongQuanLy += (staff1 as NhaQuanLy).bacLuong * (staff1 as NhaQuanLy).soNgayCong;
                }
            }
            Console.WriteLine(String.Format("Luong nhan vien: {0} \nLuong quan ly: {1}\nLuong nha khoa hoc: {2}", luongNhanVien, luongQuanLy, luongNKH));
            Console.ReadKey();
        }
    }
    
}
