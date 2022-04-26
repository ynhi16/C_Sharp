// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class daGiac
    {
        float a1, a2;
        float b1, b2;
        float c1, c2;
        float d1, d2;

    }
    class diem
    {
        float x1,x2;
        float y1,y2;
        public double khoangCach(float x, float y)
        {
           return System.Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        }
    }
    class hinhThang:daGiac
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}