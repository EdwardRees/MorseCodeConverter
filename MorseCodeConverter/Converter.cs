using System;

namespace MorseCodeConverter
{
    public abstract class Converter
    {
        public static bool IsMorse(string text)
        {
            return text.Split(' ')[0].Contains(".") || text.Split(" ")[0].Contains("-");
        }
        public abstract string Convert();
    }
}