using System;
using System.Collections.Generic;

namespace MorseCodeConverter
{


    public class Values
    {
        private Dictionary<string, string> CharToMorse;
        private Dictionary<string, string> MorseToChar;
        public Values()
        {
            this.CharToMorse = new Dictionary<string, string>();
            this.MorseToChar = new Dictionary<string, string>();
            this.GenerateCharToMorseTable();
            this.GenerateMorseToCharTable();
        }

        private void GenerateCharToMorseTable()
        {
            CharToMorse.Add("a", ".-");
            CharToMorse.Add("b", "-...");
            CharToMorse.Add("c", "-.-.");
            CharToMorse.Add("d", "-..");
            CharToMorse.Add("e", ".");
            CharToMorse.Add("f", "..-.");
            CharToMorse.Add("g", "--.");
            CharToMorse.Add("h", "....");
            CharToMorse.Add("i", "..");
            CharToMorse.Add("j", ".---");
            CharToMorse.Add("k", "-.-");
            CharToMorse.Add("l", ".-..");
            CharToMorse.Add("m", "--");
            CharToMorse.Add("n", "-.");
            CharToMorse.Add("o", "---");
            CharToMorse.Add("p", ".--.");
            CharToMorse.Add("q", "--.-");
            CharToMorse.Add("r", ".-.");
            CharToMorse.Add("s", "...");
            CharToMorse.Add("t", "-");
            CharToMorse.Add("u", "..-");
            CharToMorse.Add("v", "...-");
            CharToMorse.Add("w", ".--");
            CharToMorse.Add("x", "-..-");
            CharToMorse.Add("y", "-.--");
            CharToMorse.Add("z", "--..");
            CharToMorse.Add("1", ".----");
            CharToMorse.Add("2", "..---");
            CharToMorse.Add("3", "...--");
            CharToMorse.Add("4", "....-");
            CharToMorse.Add("5", ".....");
            CharToMorse.Add("6", "-....");
            CharToMorse.Add("7", "--...");
            CharToMorse.Add("8", "---..");
            CharToMorse.Add("9", "----.");
            CharToMorse.Add("0", "-----");
            CharToMorse.Add(" ", " ");
        }
        private void GenerateMorseToCharTable()
        {
            MorseToChar.Add(".-", "a");
            MorseToChar.Add("-...", "b");
            MorseToChar.Add("-.-.", "c");
            MorseToChar.Add("-..", "d");
            MorseToChar.Add(".", "e");
            MorseToChar.Add("..-.", "f");
            MorseToChar.Add("--.", "g");
            MorseToChar.Add("....", "h");
            MorseToChar.Add("..", "i");
            MorseToChar.Add(".---", "j");
            MorseToChar.Add("-.-", "k");
            MorseToChar.Add(".-..", "l");
            MorseToChar.Add("--", "m");
            MorseToChar.Add("-.", "n");
            MorseToChar.Add("---", "o");
            MorseToChar.Add(".--.", "p");
            MorseToChar.Add("--.-", "q");
            MorseToChar.Add(".-.", "r");
            MorseToChar.Add("...", "s");
            MorseToChar.Add("-", "t");
            MorseToChar.Add("..-", "u");
            MorseToChar.Add("...-", "v");
            MorseToChar.Add(".--", "w");
            MorseToChar.Add("-..-", "x");
            MorseToChar.Add("-.--", "y");
            MorseToChar.Add("--..", "z");
            MorseToChar.Add(".----", "1");
            MorseToChar.Add("..---", "2");
            MorseToChar.Add("...--", "3");
            MorseToChar.Add("....-", "4");
            MorseToChar.Add(".....", "5");
            MorseToChar.Add("-....", "6");
            MorseToChar.Add("--...", "7");
            MorseToChar.Add("---..", "8");
            MorseToChar.Add("----.", "9");
            MorseToChar.Add("-----", "0");
        }

        public IReadOnlyDictionary<string, string> GetCharToMorse()
        {
            return this.CharToMorse;
        }
        public IReadOnlyDictionary<string, string> GetMorseToChar()
        {
            return this.MorseToChar;
        }
    }
}