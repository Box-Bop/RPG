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
            // ---BATTLE SITUATION---
            //Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "CURRENT STATS:\n", Console.BackgroundColor = ConsoleColor.Cyan, Console.ForegroundColor = ConsoleColor.Black);
            //Console.WriteLine("Health: " + character.Health, Console.BackgroundColor = ConsoleColor.Black, Console.ForegroundColor = ConsoleColor.Red);
            //Console.WriteLine("Stamina: " + character.Stamina, Console.BackgroundColor = ConsoleColor.Black, Console.ForegroundColor = ConsoleColor.Blue);
            //Console.WriteLine("Hunger: " + character.Hunger, Console.BackgroundColor = ConsoleColor.Black, Console.ForegroundColor = ConsoleColor.DarkYellow);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---GAME INFO---\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nThis game saves on a chapter basis, if you leave half way through, your progress will be lost. Though you may leave when a new chapter starts.");
            Console.WriteLine("\nThis is a text adventure role-playing game, options are limited as this is not a game with 3D graphics.\nEnjoy the game!");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nPress Enter to continue.");
            Console.ReadLine();
            if (character.CrntChptr == 1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("---CHAPTER ONE---\n");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Hello?\nHellloooo!\nWake up!\nGod, I don't want another dead body in my back yard..");
                Console.ResetColor();
                Console.WriteLine("You hear this as you're slowly gaining back conciousness. Another dead body?\nYou jerk up, coughing, noticing that you were lying on a bed.");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Awh, thank goodness");
            }


            Console.ReadLine();
        }
    }
}
