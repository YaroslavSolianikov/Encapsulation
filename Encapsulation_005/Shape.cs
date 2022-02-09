using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_005
{
    class Shape
    {
        private Point[] points;
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Point[] Points
        {
            get { return points; }
            set { points = value; }
        }    
        public Shape(Point A, Point B, Point C)
        {
            points = new Point[3] {A,B,C};
        }
        public Shape(Point A, Point B, Point C, Point D)
        {
           points = new Point[4] { A, B, C, D };
        }
        private double Lenght(Point A, Point B) => Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
        public void Perimetr()
        {
            double p = 0;
            for (int i = 0; i < points.Length; i++)
            {
                p += Lenght(points[0], points[i]);
            }
            Console.WriteLine($"Perimetr of {name}: {p}");
        }
    }
}
