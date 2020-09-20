using System;

namespace ConsoleAppChapter12
{
    class Program
    {
        static void Main(string[] args)
        {
            var tuple = (10, "text");
            
            (int c, string d) = tuple;

            (int c, string d) x = tuple;

            Console.WriteLine($"c: { c }");
            Console.WriteLine($"d: { d }");
            Console.WriteLine($"x.c: { x.c }");
            Console.WriteLine($"x.d: { x.d }");

            Console.ReadLine();
        }
    }
}
