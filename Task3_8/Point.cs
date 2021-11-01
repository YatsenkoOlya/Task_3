using System;
namespace Task3_8
{
    class Point
    {
        private double x;
        private double y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double GetX()
        {
            return x;
        }
        public void SetX(double x)
        {
            this.x = x;
        }
        public double GetY()
        {
            return y;
        }
         public void Print()
         {
            Console.WriteLine("Point x = " + x + ", " + "y = " + y);
         }
    }
}