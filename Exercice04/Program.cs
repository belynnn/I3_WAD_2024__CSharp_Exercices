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
			/*
			Console.WriteLine("Veuillez entrer le premier nombre entier :");
			int userInput1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Veuillez entrer le deuxième nombre entier :");
			int userInput2 = int.Parse(Console.ReadLine());

			int intDivision = userInput1 / userInput2;
			int modulo = userInput1 % userInput2;
			double floatDivision = (double)userInput1 / userInput2;

			Console.WriteLine($"Division entière : {userInput1} divisé par {userInput2} est égale à {intDivision}.");
			Console.WriteLine($"Modulo : {userInput1} modulo {userInput2} est égale à {modulo}.");
			Console.WriteLine($"Division : {userInput1} divisé par {userInput2} est égale à {floatDivision}.");
			*/

			// EXO 4.2

			string bankAccount = "732038207644"; 
			string tenFirstDigit = bankAccount.Substring(0, 10);
			long tenFirstDigitParsed = long.Parse(tenFirstDigit);
			Console.WriteLine(tenFirstDigitParsed);

			if (tenFirstDigitParsed % 97 == 44) {
				Console.WriteLine($"{bankAccount} OK");
			}
			else {
				Console.WriteLine($"{bankAccount} NOK");
			}

			string bankAccount2 = "000000000097";
			string tenFirstDigit2 = bankAccount2.Substring(0, 10);
			long tenFirstDigitParsed2 = long.Parse(tenFirstDigit2);
			Console.WriteLine(tenFirstDigitParsed2);

			if (tenFirstDigitParsed2 % 97 == 44)
			{
				Console.WriteLine($"{bankAccount2} OK");
			}
			else
			{
				Console.WriteLine($"{bankAccount2} NOK");
			}
		}
	}
}
