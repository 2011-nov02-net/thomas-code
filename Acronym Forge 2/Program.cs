using System;

namespace AcronymForge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a multiword term to be hammered into an acronym:");
            string input  = Console.ReadLine();
            Array.ForEach(input.Split(' '), s => Console.Write(s[0] + "."));
            Console.WriteLine();
        }
    }
}