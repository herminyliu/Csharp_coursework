using System;

namespace _3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] data = input.Split();
            Point p1 = new Point(int.Parse(data[0]), int.Parse(data[1]));
            Point p2 = new Point(int.Parse(data[2]), int.Parse(data[3]));
            Line line0 = new Line();
            Line line1 = new Line(p1, p2);
            Line line2 = new Line(3, 4, 5, 6);
            line0.Show();
            line1.Show();
            line2.Show();
        }
        class Point
        {
            private double x;
            private double y;
            public double X
                { get { return x; } set { x = value; } }
            public double Y
                { get { return y; } set { y = value; } }
            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
        }
        class Line
        {
            readonly private Point p1;
            readonly private Point p2;
            public Line(int x1,int y1,int x2,int y2)
            {
                p1 = new Point(x1, y1);
                p2 = new Point(x2, y2);               
            }
            public Line(Point p1, Point p2)
            {
                this.p1 = p1;
                this.p2 = p2;
            }
            public Line()
            {
                p1 = new Point(0, 0);
                p2 = new Point(0, 0);
            }
            public double Distance()
            {
                return Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));
            }
            public void Show()
            {
                Console.WriteLine("{0:F2}",Distance());
            }
        }
    }
}