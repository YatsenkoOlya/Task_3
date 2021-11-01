using System;
using System.Collections.Generic;

namespace Task3_8
{
    enum Color
    {
        TRANSPARENT,
        GREY,
        RED,
        GREEN,
        YELLOW
    }
    class Square
    {
        private Color fillColor = Color.TRANSPARENT;
        private List<Segment> segments = new List<Segment>();
        private int rotateAngle = 0;
        public Square(List<Point> points)
        {
            InitSegments(points);
        }
        private void InitSegments(List<Point> points)
        {
            segments.Add(new Segment(points[0], points[1]));
            segments.Add(new Segment(points[1], points[2]));
            segments.Add(new Segment(points[2], points[3]));
            segments.Add(new Segment(points[3], points[0]));
        }
        public void ChangeColor(Color fillColor)
        {
            this.fillColor = fillColor;
        }
        public void ChangeRotateAngle(int rotateAngle)
        {
            this.rotateAngle = rotateAngle;
        }
        public void Print()
        {
            Console.WriteLine("Square [");
            Console.WriteLine("color = " + fillColor.ToString());
            Console.WriteLine("rotate angle = " + rotateAngle);

            foreach (Segment s in segments)
            {
                s.Print();
            }

            Console.WriteLine("]");
            Console.WriteLine();
        }
        public void Stretch(double k)
        {
            foreach (Segment s in segments)
            {
                s.SetLength(s.GetLength() * k);
            }
        }
        public void Compress(double k)
        {
            foreach (Segment s in segments)
            {
                s.SetLength(s.GetLength() / k);
            }
        }
    }
}