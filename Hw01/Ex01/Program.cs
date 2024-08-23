using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Writeline("Enter your name:");
            string name = Console.Readline();
            Console.Writeline($"Hello, {name}!");
        }
    }
}