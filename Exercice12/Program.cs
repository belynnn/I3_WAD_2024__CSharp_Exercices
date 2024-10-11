namespace Exercice12
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// EXERCICE 12
			/*
				Algorithme demandant 3 nombres : nbRepetition, nbTiret, nbEspace. Ce dernier affiche à
				l'écran autant de tiret que la valeur de nbTiret, suivi d'autant d'espace que la valeur de
				nbEspace. Le tout autant de fois que la valeur de nbRepetition.
				Exemple : si nbRepetition = 2, nbTiret = 1 et nbEspace = 3 le résultat est le suivant : 
			*/

			// CORRECTION
			short nbTiret;
			do
			{
				Console.WriteLine("Veuillez indiquer le nombre de tiret :");
			} while (!short.TryParse(Console.ReadLine(), out nbTiret) || nbTiret < 0);

			short nbEspace;
			do
			{
				Console.WriteLine("Veuillez indiquer le nombre de tiret :");
			} while (!short.TryParse(Console.ReadLine(), out nbEspace) || nbEspace < 0);

			short nbRepetition;
			do
			{
				Console.WriteLine("Veuillez indiquer le nombre de tiret :");
			} while (!short.TryParse(Console.ReadLine(), out nbRepetition) || nbRepetition < 0);

			string tirets = "";
			string espaces = "";

			for (int i = 0; i < nbTiret; i++)
			{
				tirets += "-";
			}

			for (int i = 0; i < nbEspace; i++)
			{
				espaces += " ";
			}

			for (int i = 1; i <= nbRepetition; i++)
			{
				Console.Write($"{tirets}{espaces}");
			}
			/*
			Console.OutputEncoding = System.Text.Encoding.Unicode;

			Console.WriteLine("Veuillez indiquer le nombre d'espace à afficher :");
			string nbEspace = Console.ReadLine();
			bool isConverted = short.TryParse(nbEspace, out short parsedNbEspace);
			string tiretMessage;
			string espaceMessage;



			if (!isConverted)
			{
				Console.WriteLine($"{nbEspace} n'est pas un nombre entier...");
			}
			else
			{
				Console.WriteLine("Veuillez indiquer le nombre de tiret à afficher :");
				string nbRepetition = Console.ReadLine();
				isConverted = short.TryParse(nbRepetition, out short parsedNbRepetition);

				if (!isConverted)
				{
					Console.WriteLine($"{nbRepetition} n'est pas un nombre entier...");
					nbRepetition = Console.ReadLine();
				}
				else
				{
					Console.WriteLine("Veuillez indiquer le nombre de répétition :");
					string nbTiret = Console.ReadLine();
					isConverted = short.TryParse(nbTiret, out short parsedNbTiret);

					if (!isConverted)
					{
						Console.WriteLine($"\n{nbTiret} n'est pas un nombre entier...");
					}
					else
					{
						tiretMessage = new string('-', parsedNbTiret);
						espaceMessage = new string(' ', parsedNbEspace);
						string repetitionMessage = $"{tiretMessage}{espaceMessage}";

						Console.Write("\n[");
						for (int i = 0; i < parsedNbRepetition; i++)
						{
							Console.Write($"{repetitionMessage}");
						}
						Console.Write("]");
					}
				}
			}
			*/
		}
	}
}
