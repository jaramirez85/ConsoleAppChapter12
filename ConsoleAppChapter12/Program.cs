using System;
using System.Xml.Linq;

namespace ConsoleAppChapter12
{
    class Program
    {
        static void Main(string[] args)
        {

            (int a, int b, string name) = MethodReturningTuple();
            //(int a, int b, var name) = MethodReturningTuple();   --implicit, explicit
            //(long a, int b, XNamespace name) = MethodReturningTuple(); --with convertions
            //var (a, b, name) = MethodReturningTuple();  --shorthand c#7

            Console.WriteLine($"a: {a}; b: {b}; name: {name}");

            Console.ReadLine();
        }

        static (int x, int y, string text) MethodReturningTuple() => (1, 2, "t");
    }
}
