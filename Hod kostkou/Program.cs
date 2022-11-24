using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hod_kostkou
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Alea iacta est");
            Console.WriteLine("Pro další hod stiskněte Enter, pro konec házení zadejte stop");
            var kostka = new Dictionary<int, string>
            {
                { 1, "_______\n|     |\n|  x  |\n|     |\n¯¯¯¯¯¯¯" },
                { 2, "_______\n|     |\n| x x |\n|     |\n¯¯¯¯¯¯¯" },
                { 3, "_______\n|  x  |\n| x x |\n|     |\n¯¯¯¯¯¯¯" },
                { 4, "_______\n| x x |\n|     |\n| x x |\n¯¯¯¯¯¯¯" },
                { 5, "_______\n| x x |\n|  x  |\n| x x |\n¯¯¯¯¯¯¯" },
                { 6, "_______\n| x x |\n| x x |\n| x x |\n¯¯¯¯¯¯¯" },
            };

            do
            {
                var hod = kostka.OrderBy(x => Guid.NewGuid()).Take(1);
                foreach (KeyValuePair<int, string> i in hod)
                {
                    Console.WriteLine(i.Value);
                    Console.WriteLine();
                }
            } while (Console.ReadLine() != "stop");
        }
    }
}