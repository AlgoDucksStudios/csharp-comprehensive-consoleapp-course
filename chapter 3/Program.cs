using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 100;
            Console.WriteLine($"Buffer: \n\tWidth (the columns): {Console.BufferWidth}" +
                $"\n\tHeight (the line count): {Console.BufferHeight}");

            Console.BufferWidth = 213; // max: 65535 (16 bit value type, 2 bytes)

            Console.ReadKey();

            Console.WindowHeight = 50;
            Console.BufferHeight = 50;
            Console.WriteLine($"Buffer: \n\tWidth (the columns): {Console.BufferWidth}" +
                $"\n\tHeight (the line count): {Console.BufferHeight}");

            Console.ReadKey();
        }
    }
}
