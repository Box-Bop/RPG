﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;
            while (menu == true)
            {
                var optn1 = new MenuDec();
                var enter1 = new Game();
                // System.Threading.Thread.Sleep(5000);  <--- text delay
                // Player stats: health, stamina, hunger.
                // Possible roles: Rogue, Wizard, Monk, Barbarian, Ranger
                Console.WriteLine("---WELCOME---\n\n", Console.BackgroundColor = ConsoleColor.Yellow, Console.ForegroundColor = ConsoleColor.Black);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1| NEW GAME\n\n2| LOAD GAME\n\n3| EXIT");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nTHIS GAME DOES NOT SUPPORT MULTIPLE SAVES!\n");
                Console.ResetColor();
                bool newGameLoop = true;
                string option1 = Console.ReadLine();
                if (option1 == "1")
                {
                    Console.Clear();
                    if (File.Exists(Directory.GetCurrentDirectory() + @"\" + "Adventurer.txt"))
                    {
                        while (newGameLoop == true)
                        {
                            Console.WriteLine("ARE YOU SURE YOU WANT TO MAKE A NEW GAME?\n");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("THIS WILL DELETE YOUR CURRENT SAVE!\n");
                            Console.ResetColor();
                            Console.WriteLine("1| Yes\n2| No");
                            string confirm = Console.ReadLine();
                            if (confirm == "1")
                            {
                                Console.Clear();
                                newGameLoop = false;
                                optn1.optn = 1;
                                optn1.Health = 100;
                                optn1.Stamina = 50;
                                optn1.Hunger = 10;
                                optn1.CrntChptr = 1;
                                optn1.ChrctrClass = 0;
                                optn1.Made();
                                enter1.Enter();
                            }
                            if (confirm == "2")
                            {
                                Environment.Exit(0);
                            }
                            if (confirm != "1" && confirm != "2")
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid option.\n");
                                Console.ResetColor();
                            }
                            
                        }

                    }
                    optn1.optn = 1;
                    optn1.Health = 100;
                    optn1.Stamina = 50;
                    optn1.Hunger = 10;
                    optn1.CrntChptr = 1;
                    optn1.ChrctrClass = 0;
                    optn1.Made();
                }
                if (option1 == "2")
                {
                    if (!File.Exists(Directory.GetCurrentDirectory() + @"\" + "Adventurer.txt"))
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No save found.\n");
                    }
                    if (File.Exists(Directory.GetCurrentDirectory() + @"\" + "Adventurer.txt"))
                    {
                        Console.Clear();
                        optn1.optn = 2;
                        enter1.Enter();
                    }
                }
                if (option1 == "3")
                {
                    Environment.Exit(0);
                }
                if (option1 != "1" && option1 != "2" && option1 != "3")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option.\n");
                    Console.ResetColor();
                }
            }
            Console.ReadKey();
        }
    }
}
