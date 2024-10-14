namespace Exo05___BBAN
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// EXERCICE 5 - BBAN
			/*
				Vérification d’un compte bancaire BBAN, si le compte est bon affichez OK sur la console sinon KO.
				Le modulo des 10 premiers chiffres par 97 donne les 2 derniers.Sauf si le modulo = 0 dans ce cas les 2
				derniere chiffres sont 97.
				(utilisez la méthode « Substring » de la classe « string »).
			*/

			// CORRECTION
			Console.WriteLine("Veuillez introduire les 12 derniers chiffres de votre compte bancaire :");
			string userInput = Console.ReadLine();

			if (userInput.Length != 12 || !long.TryParse(userInput, out _))
			{
				Console.WriteLine($"\"{userInput}\" ne correspond pas à un numéro de compte en banque.");
			}
			else
			{
				string tenFirstChars = userInput.Substring(0, 10);
				string twoLastChars = userInput.Substring(10);

				long tenFirst = long.Parse(tenFirstChars);
				short twoLast = short.Parse(twoLastChars);

				if (tenFirst % 97 == twoLast || (tenFirst % 97 == 0 && twoLast == 97))
				{
					Console.WriteLine("OK");
					string BE0 = $"{twoLast}{twoLast}111400";
					long checkDigits = 98 - (long.Parse(BE0) % 97);

					Console.WriteLine($"BE{checkDigits.ToString("D2")}{userInput}"); // "D" or "d" Decimal - https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#DFormatString
					Console.WriteLine($"BE{checkDigits:D2}{userInput}"); // interpolation
					Console.WriteLine($"BE{(checkDigits < 10 ? "0" : "")}{userInput}"); // ternaire
				}
				else
				{
					Console.WriteLine("NOK");
				}

			/*
			Console.WriteLine("Veuillez introduire les 12 derniers chiffres de votre compte bancaire :");
			string userInput = Console.ReadLine();

			if (userInput.Length != 12)
			{
				Console.WriteLine($"\"{userInput}\" ne correspond pas à un numéro de compte en banque.");
			}
            else
            {
				string substring = userInput.Substring(0, 10);
				bool isConverted = long.TryParse(substring, out long tenFirstDigitParsed);

				substring = userInput.Substring(10);
				isConverted = int.TryParse(substring, out int lastTwoDigitParsed);

				if (tenFirstDigitParsed % 97 == lastTwoDigitParsed)
				{
					Console.WriteLine($"BBAN {userInput} : YEP");

					// EXO 4.3
					string endBE0 = "111400";
					string BE0 = $"{lastTwoDigitParsed}{lastTwoDigitParsed}{endBE0}";

					isConverted = long.TryParse(BE0, out long BE0Parsed);

					Console.WriteLine($"BE{98 - (BE0Parsed % 97)}{userInput}");
				}
				else
				{
					Console.WriteLine($"BBAN {userInput} : NOP");
				}
			}
			*/
			}
		}
	}
}
