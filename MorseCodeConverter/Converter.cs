using System;

namespace MorseCodeConverter
{
    public abstract class Converter
    {
        public static bool IsMorse(string text)
        {
          string[] lines = text.Split(' ');
            return lines[0].Contains(".") || lines[0].Contains("-");
        }
        public abstract string Convert();
    }
}