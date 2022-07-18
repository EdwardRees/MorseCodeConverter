using System;

namespace MorseCodeConverter
{
    public class Driver
    {
        private Converter converter;
        public Driver(string text)
        {
            if (Converter.IsMorse(text))
            {
                converter = new MorseToTextConverter(text);
            } else
            {
                converter = new TextToMorseConverter(text);
            }
        }

        public string Convert()
        {
            return converter.Convert();
        }

        public static string Convert(string text)
        {
            if (Converter.IsMorse(text))
            {
                return new MorseToTextConverter(text).Convert();
            } else
            {
                return new TextToMorseConverter(text).Convert();
            }
        }
    }
}
