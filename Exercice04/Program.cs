using System.Reflection;

namespace Exercice04
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// EXERCICE 4
			/*
				1/	Calcule de la division entière, du modulo et de la division de deux entiers.
					Résultat attendu pour 5 et 2 → Division entière : 2, Modulo : 1, Division : 2,5.
				
				2/	Vérification d’un compte bancaire BBAN, si le compte est bon affichez OK sur la console sinon KO.
					Le modulo des 10 premiers chiffres par 97 donne les 2 derniers. Sauf si le modulo = 0 dans ce cas les 2
					derniere chiffres sont 97.
					(utilisez la méthode « Substring » de la classe « string »).
				
				3/	Transformer un compte bancaire BBAN Belge (xxx-xxxxxxx-xx) en IBAN (BExx-xxxx-xxxx-xxxx). Trouvez la démarche
					via un moteur de recherche.
			*/

			// EXO 4.1
			// CORRECTION
			/*
			Console.WriteLine("Veuillez introduire un premier nombre :");
			string userInput = Console.ReadLine();
			bool isConverted = int.TryParse(userInput, out int nb1);
			if (!isConverted)
			{
				Console.WriteLine($"\"{userInput}\" n'est pas un nombre entier...");
			}
			else
			{
				Console.WriteLine("Veuillez introduire un second nombre :");
				userInput = Console.ReadLine();
				isConverted = int.TryParse(userInput,out int nb2);

				if (!isConverted)
				{
					Console.WriteLine($"\"{userInput}\" n'est pas un nombre entier...");
				}
				else
				{
					Console.WriteLine($"Division entière : {nb1} divisé par {nb2} est égale à {nb1 / nb2}.");
					Console.WriteLine($"Modulo : {nb1} modulo {nb2} est égale à {nb1 % nb2}.");
					Console.WriteLine($"Division : {nb1} divisé par {nb2} est égale à {(float)nb1 / nb2}.");
				}
			}
			*/

			/*
			Console.WriteLine("Veuillez entrer le premier nombre entier :");
			int userInput1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Veuillez entrer le deuxième nombre entier :");
			int userInput2 = int.Parse(Console.ReadLine());

			int intDivision = userInput1 / userInput2;
			int modulo = userInput1 % userInput2;
			double floatDivision = (float)userInput1 / userInput2;

			Console.WriteLine($"Division entière : {userInput1} divisé par {userInput2} est égale à {intDivision}.");
			Console.WriteLine($"Modulo : {userInput1} modulo {userInput2} est égale à {modulo}.");
			Console.WriteLine($"Division : {userInput1} divisé par {userInput2} est égale à {floatDivision}.");
			*/

			// EXO 4.2 & 4.3 - 732038207644 - 000000000097 - 958024693531
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