using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nQual é o seu nome? ");
            var nome = Console.ReadLine();
            var data = DateTime.Now;
            Console.Write($"\nOlá, {nome}, em {data:d} às {data:t}!");
            Console.Write("\nAperte alguma tecla para saur...");
            Console.ReadKey(true);
        }
    }
}
