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
            character.ChrctrClass = Convert.ToInt16(File.ReadLines(fullPath).Skip(7).Take(1).First());
            // ---BATTLE SITUATION---
            //Console.WriteLine("---BATTLE---", Console.BackgroundColor = ConsoleColor.Green);
            //Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "CURRENT STATS:\n", Console.BackgroundColor = ConsoleColor.Cyan, Console.ForegroundColor = ConsoleColor.Black);
            //Console.WriteLine("Health: " + character.Health, Console.BackgroundColor = ConsoleColor.Black, Console.ForegroundColor = ConsoleColor.Red);
            //Console.WriteLine("Stamina: " + character.Stamina, Console.BackgroundColor = ConsoleColor.Black, Console.ForegroundColor = ConsoleColor.Blue);
            //Console.WriteLine("Hunger: " + character.Hunger, Console.BackgroundColor = ConsoleColor.Black, Console.ForegroundColor = ConsoleColor.DarkYellow);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---GAME INFO---\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
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
                        character.Save();
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
                        Console.WriteLine("Invalid option.\n");
                        Console.ResetColor();
                    }
                    Console.WriteLine("You begin to think of the situation you're in; no memory of the \npast few nights, and you're in this random house with an old lady.");
                    Console.WriteLine("You decide to start asking her a few questions: \n");
                    bool questi1 = true;
                    bool questi2 = true;
                    bool questi3 = true;
                    int quest1amnt = 0;
                    bool questi1bon = false;
                    bool questi1add = false;
                    while (quest1amnt < 3)
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
                            Console.ResetColor();
                        }
                        string quest1ans = Console.ReadLine();
                        if (quest1ans == "1" && questi1 == true)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n\"How did I end up here?\n");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("\"Well, I was coming back from the nearest town with my groceries, and I stumbled upon you.\nYou were just lying there, on the ground. I tried to wake you \nup on the spot, but you weren't reacting at all. So I decided to \ntake you and nurse you.\"\n");
                            Console.ResetColor();
                            questi1bon = true;
                            quest1amnt += 1;
                            questi1 = false;
                        }
                        if (quest1ans == "2" && questi2 == true)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n\"Who are you?\"\n");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("\"Well, people have different opinions on who I am, but to most I'm just a lady out in these woods.\nI sell flowers for a living.\"\n");
                            Console.ResetColor();
                            quest1amnt += 1;
                            questi2 = false;
                        }
                        if (quest1ans == "3" && questi3 == true)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n\"Where am I?\"\n");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("\"You're in my house of course! And we're located in the middle of this forest.\"\n");
                            Console.ResetColor();
                            quest1amnt += 1;
                            questi3 = false;
                        }
                        if (quest1ans == "4" && questi1bon == true)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\"Where's this town located that you mentioned?\"\n");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("\"Oh that? It's to the east of the front door when you walk out. It'll take you quite \nsome time to get there if you're traveling by foot.\nI'd say around 2 hours.\"");
                            Console.ResetColor();
                            quest1amnt += 1;
                            questi1bon = false;
                            questi1add = true;
                        }
                        if (quest1ans != "1" && quest1ans != "2" && quest1ans != "3" && quest1ans != "4")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid option.\n");
                            Console.ResetColor();
                        }
                    }
                    Console.ResetColor();
                    Console.WriteLine("\nBefore you manage to ask another question, the lady interrupts you.");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\"I don't feel like answering any more of your questions, they're futile.\nNow, could you follow me outside?\"\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\"I want to wash my face first.\"");
                    Console.ResetColor();
                    Console.Write(" You say, as you look for a bathroom.");
                    Console.WriteLine(" The lady points at the bathroom, \nyou enter it, and close the door behind you.");
                    Console.WriteLine("You look into the mirror...");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\nPress Enter to continue.");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("---CLASS SELECTION---");
                    Console.ResetColor();
                    bool classselection = true;
                    while (classselection == true)
                    {
                        Console.WriteLine("\n\n\nYou don't quite recognize your own face, but since it's staring \nright back at you, you quickly accept how you look.\nYOU'RE A: \n");
                        Console.WriteLine("1| Rogue - A sneaky person with lightweight armour and daggers. Your sleight of hand \nwill allow you to pickpocket most creatures, and unlock even the toughest of locks.\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("2| Wizard - Most creatures fear of what you're capable of. The magic, and the illusions\nthat you can perform can fool even other wizards.\n");
                        Console.ResetColor();
                        Console.WriteLine("3| Monk - Your magical chants can provide you with temporary physical\nimprovements, and can also debuff your enemies.\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("4| Barbarian - Noone can escape the swings of your mighty war axe.\nYour war axe can be slammed against the ground to create a shockwave, that can knock enemies back.\n");
                        Console.ResetColor();
                        Console.WriteLine("5| Ranger - Have an enemy that is far away? No problem. Your trusty bow and arrow can\nallow you to target enemies near and far. Your survival skills let you survive any harsh weather condition.\n");
                        Console.WriteLine("Which class will you choose?");
                        string cclass = Console.ReadLine();
                        if (cclass == "1")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("\n\"Rogue\"");
                            Console.ResetColor();
                            Console.Write(" You mutter to yourself. It's quite obvious that you're a rogue, the lack of heavy armour, your sweet hoodie.\nSeems that a dagger and some pickpocketing tools are in your pocket. They'll come in handy. ");
                            character.ChrctrClass = 1;
                            classselection = false;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("\nPress Enter to continue.");
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                        }
                        if (cclass == "2")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("\n\"I'm a Wizard\"");
                            Console.ResetColor();
                            Console.Write(" You mutter to yourself. By your appearance, it's quite obvious that you're a wizard.\nThe blue robe, the slacky hood, your trusty staff. It all screams wizard...");
                            character.ChrctrClass = 2;
                            classselection = false;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("\nPress Enter to continue.");
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                        }
                        if (cclass == "3")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("\n\"Monk\"");
                            Console.ResetColor();
                            Console.Write(" You mutter to yourself. It's quite obvious that you're a monk, judging by\nthe looks. Slacky clother, yet they're clean. The long hair...");
                            classselection = false;
                            character.ChrctrClass = 3;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("\nPress Enter to continue.");
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                        }
                        if (cclass == "4")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("\n\"Barbarian\"");
                            Console.ResetColor();
                            Console.Write(" You mutter to yourself. Judging by the looks, it all screams barbarian. The heavy war axe\nthat is on your back, the body of a weightlifter. Can't believe that the old lady was able to get me inside her home.");
                            character.ChrctrClass = 4;
                            classselection = false;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("\nPress Enter to continue.");
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                        }
                        if (cclass == "5")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("\n\"Ranger\"");
                            Console.ResetColor();
                            Console.Write(" You mutter to yourself. It's quite obvious that you're a ranger. The longbow that is holstered on your back,\nyour trusty pointy arrows resting besides them. It all screams ranger.");
                            character.ChrctrClass = 5;
                            classselection = false;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("\nPress Enter to continue.");
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                        }
                        if (cclass != "1" && cclass != "2" && cclass != "3" && cclass != "4" && cclass != "5")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nInvalid option.");
                            Console.ResetColor();
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\"Hurry!\"\n");
                    Console.ResetColor();
                    Console.Write(" You hear, as you wash your face.");
                    Console.WriteLine(" You both walk outside. ");
                    bool repeat = true;

                        while (repeat == true)
                        {
                            Console.Write("As you do, you immediately look: \n\n1| West\n2| East\n3| North\n");
                            bool questi1dir = false;
                            string test = Console.ReadLine();
                            if (test == "2")
                            {
                                if (questi1add == true)
                                {
                                Console.WriteLine("Through the thick forest, you can make out some buildings, they truly are far away, just like the lady had said.");
                                questi1dir = true;
                                repeat = false;
                                }
                                else
                                {
                                Console.WriteLine("That side of the forest looks to be a little brighter than the rest, you don't know why...");
                                repeat = false;
                                }
                            }
                            
                            if (test == "1" || test == "3")
                            {
                                    Console.WriteLine("\nYou don't quite see anything special, just a lot of forest.");
                                    repeat = false;
                            }
                            if (test != "1" && test != "2" && test != "3")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nInvalid option.");
                                Console.ResetColor();
                            }

                        }
                    Console.WriteLine("The lady walks you to a house that isn't quite far from the house that you were just in.");
                    Console.WriteLine("The house looks half-built, and a lot larger than the house you woke up in.\n");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\"This is the house that I'm working on, it'll be a great \nupgrade from my old shack. It's perfectly made for two people aswell. \"\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\"Really? Who's going to be the second person occupying this \nlovely house?\"\n");
                    Console.ResetColor();
                    Console.Write("You ask, as the lady turns to look at you.\n\n");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\"It's ");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("gOI");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("NG TO B");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("E YOU!\"");
                    Console.ResetColor();
                    string chrctrWeapon = null;
                    if (character.ChrctrClass == 1)
                    {
                        chrctrWeapon = "daggers";
                    }
                    if (character.ChrctrClass == 2)
                    {
                        chrctrWeapon = "magic staff";
                    }
                    if (character.ChrctrClass == 3)
                    {
                        chrctrWeapon = "body for combat";
                    }
                    if (character.ChrctrClass == 4)
                    {
                        chrctrWeapon = "war axe";
                    }
                    if (character.ChrctrClass == 5)
                    {
                        chrctrWeapon = "bow and arrow";
                    }
                    Console.WriteLine("\nYou see the lady turning into a creature, some sort of bear-human hybrid.\nYou stand back, and prepare your {0}.", chrctrWeapon);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\nPress Enter to continue.");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Because of the element of surprise, the creature gets a hit on you.");
                    Console.Write("It deals");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" 12 ");
                    Console.ResetColor();
                    Console.Write("damage to you.\n");
                    int ldyhlth = 25;
                    int takendmg = 0;
                    int staminausd = 0;
                    int hungerlst = 0;
                    takendmg += 12;
                    character.Health = Convert.ToInt16(File.ReadLines(fullPath).Skip(1).Take(1).First()) - takendmg;
                    takendmg = 0;
                    string attck2 = "2| Punch it with your hands.";
                    string attck3 = "3| Run away.";
                    bool battle = true;
                    bool fairwin = false;
                    while (battle == true)
                    {
                        // Classes: Rogue (1), Wizard (2), Monk (3), Barbarian (4), Ranger (5)
                        if (character.ChrctrClass == 1)
                        {
                            while (true)
                            {
                                Console.WriteLine("1| Run towards it and stab it with your daggers.\n{0}\n{1}\n", attck2, attck3);
                                character.Stats();
                                string bttlactn = Console.ReadLine();
                                if (bttlactn == "1")
                                {
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("---BATTLE---", Console.ForegroundColor = ConsoleColor.Green);
                                    Console.ResetColor();
                                    Console.Write("You dash towards the creature, and stab it twice with your daggers.\nYou dealed ");
                                    Console.Write(" 8 ", Console.ForegroundColor = ConsoleColor.Red);
                                    Console.ResetColor();
                                    Console.Write("damage to it.\n");
                                    staminausd += 5;
                                    hungerlst += 2;
                                    character.Stamina = Convert.ToInt16(File.ReadLines(fullPath).Skip(2).Take(1).First()) - staminausd;
                                    character.Hunger = Convert.ToInt16(File.ReadLines(fullPath).Skip(3).Take(1).First()) - hungerlst;
                                    ldyhlth -= 8;
                                    if (ldyhlth < 1)
                                    {
                                        fairwin = true;
                                        battle = false;
                                        goto Ldywin;
                                    }
                                    Console.Write("The creature attacks back, and manages to deal");
                                    Console.Write(" 12 ", Console.ForegroundColor = ConsoleColor.Red);
                                    Console.ResetColor();
                                    Console.Write("damage to you.\n");
                                    takendmg = 0;
                                    takendmg += 12;
                                    character.Health = Convert.ToInt16(File.ReadLines(fullPath).Skip(1).Take(1).First()) - takendmg;
                                    if (character.Health < 1)
                                    {
                                        Console.Clear();
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    if (character.Stamina < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You became too tired to battle on.");
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    if (character.Hunger < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You can't fight with your stomach empty.");
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                }
                                if (bttlactn == "2")
                                {
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("---BATTLE---", Console.ForegroundColor = ConsoleColor.Green);
                                    Console.ResetColor();
                                    Console.Write("That wasn't quite effective, you only managed to deal ");
                                    Console.Write(" 4 ", Console.ForegroundColor = ConsoleColor.Red);
                                    Console.ResetColor();
                                    Console.Write("damage to it.");
                                    staminausd += 5;
                                    hungerlst += 2;
                                    character.Stamina = Convert.ToInt16(File.ReadLines(fullPath).Skip(2).Take(1).First()) - staminausd;
                                    character.Hunger = Convert.ToInt16(File.ReadLines(fullPath).Skip(3).Take(1).First()) - hungerlst;
                                    character.Save();
                                    ldyhlth -= 4;
                                    if (ldyhlth < 1)
                                    {
                                        fairwin = true;
                                        battle = false;
                                        goto Ldywin;
                                    }
                                    Console.Write("The creature attacks back, and manages to deal");
                                    Console.Write(" 12 ", Console.ForegroundColor = ConsoleColor.Red);
                                    Console.ResetColor();
                                    Console.Write("damage to you.\n");
                                    takendmg = 0;
                                    takendmg += 12;
                                    character.Health = Convert.ToInt16(File.ReadLines(fullPath).Skip(1).Take(1).First()) - takendmg;
                                    character.Save();
                                    if (character.Health < 1)
                                    {
                                        Console.Clear();
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    if (character.Stamina < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You became too tired to battle on.");
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    if (character.Hunger < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You can't fight with your stomach empty.");
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                }
                                if (bttlactn == "3")
                                {
                                    staminausd += 12;
                                    hungerlst += 7;
                                    character.Stamina = Convert.ToInt16(File.ReadLines(fullPath).Skip(2).Take(1).First()) - staminausd;
                                    character.Hunger = Convert.ToInt16(File.ReadLines(fullPath).Skip(3).Take(1).First()) - hungerlst;
                                    character.Save();
                                    if (character.Stamina < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("In the hopes of escaping, you bacame too tired, and therefore, the creature manages to enslave you.");
                                        Console.Write("\nGame over.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    if (character.Hunger < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("In the hopes of escaping, you became too hungry to continue to live.");
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);

                                        fairwin = false;
                                        goto Ldywin;
                                    }
                                }
                            }
                        }
                        if (character.ChrctrClass == 2)
                        {
                            while (true)
                            {
                                Console.WriteLine("1| Attack it with a lightning bolt spell.\n{0}\n{1}", attck2, attck3);
                                character.Stats();
                                string bttlactn = Console.ReadLine();
                                if (bttlactn == "1")
                                {
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("---BATTLE---", Console.ForegroundColor = ConsoleColor.Green);
                                    Console.ResetColor();
                                    Console.Write("You mumble some magical words, and strike a powerful bolt at the creature.\nYou dealed ");
                                    Console.Write(" 8 ", Console.ForegroundColor = ConsoleColor.Red);
                                    Console.ResetColor();
                                    Console.Write("damage to it.\n");
                                    staminausd += 5;
                                    hungerlst += 2;
                                    character.Stamina = Convert.ToInt16(File.ReadLines(fullPath).Skip(2).Take(1).First()) - staminausd;
                                    character.Hunger = Convert.ToInt16(File.ReadLines(fullPath).Skip(3).Take(1).First()) - hungerlst;
                                    ldyhlth -= 8;
                                    if (ldyhlth < 1)
                                    {
                                        fairwin = true;
                                        battle = false;
                                        goto Ldywin;
                                    }
                                    Console.Write("The creature attacks back, and manages to deal");
                                    Console.Write(" 12 ", Console.ForegroundColor = ConsoleColor.Red);
                                    Console.ResetColor();
                                    Console.Write("damage to you.\n");
                                    takendmg = 0;
                                    takendmg += 12;
                                    character.Health = Convert.ToInt16(File.ReadLines(fullPath).Skip(1).Take(1).First()) - takendmg;
                                    if (character.Health < 1)
                                    {
                                        Console.Clear();
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    if (character.Stamina < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You became too tired to battle on.");
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    if (character.Hunger < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You can't fight with your stomach empty.");
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                }
                                if (bttlactn == "2")
                                {
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("---BATTLE---", Console.ForegroundColor = ConsoleColor.Green);
                                    Console.ResetColor();
                                    Console.Write("That wasn't quite effective, you only managed to deal ");
                                    Console.Write(" 4 ", Console.ForegroundColor = ConsoleColor.Red);
                                    Console.ResetColor();
                                    Console.Write("damage to it.");
                                    staminausd += 5;
                                    hungerlst += 2;
                                    character.Stamina = Convert.ToInt16(File.ReadLines(fullPath).Skip(2).Take(1).First()) - staminausd;
                                    character.Hunger = Convert.ToInt16(File.ReadLines(fullPath).Skip(3).Take(1).First()) - hungerlst;
                                    character.Save();
                                    ldyhlth -= 4;
                                    if (ldyhlth < 1)
                                    {
                                        fairwin = true;
                                        battle = false;
                                        goto Ldywin;
                                    }
                                    Console.Write("The creature attacks back, and manages to deal");
                                    Console.Write(" 12 ", Console.ForegroundColor = ConsoleColor.Red);
                                    Console.ResetColor();
                                    Console.Write("damage to you.\n");
                                    takendmg = 0;
                                    takendmg += 12;
                                    character.Health = Convert.ToInt16(File.ReadLines(fullPath).Skip(1).Take(1).First()) - takendmg;
                                    character.Save();
                                    if (character.Health < 1)
                                    {
                                        Console.Clear();
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    if (character.Stamina < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You became too tired to battle on.");
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    if (character.Hunger < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You can't fight with your stomach empty.");
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                }
                                if (bttlactn == "3")
                                {
                                    staminausd += 12;
                                    hungerlst += 7;
                                    character.Stamina = Convert.ToInt16(File.ReadLines(fullPath).Skip(2).Take(1).First()) - staminausd;
                                    character.Hunger = Convert.ToInt16(File.ReadLines(fullPath).Skip(3).Take(1).First()) - hungerlst;
                                    character.Save();
                                    if (character.Stamina < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("In the hopes of escaping, you bacame too tired, and therefore, the creature manages to enslave you.");
                                        Console.Write("\nGame over.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    if (character.Hunger < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("In the hopes of escaping, you became too hungry to continue to live.");
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);

                                        fairwin = false;
                                        goto Ldywin;
                                    }
                                }
                            }

                        }
                        if (character.ChrctrClass == 3)
                        {
                            while (true)
                            {
                                Console.WriteLine("1| Enrage yourself.\n{0}\n{1}", attck2, attck3);
                                character.Stats();
                                string bttlactn = Console.ReadLine();
                                if (bttlactn == "1")
                                {
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("---BATTLE---", Console.ForegroundColor = ConsoleColor.Green);
                                    Console.ResetColor();
                                    Console.Write("You quickly meditate on the spot, and have enlightened your spirit. You now do more melee damage.\nYou dealed ");
                                    Console.Write(" 8 ", Console.ForegroundColor = ConsoleColor.Red);
                                    Console.ResetColor();
                                    Console.Write("damage to it, because it got triggered.\n");
                                    staminausd += 5;
                                    hungerlst += 2;
                                    character.Stamina = Convert.ToInt16(File.ReadLines(fullPath).Skip(2).Take(1).First()) - staminausd;
                                    character.Hunger = Convert.ToInt16(File.ReadLines(fullPath).Skip(3).Take(1).First()) - hungerlst;
                                    ldyhlth -= 8;
                                    if (ldyhlth < 1)
                                    {
                                        fairwin = true;
                                        battle = false;
                                        goto Ldywin;
                                    }
                                    Console.Write("The creature attacks back, and manages to deal");
                                    Console.Write(" 12 ", Console.ForegroundColor = ConsoleColor.Red);
                                    Console.ResetColor();
                                    Console.Write("damage to you.\n");
                                    takendmg = 0;
                                    takendmg += 12;
                                    character.Health = Convert.ToInt16(File.ReadLines(fullPath).Skip(1).Take(1).First()) - takendmg;
                                    if (character.Health < 1)
                                    {
                                        Console.Clear();
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    if (character.Stamina < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You became too tired to battle on.");
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    if (character.Hunger < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You can't fight with your stomach empty.");
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                }
                                if (bttlactn == "2")
                                {
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("---BATTLE---", Console.ForegroundColor = ConsoleColor.Green);
                                    Console.ResetColor();
                                    Console.Write("It was very effective, you managed to do ");
                                    Console.Write(" 11 ", Console.ForegroundColor = ConsoleColor.Red);
                                    Console.ResetColor();
                                    Console.Write("damage to it.");
                                    staminausd += 5;
                                    hungerlst += 2;
                                    character.Stamina = Convert.ToInt16(File.ReadLines(fullPath).Skip(2).Take(1).First()) - staminausd;
                                    character.Hunger = Convert.ToInt16(File.ReadLines(fullPath).Skip(3).Take(1).First()) - hungerlst;
                                    character.Save();
                                    ldyhlth -= 11;
                                    if (ldyhlth < 1)
                                    {
                                        fairwin = true;
                                        battle = false;
                                        goto Ldywin;
                                    }
                                    Console.Write("The creature attacks back, and manages to deal");
                                    Console.Write(" 12 ", Console.ForegroundColor = ConsoleColor.Red);
                                    Console.ResetColor();
                                    Console.Write("damage to you.\n");
                                    takendmg = 0;
                                    takendmg += 12;
                                    character.Health = Convert.ToInt16(File.ReadLines(fullPath).Skip(1).Take(1).First()) - takendmg;
                                    character.Save();
                                    if (character.Health < 1)
                                    {
                                        Console.Clear();
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    if (character.Stamina < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You became too tired to battle on.");
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    if (character.Hunger < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You can't fight with your stomach empty.");
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                }
                                if (bttlactn == "3")
                                {
                                    staminausd += 12;
                                    hungerlst += 7;
                                    character.Stamina = Convert.ToInt16(File.ReadLines(fullPath).Skip(2).Take(1).First()) - staminausd;
                                    character.Hunger = Convert.ToInt16(File.ReadLines(fullPath).Skip(3).Take(1).First()) - hungerlst;
                                    character.Save();
                                    if (character.Stamina < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("In the hopes of escaping, you bacame too tired, and therefore, the creature manages to enslave you.");
                                        Console.Write("\nGame over.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    if (character.Hunger < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("In the hopes of escaping, you became too hungry to continue to live.");
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);

                                        fairwin = false;
                                        goto Ldywin;
                                    }
                                }
                            }
                        }
                        if (character.ChrctrClass == 4)
                        {
                            while (true)
                            {
                                Console.WriteLine("1| Slash your war axe at it.\n{0}\n{1}", attck2, attck3);
                                character.Stats();
                                string bttlactn = Console.ReadLine();
                                if (bttlactn == "1")
                                {
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("---BATTLE---", Console.ForegroundColor = ConsoleColor.Green);
                                    Console.ResetColor();
                                    Console.Write("You slam the creature with your mighty war axe.\nYou dealed ");
                                    Console.Write(" 8 ", Console.ForegroundColor = ConsoleColor.Red);
                                    Console.ResetColor();
                                    Console.Write("damage to it.\n");
                                    staminausd += 5;
                                    hungerlst += 2;
                                    character.Stamina = Convert.ToInt16(File.ReadLines(fullPath).Skip(2).Take(1).First()) - staminausd;
                                    character.Hunger = Convert.ToInt16(File.ReadLines(fullPath).Skip(3).Take(1).First()) - hungerlst;
                                    ldyhlth -= 8;
                                    if (ldyhlth < 1)
                                    {
                                        fairwin = true;
                                        battle = false;
                                        goto Ldywin;
                                    }
                                    Console.Write("The creature attacks back, and manages to deal");
                                    Console.Write(" 12 ", Console.ForegroundColor = ConsoleColor.Red);
                                    Console.ResetColor();
                                    Console.Write("damage to you.\n");
                                    takendmg = 0;
                                    takendmg += 12;
                                    character.Health = Convert.ToInt16(File.ReadLines(fullPath).Skip(1).Take(1).First()) - takendmg;
                                    if (character.Health < 1)
                                    {
                                        Console.Clear();
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    if (character.Stamina < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You became too tired to battle on.");
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    if (character.Hunger < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You can't fight with your stomach empty.");
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                }
                                if (bttlactn == "2")
                                {
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("---BATTLE---", Console.ForegroundColor = ConsoleColor.Green);
                                    Console.ResetColor();
                                    Console.Write("That wasn't quite effective, you only managed to deal ");
                                    Console.Write(" 7 ", Console.ForegroundColor = ConsoleColor.Red);
                                    Console.ResetColor();
                                    Console.Write("damage to it.");
                                    staminausd += 5;
                                    hungerlst += 2;
                                    character.Stamina = Convert.ToInt16(File.ReadLines(fullPath).Skip(2).Take(1).First()) - staminausd;
                                    character.Hunger = Convert.ToInt16(File.ReadLines(fullPath).Skip(3).Take(1).First()) - hungerlst;
                                    character.Save();
                                    ldyhlth -= 7;
                                    if (ldyhlth < 1)
                                    {
                                        fairwin = true;
                                        battle = false;
                                        goto Ldywin;
                                    }
                                    Console.Write("The creature attacks back, and manages to deal");
                                    Console.Write(" 12 ", Console.ForegroundColor = ConsoleColor.Red);
                                    Console.ResetColor();
                                    Console.Write("damage to you.\n");
                                    takendmg = 0;
                                    takendmg += 12;
                                    character.Health = Convert.ToInt16(File.ReadLines(fullPath).Skip(1).Take(1).First()) - takendmg;
                                    character.Save();
                                    if (character.Health < 1)
                                    {
                                        Console.Clear();
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    if (character.Stamina < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You became too tired to battle on.");
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    if (character.Hunger < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You can't fight with your stomach empty.");
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                }
                                if (bttlactn == "3")
                                {
                                    staminausd += 12;
                                    hungerlst += 7;
                                    character.Stamina = Convert.ToInt16(File.ReadLines(fullPath).Skip(2).Take(1).First()) - staminausd;
                                    character.Hunger = Convert.ToInt16(File.ReadLines(fullPath).Skip(3).Take(1).First()) - hungerlst;
                                    character.Save();
                                    if (character.Stamina < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("In the hopes of escaping, you bacame too tired, and therefore, the creature manages to enslave you.");
                                        Console.Write("\nGame over.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    if (character.Hunger < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("In the hopes of escaping, you became too hungry to continue to live.");
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);

                                        fairwin = false;
                                        goto Ldywin;
                                    }
                                }
                            }
                        }
                        if (character.ChrctrClass == 5)
                        {
                            
                            while (true)
                            {
                                Console.WriteLine("1| Shoot it with your bow.\n{0}\n{1}", attck2, attck3);
                                character.Stats();
                                string bttlactn = Console.ReadLine();
                                if (bttlactn == "1")
                                {
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("---BATTLE---", Console.ForegroundColor = ConsoleColor.Green);
                                    Console.ResetColor();
                                    Console.Write("You shoot at it with god-like accuracy, you dealed ");
                                    Console.Write(" 11 ", Console.ForegroundColor = ConsoleColor.Red);
                                    Console.ResetColor();
                                    Console.Write("damage to it.\n");
                                    staminausd += 5;
                                    hungerlst += 2;
                                    character.Stamina = Convert.ToInt16(File.ReadLines(fullPath).Skip(2).Take(1).First()) - staminausd;
                                    character.Hunger = Convert.ToInt16(File.ReadLines(fullPath).Skip(3).Take(1).First()) - hungerlst;
                                    ldyhlth -= 11;
                                    if (ldyhlth < 1)
                                    {
                                        fairwin = true;
                                        battle = false;
                                        goto Ldywin;
                                    }
                                    Console.Write("The creature attacks back, and manages to deal");
                                    Console.Write(" 12 ", Console.ForegroundColor = ConsoleColor.Red);
                                    Console.ResetColor();
                                    Console.Write("damage to you.\n");
                                    takendmg = 0;
                                    takendmg += 12;
                                    character.Health = Convert.ToInt16(File.ReadLines(fullPath).Skip(1).Take(1).First()) - takendmg;
                                    if (character.Health < 1)
                                    {
                                        Console.Clear();
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    if (character.Stamina < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You became too tired to battle on.");
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    if (character.Hunger < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You can't fight with your stomach empty.");
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                }
                                if (bttlactn == "2")
                                {
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("---BATTLE---", Console.ForegroundColor = ConsoleColor.Green);
                                    Console.ResetColor();
                                    Console.Write("That wasn't quite effective, you only managed to deal ");
                                    Console.Write(" 4 ", Console.ForegroundColor = ConsoleColor.Red);
                                    Console.ResetColor();
                                    Console.Write("damage to it.");
                                    staminausd += 5;
                                    hungerlst += 2;
                                    character.Stamina = Convert.ToInt16(File.ReadLines(fullPath).Skip(2).Take(1).First()) - staminausd;
                                    character.Hunger = Convert.ToInt16(File.ReadLines(fullPath).Skip(3).Take(1).First()) - hungerlst;
                                    character.Save();
                                    ldyhlth -= 4;
                                    if (ldyhlth < 1)
                                    {
                                        fairwin = true;
                                        battle = false;
                                        goto Ldywin;
                                    }
                                    Console.Write("The creature attacks back, and manages to deal");
                                    Console.Write(" 12 ", Console.ForegroundColor = ConsoleColor.Red);
                                    Console.ResetColor();
                                    Console.Write("damage to you.\n");
                                    takendmg = 0;
                                    takendmg += 12;
                                    character.Health = Convert.ToInt16(File.ReadLines(fullPath).Skip(1).Take(1).First()) - takendmg;
                                    character.Save();
                                    if (character.Health < 1)
                                    {
                                        Console.Clear();
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    if (character.Stamina < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You became too tired to battle on.");
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    if (character.Hunger < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You can't fight with your stomach empty.");
                                        Console.Write("\nGame over, you died.", Console.ForegroundColor = ConsoleColor.Red);
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                }
                                if (bttlactn == "3")
                                {
                                        fairwin = false;
                                        goto Ldywin;
                                  
                                }
                            }
                        }
                    }
                    Ldywin:;
                    Console.Clear();
                    Console.ResetColor();
                    if (fairwin == false)
                    {
                        Console.WriteLine("You escape successfully, even though the old lady turned into a \ncreature, it wasn't successful at catching you from escaping.");
                        if (questi1add == true)
                        {
                            Console.WriteLine("You start walking towards the town that you saw.\nOnce you reach it, you see that it's quite a happy place for one to stay.\nAnd so you end up living there, a happy normal life.\n");
                            Console.WriteLine("THE END", Console.ForegroundColor = ConsoleColor.DarkGray);
                            Console.ReadLine();
                            Environment.Exit(0);

                        }
                        else
                        {
                            Console.WriteLine("You start walking. You walk for 12 hours, and you still see no end to this forest.\nYou stand still, look around, and then see a home far away. You start walking towards it.\nAfter about 10 min. you reach it. It's a small hut, made for 1 person. You know on the front door, noone answers, so you decide to open the door yourself and walk in.\nIt's empty, it doesn't seem that anyone lives in this home.\nOnce you make yourself at home, you realize that this place looks just like the old lady's home.\nBut it definitely isn't her home, her home had a larger home next to it, and this one didn't...");
                            Console.WriteLine("THE END", Console.ForegroundColor = ConsoleColor.DarkGray);
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                    }
                    if (fairwin == true)
                    {
                        Console.WriteLine("You've defeated the lady, and now are a proud owner of her homes.");
                        if (questi1add == true)
                        {
                            Console.WriteLine("You live a happy life in that home, you travel to the nearest town every week to get food, and sometimes even hunt for wildlife around your area.");
                            Console.WriteLine("THE END", Console.ForegroundColor = ConsoleColor.DarkGray);
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Though sadly you don't have much food around to survive.\nHunting the wildlife doesn't give you infinite food.\nYour last hope was to get a farm and make grow your own food, but \nunfortunately the land in this forest is only suitable for trees, not crops.");
                            Console.WriteLine("AFTER A FEW MONTHS, YOU DIE. THE END", Console.ForegroundColor = ConsoleColor.Red);
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
