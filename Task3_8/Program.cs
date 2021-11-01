using System;
using System.Collections.Generic;

namespace Task3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(0.0, 0.0);
            Point p2 = new Point(0.0, 4.0);
            Point p3 = new Point(4.0, 4.0);
            Point p4 = new Point(4.0, 0.0);

            List<Point> points = new List<Point>();
            points.Add(p1);
            points.Add(p2);
            points.Add(p3);
            points.Add(p4);

            Square square1 = new Square(points);

            square1.Print();

            square1.ChangeRotateAngle(90);
            square1.ChangeColor(Color.RED);
            square1.Stretch(2);

            square1.Compress(4);

            square1.Print();

            Console.ReadLine();
        }
    }
}


