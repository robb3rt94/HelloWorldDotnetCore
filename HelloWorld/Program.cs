using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nWhat is your name? ");
            var nome = Console.ReadLine();
            var date = DateTime.Now;
            Console.Write($"\nHello, {nome}, on {date:d} at {date:t}!");
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}
