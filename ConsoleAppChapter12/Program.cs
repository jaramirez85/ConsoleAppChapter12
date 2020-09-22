using System;
using System.Xml.Linq;

namespace ConsoleAppChapter12
{
    static class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.UtcNow;
            var (year, month, day) = now;

            //Listing 12.9 Using Deconstruct overloads

            //DateTime birthday = new DateTime(1976, 6, 19);
            //DateTime now = DateTime.UtcNow;
            //var (year, month, day, hour, minute, second) = now; --Uses the six-value deconstructor
            //(year, month, day) = birthday;  --Uses the three-value deconstructor

            Console.WriteLine($"{year:0000}-{month:00}-{day:00}");

            Console.ReadLine();
        }

        static void Deconstruct(this DateTime dateTime, out int year, out int month, out int day)
            => (year, month, day) = (dateTime.Year, dateTime.Month, dateTime.Day);

        static void Deconstruct(this DateTime dateTime, out int year, out int month, out int day, out int hour, out int minute, out int second) =>
            (year, month, day, hour, minute, second) = (dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second);
    }
}
