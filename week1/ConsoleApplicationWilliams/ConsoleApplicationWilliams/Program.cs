using System;

namespace ConsoleApplicationWilliams
{
    class Program
    {
        static void Main(string[] args)
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("\nWhat is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"\nHello {name}!");

            DateTime day = DateTime.Now;

            DateTime christmas = new DateTime(2019, 12, 25);

            TimeSpan interval = christmas - day;

            Console.Write("Day of year: ");
            
            Console.WriteLine(day);

            Console.Write("Day until Christmas:");

            Console.WriteLine(interval.Days);

            Console.WriteLine("\nWhat is the width of your window");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("\nWhat is the height of your window");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");
        }
    }
}
