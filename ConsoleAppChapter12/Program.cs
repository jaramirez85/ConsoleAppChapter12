using System;
using System.Xml.Linq;

namespace ConsoleAppChapter12
{
    class Program
    {
        static void Main(string[] args)
        {

            var point = new Point(2, 3);
            Console.WriteLine($"X: {point.X}");
            Console.WriteLine($"Y: {point.Y}");
            
            Console.ReadLine();
        }

        public sealed class Point
        {
            public double X { get; }
            public double Y { get; }
            public Point(double x, double y) => (X, Y) = (x, y);
        }
    }
}
