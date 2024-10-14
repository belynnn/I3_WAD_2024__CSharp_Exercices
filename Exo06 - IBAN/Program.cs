namespace Exo06___IBAN
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// EXERCICE 06
			/*
				Transformer un compte bancaire BBAN Belge (xxx-xxxxxxx-xx) en IBAN (BExx-xxxx-xxxx-xxxx). Trouvez la démarche
				via un moteur de recherche. 
			*/

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
	}
}
