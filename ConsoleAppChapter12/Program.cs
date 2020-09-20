using System;
using System.Xml.Linq;

namespace ConsoleAppChapter12
{
    class Program
    {
        static void Main(string[] args)
        {

            //var _ = "Xavi";
            var tuple = (1, 2, 3, 4);
            var (x, y, _, _) = tuple;
            Console.WriteLine(_);

            Console.ReadLine();
        }
    }
}
