using System;
using System.Xml.Linq;

namespace ConsoleAppChapter12
{
    class Program
    {
        static void Main(string[] args)
        {

            var tuple = (10, "text");
            int e;
            string f;
            (e, f) = tuple;

            Console.ReadLine();
        }
    }
}
