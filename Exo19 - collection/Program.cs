namespace Exo19___Collection
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// EXERCICE 19
			/*
				Grâce à une boucle « while » et à l’aide d’une collection, calculez les nombres premiers inférieur à un nombre entier entré au 
				clavier. 
			*/

			Console.OutputEncoding = System.Text.Encoding.Unicode;
			ushort parsedUserInput;
			List<ushort> primeNumbers = new List<ushort>();

			// Vérifie si les nombres entrés sont des nombres entiers non négatifs
			do
			{
				Console.WriteLine("Veuillez indiquer un nombre entier non négatif entre 0 et 31.999 :");
			}
			while (!ushort.TryParse(Console.ReadLine(), out parsedUserInput));
			Console.WriteLine($"➡️ {parsedUserInput} est bien un nombre entier non négatif entre 0 et 31.999.");

			// Vérifier quels nombres sont des nombres premiers AVANT le nombre entré par l'utilisateurice
			ushort firstPrimeNumber = 2;
			while (firstPrimeNumber < parsedUserInput)
			{
				bool isPrime = true;

				// Vérifier si le nombre est '2' ou si le nombre entré est 'pair'
				if (firstPrimeNumber == 2)
				{
					isPrime = true;
				}
				else if (firstPrimeNumber % 2 == 0)
				{
					isPrime = false;
				}
				else
				{
					// Vérifier uniquement les diviseurs impairs, si un diviseur est trouvé, le nombre n'est pas premier
					ushort i = 3;
					while (i <= firstPrimeNumber / 2)
					{
						if (firstPrimeNumber % i == 0)
						{
							isPrime = false;
						}
						i += 2;
					}
				}

				if (isPrime)
				{
					primeNumbers.Add(firstPrimeNumber);
				}
				firstPrimeNumber++;
			}

			Console.WriteLine($"➡️ Les nombres premiers inférieurs à {parsedUserInput} sont :");
			foreach (ushort prime in primeNumbers)
			{
				Console.Write(prime + " ");
			}
		}
	}
}
