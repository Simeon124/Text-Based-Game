using Escape_of_Doom.Levels;
using Escape_of_Doom.Tools;

namespace Escape_of_Doom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start();
            HurtMePlenty.Start();
        }

        public static void Intro()
        {
            TextAnimations.Type("In the first age, ", 100);
            Thread.Sleep(1000);
            TextAnimations.Type("in the first battle", 100);
            Thread.Sleep(2000);

            Console.WriteLine();
            TextAnimations.Type("When the shadows first lengthened, ", 100);
            Thread.Sleep(500);
            TextAnimations.Type("one stood", 100);
            Thread.Sleep(1000);

            Console.WriteLine();
            TextAnimations.Type("He chose the path of perpetual torment", 100);
            Thread.Sleep(1000);

            Console.WriteLine();
            TextAnimations.Type("In his ravenous hatred, ", 100);
            Thread.Sleep(500);
            TextAnimations.Type("he found no peace", 100);
            Thread.Sleep(2000);

            Console.WriteLine();
            TextAnimations.Type("And with boiling blood, he scoured the umbral plains, ", 100);
            Thread.Sleep(1000);
            TextAnimations.Type("seeking vengeance against the dark lords who had wronged him", 100);
            Thread.Sleep(2000);

            Console.WriteLine();
            TextAnimations.Type("And those that tasted the bite of his sword named him...", 150);
            Thread.Sleep(1000);

            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            TextAnimations.Type("The Doom Slayer", 200);
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(3000);
            Console.Clear();
            Thread.Sleep(3000);
        }
    }
}
