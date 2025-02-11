using Escape_of_Doom.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_of_Doom.Levels
{
    public static class HurtMePlenty
    {
        //TODO: Make each part of the level with seperate methods and run it in program

        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Demon:");
            TextAnimations.Type("Is he dead?", 50);
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Demon 2:");
            TextAnimations.Type("Probably not", 50);
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("*EXPLOSION*");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            TextAnimations.Type("The doom slayer awakens and crushes the skull of the demonic creatures", 50);
            Thread.Sleep(2000);

            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Doom guy:");
            TextAnimations.Type("*silence*", 50);
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;
            PathChoose();
        }
        public static void PathChoose()
        {
            Console.Clear();
            string input = "";
            TextAnimations.Type("There are two entrances:\nThe left and right entrance\nDoom guy is angry, but intelligent. He keeps his anger away so he can choose...", 50);
            
            while(true)
            {
                bool hasChoosen = false;
                Console.Write("\n\nDoom Slayer: ");
                input = Console.ReadLine();

                foreach (var word in input.Split(' '))
                {
                    if(word.ToLower() == "left")
                    {
                        hasChoosen = true;
                        LeftPath();
                    }
                    else if (word.ToLower() == "right")
                    {
                        hasChoosen = true;
                        RightPath();
                    }
                    else
                    {
                        hasChoosen = false;
                    }

                }

                if(hasChoosen == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\nDoom slayer doesn't know what direction that is...\n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    break;
                }

            }
            
        }

        public static void LeftPath()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            TextAnimations.Type("Painted in blood and filled with eternal rage, Doom slayer runs towards the left path", 50);
            Thread.Sleep(1000);
            Console.WriteLine();
            TextAnimations.Type("The undying nightmare flies towards him - Demons, Cyberdemons, Cacodemons, Lost Souls...", 50);
            Thread.Sleep(1000);
            Console.WriteLine();
            TextAnimations.Type("Most people will shout with fear and die by the monsters. But today is a different day", 50);
            Thread.Sleep(2000);
            Console.WriteLine();
            TextAnimations.Type(" and the only thing they fear", 50);
            Thread.Sleep(2000);
            TextAnimations.Type(" is you.", 50);
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;
            Player.TakeDamage(20);
            Player.Weapons.Add(Weapon.Pistol);
            Exit();
        }
        public static void RightPath()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            TextAnimations.Type("Painted in blood and filled with eternal rage, Doom slayer runs towards the right path", 50);
            Thread.Sleep(1000);
            Console.WriteLine();
            TextAnimations.Type("The walls and the floor feels strange, like there is no apocalypse on Mars", 50);
            Thread.Sleep(1000);
            Console.WriteLine();
            TextAnimations.Type("You see a creature, but not a demon. The doom slayer walks towards it", 50);
            Thread.Sleep(1000);

            Console.WriteLine();
            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Creature:");
            TextAnimations.Type("*speaks mysterious language*", 50);
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            TextAnimations.Type("While the creature speaks, you get a vision. Enourmous rage strikes the slayer - a vision of the dark lord", 50);
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine();
            TextAnimations.Type("As the slayer continues his path, the creature continues to mumble strange words", 50);
            Thread.Sleep(2000);
            Console.WriteLine();
            TextAnimations.Type("You see an elevator door with a sign *EXIT* and you enter it", 50);
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;
            Exit();
        }

        public static void Exit()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("MISSION PASSED - HURT ME PLENTY");
            Player.ShowStats();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
