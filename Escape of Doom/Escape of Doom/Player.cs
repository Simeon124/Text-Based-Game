using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_of_Doom
{
    public static class Player
    {
        public static int Health { get; set; }

        public static List<Weapon> Weapons { get; set; }

        public static void TakeDamage(int damage)
        {
            Health -= damage;
        }

        public static void Heal(int healAmount)
        {
            Health += healAmount;
        }

    }

    public enum Weapon
    {
        Fists,
        Pistol,
        SuperShotgun,
        Chainsaw,
        Chaingun,
        BFG
    }
}
