﻿using System;
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
            string fullPath = filePath + "\\" + "Adventurer.txt";
            using (var stream = File.Open(fullPath, FileMode.Create))
            { }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(fullPath, true))
            {
                file.WriteLine("DO NOT EDIT THIS FILE UNLESS YOU WANT TO CHEAT");
                // line 2
                file.WriteLine(Health);
                // line 3
                file.WriteLine(Stamina);
                // line 4
                file.WriteLine(Hunger);
                file.WriteLine("Current chapter: ");
                // line 6
                file.WriteLine(CrntChptr);
                file.WriteLine("Class: ");
                //line 8
                file.WriteLine(ChrctrClass);
            }
        }
        public void Stats()
        {
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "CURRENT STATS:\n", Console.BackgroundColor = ConsoleColor.Cyan, Console.ForegroundColor = ConsoleColor.Black);
            Console.WriteLine("Health: " + Health, Console.BackgroundColor = ConsoleColor.Black, Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine("Stamina: " + Stamina, Console.BackgroundColor = ConsoleColor.Black, Console.ForegroundColor = ConsoleColor.Blue);
            Console.WriteLine("Hunger: " + Hunger, Console.BackgroundColor = ConsoleColor.Black, Console.ForegroundColor = ConsoleColor.DarkYellow);
            Console.ResetColor();
        }
    }
}
