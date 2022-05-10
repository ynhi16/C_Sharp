// See https://aka.ms/new-console-template for more information
using System;

namespace mangdd
{
    internal class Program
    {
        static void nhap(int[] a)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("a[" + i + "] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void xuat(int[] a)
        {
            Console.Write("Hien thi mang:");
            for (int i = 0; i < 10; i++)
                Console.Write(a[i] + " ");
        }
        
        static void Main(string[] args)
        {
            int i, mx, mn;
            int[] a = new int[100];
            nhap(a);
            xuat(a);
            mx = a[0];
            mn = a[0];
            Console.WriteLine(mn);
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] > mx)
                {
                    mx = a[i];
                }


               
            }
            for (i = 0; i < a.Length; i++)
            {

                if (a[i] < mn)
                {
                    mn = a[i];
                    Console.WriteLine(mn);
                }
            }
            Console.Write("\nPhan tu lon nhat trong mang la: {0}\n", mx);
            Console.Write("Phan tu nho nhat trong mang la: {0}\n\n", mn);
            Console.ReadKey();
        }
    }
}
