using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class CrntProgress
    {
        public string filePath = Directory.GetCurrentDirectory();
        public int Health { get; set; }
        public int Stamina { get; set; }
        public int Hunger { get; set; }
        public int CrntChptr { get; set; }
        public int ChrctrClass { get; set; }

        public void Save()
        {



        }
        public void Stats()
        {
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "CURRENT STATS:\n", Console.BackgroundColor = ConsoleColor.Cyan, Console.ForegroundColor = ConsoleColor.Black);
            Console.WriteLine("Health: " + Health, Console.BackgroundColor = ConsoleColor.Black, Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine("Stamina: " + Stamina, Console.BackgroundColor = ConsoleColor.Black, Console.ForegroundColor = ConsoleColor.Blue);
            Console.WriteLine("Hunger: " + Hunger, Console.BackgroundColor = ConsoleColor.Black, Console.ForegroundColor = ConsoleColor.DarkYellow);
        }
    }
}
