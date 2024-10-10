﻿namespace Exercice09
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// EXERCICE 9
			/*
				Réalisez un algorithme par l'utilisateur.
				Chaque ligne contiendra X astérisques, X étant le nombre selon le numéro de ligne. 
			*/
			short count;
			bool keepGoing = true;

			while (keepGoing)
			{
				Console.WriteLine("Veuillez indiquer un nombre :");
				string userInput = Console.ReadLine();

				if (short.TryParse(userInput, out count))
				{
					keepGoing = false;
				}
				else
				{
					Console.WriteLine("Erreur");
				}

				for (short i = 1; i <= count; i++)
				{
					for (short j = 1; j <= i; j++)
					{
						Console.Write("*");
					}
					Console.WriteLine();
				}
			}
		}
	}
}
