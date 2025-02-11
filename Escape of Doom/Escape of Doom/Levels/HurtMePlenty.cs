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

        public static void Intro()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Demon:");
            TextAnimations.Type("Is he dead?", 50);
            Thread.Sleep(1000);
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

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Doom guy:");
            TextAnimations.Type("*silence*", 50);
            Thread.Sleep(2000);
            PathChoose();
        }
        public static void PathChoose()
        {
            string input = "";
            TextAnimations.Type("There are two entrances:\nThe left and right entrance\nDoom guy is angry, but intelligent. He keeps his anger away so he can choose...", 500);

            Console.Write("Doom Slayer: ");
            input = Console.ReadLine();
        }
    }
}
