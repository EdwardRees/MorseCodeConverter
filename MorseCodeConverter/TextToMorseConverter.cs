using System;

namespace MorseCodeConverter
{
   class TextToMorseConverter : Converter
    {
        private Values values;

        private string[] chars;

        private string text;

        public TextToMorseConverter(string text)
        {
            this.values = new Values();
            this.text = text;
            this.chars = text.ToLower().ToCharArray().Select(c => c.ToString()).ToArray();
        }

        public override string Convert()
        {
            string[] converted = new string[chars.Length];
            for(int i=0; i<chars.Length; i++)
            {
                converted[i] = values.GetCharToMorse().GetValueOrDefault(chars[i], "");
            }
            return String.Join(" ", converted);
        }
    }
}