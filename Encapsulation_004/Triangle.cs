using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_004
{
    class Triangle
    {
        private double a;
        private double b;
        private double c;

        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        private double Perimetr() => a + b + c;
        private double Area()
        {
            double p = Perimetr() / 2;
            double area = Math.Sqrt(p * ((p - a) * (p - b) * (p - c)));
            return area;
        }
        public void Info() => Console.WriteLine($"Perimetr:{Perimetr()} \nArea:{Area()}");
    }
}
