using System;
using System.Xml.Linq;

namespace ConsoleAppChapter12
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(2, 3);
            var (x, y) = point;
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");

            Console.ReadLine();
        }

        public sealed class Point
        {
            public double X { get; }
            public double Y { get; }
            public Point(double x, double y) => (X, Y) = (x, y);

            //The simplicity of this is beautiful
            public void Deconstruct(out double x, out double y) => (x, y) = (X, Y);
        }
    }
}
