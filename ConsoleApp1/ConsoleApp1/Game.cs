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
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\"Hello?\nHellloooo!\nWake up!\nGod, I don't want another dead body in my back yard..\"");
                Console.ResetColor();
                Console.WriteLine("You hear this as you're slowly gaining back conciousness. Another dead body?\nYou jerk up, coughing, noticing that you were lying on a bed.");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\"Awh, thank goodness, you're awake. Hold on a second.\"");
                Console.ResetColor();
                Console.WriteLine("Before you can even speak a word, the mysterious woman offers you soup.\n\nYour current hunger is at 10 (max: 25)");
                bool deci1 = true;
                while (deci1 == true)
                {
                    Console.WriteLine("Will you accept her generous offer?\n\n1| Yes\n2| No");
                    string dec1 = Console.ReadLine();
                    if (dec1 == "1")
                    {
                        character.Hunger = Convert.ToInt16(File.ReadLines(fullPath).Skip(3).Take(1).First()) + 11;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("You regained 11 hunger!");
                        Console.ResetColor();
                        deci1 = false;
                        Console.WriteLine("You nod, and she proceeds to feed you her soup. It's barely warm, seems that she expected you to wake up earlier. \nThe taste of it isn't as bad as it smelled though, which is great.\nYou gesture the lady to stop feeding you, swallow the last bit of soup you had in your mouth.");
                    }
                    if (dec1 == "2")
                    {
                        Console.WriteLine("You gesture to her that you do not want her soup. She looks at you with\n an upset face, and places the bowl down on a table.");
                        deci1 = false;
                    }
                    if (dec1 != "1" && dec1 != "2")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid option.");
                        Console.ResetColor();
                    }
                    Console.WriteLine("You begin to think of the situation you're in; no memory of the \npast few nights, and you're in this random house with an old lady.");
                    Console.WriteLine("You decide to start asking her a few questions: \n");
                    bool questi1 = true;
                    bool questi2 = true;
                    bool questi3 = true;
                    int quest1amnt = 0;
                    bool questi1bon = false;
                    while (quest1amnt <= 3)
                    {
                        if (questi1 == true)
                        {
                            Console.WriteLine("1| How did I end up here?");
                        }
                        if (questi2 == true)
                        {
                            Console.WriteLine("2| Who are you?");
                        }
                        if (questi3 == true)
                        {
                            Console.WriteLine("3| Where am I?");
                        }
                        if (questi1bon == true)
                        {
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("4| Where's this town located that you mentioned?");
                        }
                        string quest1ans = Console.ReadLine();
                        if (quest1ans == "1" && questi1 == true)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n\"How did I end up here?\n");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("\"Well, I was coming back from the nearest with my groceries, and I stumbled upon you.\nYou were lying on the cold hard ground. I tried to wake you \nup on the spot, but you weren't reacting at all. So I decided to \ntake you and nurse you.\"");
                            Console.ResetColor();
                            questi1bon = true;
                            quest1amnt += 1;
                        }
                        if (quest1ans == "2" && questi2 == true)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n\"Who are you?\"");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("\"Well, people have different opinions on who I am, \"");
                        }
                        if (quest1ans == "3" && questi3 == true)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n\"Where am I?\"");

                        }
                        if (quest1ans == "4" && questi1bon == true)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\"Where's this town located that you mentioned?\n");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("\"Oh that? It's to the east of the front door when you walk out. It'll take you quite \nsome time to get there if you're traveling by foot.\nI'd say around 2 hours.\"");
                            Console.ResetColor();
                        }
                        if (quest1ans != "1" && quest1ans != "2" && quest1ans != "3" && quest1ans != "4")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid option.");
                            Console.ResetColor();
                        }
                    }
                }
            }


            Console.ReadLine();
        }
    }
}
