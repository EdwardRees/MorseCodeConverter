using System;

namespace MorseCodeConverter
{


	public class MorseToTextConverter : Converter
	{
		private static Values values = new Values();
		private string[] morse;
		private string text;

		public MorseToTextConverter(string text) {
			this.text = text;
			this.morse = text.Split(' ');
		}

		public override string Convert()
		{
			string[] converted = new string[morse.Length];
			for (int i = 0; i < morse.Length; i++)
			{
				converted[i] = values.GetMorseToChar().GetValueOrDefault(morse[i], "");
			}
			return string.Join("", converted);
		}
	
	}
}
