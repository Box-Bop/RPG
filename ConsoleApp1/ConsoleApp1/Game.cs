using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Game : CrntProgress
    {
        public void Enter()
        {
            string fullPath = filePath + "\\" + "Adventurer.txt";
            var character = new CrntProgress();
            character.Health = Convert.ToInt16(File.ReadLines(fullPath).Skip(1).Take(1).First());
            character.Stamina = Convert.ToInt16(File.ReadLines(fullPath).Skip(2).Take(1).First());
            character.Hunger = Convert.ToInt16(File.ReadLines(fullPath).Skip(3).Take(1).First());
            character.CrntChptr = Convert.ToInt16(File.ReadLines(fullPath).Skip(5).Take(1).First());
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "CURRENT STATS:\n", Console.BackgroundColor = ConsoleColor.Cyan, Console.ForegroundColor = ConsoleColor.Black);
            Console.WriteLine("Health: " + character.Health, Console.BackgroundColor = ConsoleColor.Black, Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine("Stamina: " + character.Stamina, Console.BackgroundColor = ConsoleColor.Black, Console.ForegroundColor = ConsoleColor.Blue);
            Console.WriteLine("Hunger: " + character.Hunger, Console.BackgroundColor = ConsoleColor.Black, Console.ForegroundColor = ConsoleColor.DarkYellow);

            Console.ReadLine();
        }
    }
}
