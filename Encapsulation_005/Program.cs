using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_005
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A1 = new Point(1,1,"A1");
            Point B1 = new Point(2,3,"B1");
            Point C1 = new Point(3,1,"C1");

            Shape triangle = new Shape(A1, B1, C1) { Name = "triangle" };
            //triangle.Points = new Point[] { A1, B1, C1 };
            triangle.Perimetr();

            Point A2 = new Point(1, 1, "A2");
            Point B2 = new Point(1, 3, "B2");
            Point C2 = new Point(3, 3, "C2");
            Point D2 = new Point(3, 1, "D2");

            Shape square = new Shape(A2, B2, C2, D2) { Name = "square" };
            //square.Points = new Point[] { A2, B2, C2, D2 };
            square.Perimetr();

            Point A3 = new Point(1, 1, "A3");
            Point B3 = new Point(1, 3, "B3");
            Point C3 = new Point(5, 1, "C3");
            Point D3 = new Point(5, 3, "D3");

            Shape rectangle = new Shape(A3, B3, C3, D3) { Name = "rectangle" };
            //rectangle.Points = new Point[] { A3, B3, C3, D3 };
            rectangle.Perimetr();

            Console.ReadKey();
        }
    }
}
