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
        static void Sxeptangdan (int[] a)
        {

        }
        static void Main(string[] args)
        {
            int i,j, mx, mn,tmp;
            int[] a = new int[100];
            nhap(a);
            xuat(a);
            mx = a[0];
            mn = a[0];
            
            Console.WriteLine(mn);
            for (i = 0; i < 10; i++)
            {
                if (a[i] > mx)
                {
                    mx = a[i];
                }


               
            }
            for (i = 0; i < 10; i++)
            {

                if (a[i] < mn)
                {
                    mn = a[i];
                    Console.WriteLine(mn);
                }
            }
            Console.Write("\nPhan tu lon nhat trong mang la: {0}\n", mx);
            Console.Write("Phan tu nho nhat trong mang la: {0}\n\n", mn);
            for (i = 0; i < 10; i++)
            {
                for (j = i + 1; j < 10; j++)
                {
                    if (a[j] < a[i])
                    {
                        //cach trao doi gia tri
                        tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }
            }
            Console.Write("\nIn cac phan tu mang theo thu tu tang dan:\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", a[i]);
            }
            for (i = 0; i < 10; i++)
            {
                for (j = i + 1; j < 10; j++)
                {
                    if (a[i] < a[j])
                    {
                        //cach trao doi gia tri
                        tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }
            }

            Console.Write("\nIn cac phan tu mang theo thu tu giam dan:\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", a[i]);
            }
            Console.ReadKey();
        }
    }
}
