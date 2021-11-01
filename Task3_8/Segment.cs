using System;

namespace Task3_8
{
    class Segment
    {
        private Point startPoint;
        private Point endPoint;
        private double length;
        public Segment(Point startPoint, Point endPoint)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
            this.length = Math.Sqrt(
                Math.Pow(Math.Abs(endPoint.GetX() - startPoint.GetX()), 2) +
                Math.Pow(Math.Abs(endPoint.GetY() - startPoint.GetY()), 2)
                );
        }
        public void Print()
        {
            Console.WriteLine("Segment [");
            Console.WriteLine("length = " + length);
            Console.WriteLine("]");
        }
        public void SetLength(double length)
        {
            this.length = length;
        }
        public double GetLength()
        {
            return length;
        }
    }
}