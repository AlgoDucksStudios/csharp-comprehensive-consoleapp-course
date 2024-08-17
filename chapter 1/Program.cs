using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {

        static volatile bool run = true;

        static void Main(string[] args)
        {

            Console.WriteLine("hello");

            // input("enter your name: ")           enter your name: Alireza
            Console.Write("enter your name: ");
            string name = Console.ReadLine();

            Console.Beep();
            Thread.Sleep(1000);
            Console.Beep();
            Thread.Sleep(1000);
            Console.Beep();

            // the keyboard interrupt (Ctrl+C)
            Console.CancelKeyPress += new ConsoleCancelEventHandler(Console_Interrupt);

            while (run)
            {
                Console.WriteLine($"Loop is running {DateTime.Now}");
                Thread.Sleep(3000);
            }


            string str1 = "foo";
            string str2 = "bar";
            string str3 = "baz";

            Console.WriteLine("Hello, {0}, {1}, {2}, {0}", name, str2, str1);

            Console.WriteLine($"Hello, {name}");

            Console.Title = $"The name is {name}";


            int chararacter = Console.Read();

            Console.WriteLine(chararacter);
            Console.WriteLine((char)chararacter);

            var key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.Escape)
            {
                return;
            }

            Console.ReadKey();

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("BYE BYE");


            Console.ReadKey();
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ResetColor();



            Console.WriteLine("Hello Again!");
            Console.WriteLine("Hello Again!");
            Console.WriteLine("Hello Again!");
            Console.WriteLine("Hello Again!");
            Console.WriteLine("Hello Again!");
            Console.WriteLine("Hello Again!");
            Console.WriteLine("Hello Again!");
            Console.WriteLine("Hello Again!");
            Console.WriteLine("Hello Again!");
            Console.WriteLine("Hello Again!");

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Hello Again!");
            Console.WriteLine("Hello Again!");
            Console.WriteLine("Hello Again!");
            Console.WriteLine("Hello Again!");


            Console.ReadKey();
        }

        private static void Console_Interrupt(object sender, ConsoleCancelEventArgs e)
        {
            e.Cancel = true;
            run = false;
        }
    }
}
