using System;

namespace MorseCode.Lib
{
	public class MorseCode
	{
		#region Properties

		private char _Character;
		private string _Code;

		public char Character
		{
			get { return _Character; }
		}

		public string Code
		{
			get { return _Code; }
		}

		#endregion

		#region Con/De Structors

		public MorseCode(char Character)
		{
			_Character = Character;
			_Code = GetCode(Character);
		}

		public MorseCode(char Character, string Code)
		{
			_Character = Character;
			_Code = Code;
		}

		#endregion

		#region Methods

		#region Static

		public static string GetCode(char Character)
		{
			return GetCode(Character, '.', '-');
		}

		public static string GetCode(char character, char dot, char dash)
		{
			string Return = "";

			switch (character.ToString().ToUpper())
			{

				case "A": Return = ".-"; break;
				case "B": Return = "-..."; break;
				case "C": Return = "-.-."; break;
				case "D": Return = "-.."; break;
				case "E": Return = "."; break;
				case "F": Return = "..-."; break;
				case "G": Return = "--."; break;
				case "H": Return = "...."; break;
				case "I": Return = ".."; break;
				case "J": Return = ".---"; break;
				case "K": Return = "-.-"; break;
				case "L": Return = ".-.."; break;
				case "M": Return = "--"; break;
				case "N": Return = "-."; break;
				case "O": Return = "---"; break;
				case "P": Return = ".--."; break;
				case "Q": Return = "--.-"; break;
				case "R": Return = ".-."; break;
				case "S": Return = "..."; break;
				case "T": Return = "-"; break;
				case "U": Return = "..-"; break;
				case "V": Return = "...-"; break;
				case "W": Return = ".--"; break;
				case "X": Return = "-..-"; break;
				case "Y": Return = "-.--"; break;
				case "Z": Return = "--.."; break;

				case "1": Return = ".----"; break;
				case "2": Return = "..---"; break;
				case "3": Return = "...--"; break;
				case "4": Return = "....-"; break;
				case "5": Return = "....."; break;
				case "6": Return = "-...."; break;
				case "7": Return = "--..."; break;
				case "8": Return = "---.."; break;
				case "9": Return = "----."; break;
				case "0": Return = "-----"; break;
			}

			if (!string.IsNullOrEmpty(Return))
			{
				if (dot != '.')
					Return = Return.Replace('.', dot);

				if (dash != '-')
					Return = Return.Replace('-', dash);
			}

			return Return;
		}

		public static string GetCharacter(string code, char dot, char dash)
		{
			string Return = string.Empty;

			code = code.Replace(dot, '.');
			code = code.Replace(dash, '-');
			switch (code)
			{
				case ".-": Return = "A"; break;
				case "-...": Return = "B"; break;
				case "-.-.": Return = "C"; break;
				case "-..": Return = "D"; break;
				case ".": Return = "E"; break;
				case "..-.": Return = "F"; break;
				case "--.": Return = "G"; break;
				case "....": Return = "H"; break;
				case "..": Return = "I"; break;
				case ".---": Return = "J"; break;
				case "-.-": Return = "K"; break;
				case ".-..": Return = "L"; break;
				case "--": Return = "M"; break;
				case "-.": Return = "N"; break;
				case "---": Return = "O"; break;
				case ".--.": Return = "P"; break;
				case "--.-": Return = "Q"; break;
				case ".-.": Return = "R"; break;
				case "...": Return = "S"; break;
				case "-": Return = "T"; break;
				case "..-": Return = "U"; break;
				case "...-": Return = "V"; break;
				case ".--": Return = "W"; break;
				case "-..-": Return = "X"; break;
				case "-.--": Return = "Y"; break;
				case "--..": Return = "Z"; break;

				case ".----": Return = "1"; break;
				case "..---": Return = "2"; break;
				case "...--": Return = "3"; break;
				case "....-": Return = "4"; break;
				case ".....": Return = "5"; break;
				case "-....": Return = "6"; break;
				case "--...": Return = "7"; break;
				case "---..": Return = "8"; break;
				case "----.": Return = "9"; break;
				case "-----": Return = "0"; break;
			}

			return Return;
		}

		public static void playWord(string Word, char Dot, char Dash)
		{
			foreach (char c in Word)
				if (c == Dot)
					Console.Beep(800, 500);
				else
					Console.Beep(800, 1000);

		}

		public static string GetCode(string Sentence)
		{
			return GetCode(Sentence, '.', '-', " ", " ");
		}

		public static string GetCode(string Sentence, char Dot, char Dash)
		{
			return GetCode(Sentence, Dot, Dash, " ", " ");
		}

		public static string GetCode(string Sentence, char Dot, char Dash, string WordSeperator, string CharacterSeperator)
		{
			string Return = "";

			char[] EachCharacter = Sentence.ToCharArray();
			for (int i = 0; i < EachCharacter.Length; i++)
			{
				if (EachCharacter[i] == ' ')
				{
					Return += CharacterSeperator;
					Return += WordSeperator;
				}
				else
				{
					Return += GetCode(EachCharacter[i], Dot, Dash);
					Return += CharacterSeperator;
				}
			}

			return Return;
		}

		#endregion

		#endregion
	}
}