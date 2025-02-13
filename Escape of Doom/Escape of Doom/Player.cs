using Escape_of_Doom.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_of_Doom
{
    public static class Player
    {
        public static int Health = 100;

        public static bool IsDead { get; private set; }

        public static List<Weapon> Weapons = new List<Weapon>();

        public static void TakeDamage(int damage)
        {
            if (Health > 0)
            {
                Health -= damage;
                IsDead = false;
            }
            else
            {
                IsDead = true;
            }
        }

        public static double Attack(Weapon weapon)
        {
            switch (weapon)
            {
                case Weapon.Pistol:
                    return 6;
                case Weapon.SuperShotgun:
                    return 24;
                case Weapon.Chainsaw:
                    return 60;
                case Weapon.Chaingun:
                    return 50;
                case Weapon.BFG:
                    return 120;
                default: return 0;

            }
        }

        public static void Heal(int healAmount)
        {
            if (Health < 100)
            {
                Health += healAmount;
            }
        }

        public static void ShowStats()
        {
            Console.WriteLine("\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            TextAnimations.Type(new string('=', 15), 10);
            Console.ForegroundColor = ConsoleColor.Green;
            TextAnimations.Type($"\n\nHealth: {Health} \n\n", 10);
            Console.ForegroundColor = ConsoleColor.Blue;
            TextAnimations.Type("\n\nWeapons: \n\n", 10);
            foreach (Weapon weapon in Weapons)
            {
                Console.WriteLine($"{weapon}");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            TextAnimations.Type(new string('=', 15), 10);
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n\nPress any key to continue");
            Console.ReadKey();
        }

    }
}
