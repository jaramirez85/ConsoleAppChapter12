using System;
using System.Text;
using System.Xml.Linq;

namespace ConsoleAppChapter12
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder builder = new StringBuilder("12345");
            StringBuilder original = builder;
            (builder, builder.Length) = (new StringBuilder("67890"), 3);
            Console.WriteLine(original);
            Console.WriteLine(builder);

            //not all tuple literals have a type. For example, the tuple
            //literal(null, x => x * 2) doesn’t have a type because neither of its element expressions
            //has a type.
            (string text, Func<int, int> func) = (null, x => x * 2);
            (text, func) = ("text", x => x * 3);

            Console.ReadLine();
        }

    }
}
