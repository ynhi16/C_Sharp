// See https://aka.ms/new-console-template for more information
using System;

namespace BTPT
{
    class PhuongTrinh
    {
        public double a_14
        {
            set; get;
        }
        public double b_14
        {
            set; get;
        }
        public double c_14
        {
            set; get;
        }

        public PhuongTrinh(double a_14, double b_14, double c_14)
        {
            this.a_14 = a_14;
            this.b_14 = b_14;
            this.c_14 = c_14;
        }

        public PhuongTrinh()
        {
            a_14 = 1;
            b_14 = -6;
            c_14 = -5;
        }

        
        public double delta(double a_14, double b_14, double c_14)
        {
            double delta = b_14 * b_14 - 4 * a_14 * c_14;
            return delta;
        }
        public void nghiem(double a, double b, double c, double delta)
        {
            
            if (delta > 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem : ");
                Console.WriteLine("X1 = {0}", ((-b - Math.Sqrt(delta)) / 2 * a));
                Console.WriteLine("X2 = {0}", ((-b + Math.Sqrt(delta)) / 2 * a));

            }
            else if (delta == 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem kep nghiem");
                Console.WriteLine("X1 = X2 {0}", -b / 2 * a);
            }
            else if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }


        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double a_14, b_14, c_14, delta_14;
            Console.WriteLine("Nhap vao so a:");
            a_14 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so b:");
            b_14 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so c:");
            c_14 = float.Parse(Console.ReadLine());
            PhuongTrinh pt_14 = new PhuongTrinh();
            delta_14 = pt_14.delta(a_14, b_14, c_14);
            pt_14.nghiem(a_14, b_14, c_14, delta_14);
        }

    }
}
