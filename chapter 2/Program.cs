using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WindowHeight = 50; // maximum value of the height

            Console.WindowWidth = 213; // maximum value of the width

            Console.WriteLine("Enter your Password:");
            if (Console.CapsLock)
            {
                Console.WriteLine("[X] Your CapsLock is ON...");
            }
            string passwd = ReadPasswd();
            Console.CursorLeft = 100;
            Console.CursorTop = 10;
            Console.WriteLine(passwd);

            Console.CursorSize = 1;

            Console.CursorLeft = 10;
            Console.CursorTop = 2;
            Console.WriteLine("Hello");

            Console.CursorVisible = false;

            Console.SetCursorPosition(10, 10);

            Console.Read();

            Console.ReadKey();
        }

        private static string ReadPasswd()
        {
            var sb = new StringBuilder();
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    sb.Append(key.KeyChar);
                    // Console.Write("*");
                }
                else if (key.Key == ConsoleKey.Backspace && sb.Length > 0)
                {
                    sb.Remove(sb.Length - 1, 1);
                    // Console.Write("\b \b");
                }
            } while (key.Key != ConsoleKey.Enter);

            return sb.ToString();
        }
    }
}
