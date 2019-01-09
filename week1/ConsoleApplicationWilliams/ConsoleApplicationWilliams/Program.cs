using System;

namespace ConsoleApplicationWilliams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWhat is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"\nHello {name}!");

            int day = DateTime.Now.DayOfYear;

            Console.Write("Day of year: ");
            Console.WriteLine(day);
        }
    }
}
