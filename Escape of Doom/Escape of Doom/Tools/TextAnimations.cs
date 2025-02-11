using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_of_Doom.Tools
{
    public static class TextAnimations
    {
        public static void Type(string text, int duration)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Thread.Sleep(duration);
                Console.Write(text[i]);
            }
        }
    }
}
