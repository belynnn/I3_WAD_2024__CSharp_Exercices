namespace Exo10___Plus_ou_Moins
{
	internal class Program
	{
		static Random RNG = new Random(); // static permet de le rendre public
		static readonly short RANDOM = (short)RNG.Next(1, 101); // https://learn.microsoft.com/fr-fr/dotnet/api/system.random?view=net-8.0
		static void Main(string[] args)
		{
			// EXERCICE 10
			/*
				Réalisez le jeu du Plus ou Moins.
				L'ordinateur choisi un nombre aléatoirement entre 1 et 100. L'utilisateur est invité à entrer un
				nombre et l’application nous affiche un indice :
					• "C'est plus" si la valeur à deviner est plus grande que la proposition
					• "C'est moins" si la valeur à deviner est plus petite que la proposition
				Lorsque l’utilisateur a trouvé le bon nombre, la console doit afficher le nombre de tentatives
				effectuées.
			*/

			Console.OutputEncoding = System.Text.Encoding.Unicode;
			bool isGuessed = false;
			short attempt = 0;
			string message = "➡️ Veuillez indiquer un nombre entre 1 et 100 :\n";

			Console.WriteLine("Bienvenue dans ce jeu \"➕ or ➖\".\n");
			Console.WriteLine("Tentez votre chance de vaincre votre ordinateur ! 🤺\n\n");

			while (!isGuessed)
			{
				Console.WriteLine(message);
				string userInput = Console.ReadLine();
				bool isConverted = short.TryParse(userInput, out short parsedUserInput);

				if (!isConverted)
				{
					Console.WriteLine($"{userInput} n'est pas un nombre entier...\n");
					continue;
				}

				attempt++;

				if (parsedUserInput == RANDOM)
				{
					isGuessed = true;
					Console.WriteLine("🎉✨🎊🎉✨🎊🎉✨🎊🎉✨🎊🎉✨🎊🎉✨🎊🎉✨🎊🎉✨🎊🎉✨🎊");
				}
				else if (parsedUserInput < RANDOM)
				{
					Console.WriteLine("⬆️⬆️⬆️\n");
				}
				else
				{
					Console.WriteLine("⬇️⬇️⬇️\n");
				}
			}
		}
	}
}