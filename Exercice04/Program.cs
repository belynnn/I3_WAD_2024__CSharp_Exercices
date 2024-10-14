namespace Exo04___Modulo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// EXERCICE 4
			/*
				Calcule de la division entière, du modulo et de la division de deux entiers.
				Résultat attendu pour 5 et 2 → Division entière : 2, Modulo : 1, Division : 2,5.
				
				3/	
			*/

			// CORRECTION
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
		}
	}
}