using Escape_of_Doom.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_of_Doom.Levels
{
    public static class VisionsOfThePast
    {
        static bool killedDemon;
        public static void Intro()
        {
            string input = "";
            TextAnimations.Type("You find yourself in a chaotic pathway, filled with dangerous memories", 50);
            Thread.Sleep(1000);
            Console.WriteLine();
            TextAnimations.Type("As  you walk the silent path, you hear strange noises coming in the front horizon", 50);
            Thread.Sleep(1000);
            Console.WriteLine();
            TextAnimations.Type("Suddenly, a weird and ugly demonic figure stops and tries to attack you", 50);
            Thread.Sleep(1000);
            Console.WriteLine();
            TextAnimations.Type("What do you do?\n\nAttack or Run?", 50);

            while (true)
            {
                Console.Write("\n\nDoom Slayer: ");
                input = Console.ReadLine();

                foreach (var word in input.Split(" ").ToList())
                {
                    if (word.ToLower() == "attack")
                    {
                        double demonHealth = 6;
                        foreach (var weapon in Player.Weapons)
                        {
                            demonHealth -= Player.Attack(weapon);
                        }
                        if (demonHealth <= 0)
                        {
                            killedDemon = true;
                        }
                        else
                        {
                            killedDemon = false;
                        }

                        Attack();
                        break;
                    }
                    else if (word.ToLower() == "run")
                    {
                        Run();
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        TextAnimations.Type("\n\nThat's not an availible option\n\n", 10);
                    }
                }
            }
        }

        public static void Attack()
        {
            Console.Clear();
            if (killedDemon == true)
            {
                TextAnimations.Type("The doom slayer slays the mighty beast easily", 50);
                Thread.Sleep(1000);
            }
            else
            {
                TextAnimations.Type("The doom slayer realises that he doesn't have any weapons", 50);
                Thread.Sleep(1000);
                Console.WriteLine();
                TextAnimations.Type("But that's not even close to a problem", 50);
                Thread.Sleep(1000);
                Console.WriteLine();
                TextAnimations.Type("He manages to rip out his heart with his own bare hands", 50);
                Thread.Sleep(1000);
                Player.TakeDamage(15);
            }
        }
        public static void Run()
        {
            Console.Clear();
            TextAnimations.Type("You chose to run...", 50);
            Thread.Sleep(1000);
            Console.WriteLine();
            TextAnimations.Type("What kind of slayer are you?", 50);
            Thread.Sleep(500);
            Console.WriteLine();
            TextAnimations.Type("Honestly", 50);
            Thread.Sleep(1000);
            Console.WriteLine();
            TextAnimations.Type("Do i have to even explain?", 50);
            Thread.Sleep(500);
            Console.WriteLine();
            TextAnimations.Type("Ooof...", 50);
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.Clear();

            TextAnimations.Type("You die, because you are a loser and can't play games", 50);
            Thread.Sleep(1000);
            Console.WriteLine();
        }
    }
}
