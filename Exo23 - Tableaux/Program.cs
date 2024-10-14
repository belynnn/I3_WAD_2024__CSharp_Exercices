namespace Exo23___Tableaux
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// EXERCICE 23
			/*
				Écrire une application Console demandant à l’utilisateur le nombre de joueurs (max 10 joueurs).
				Ensuite, à l’aide d’un tableau, demandez à l’utilisateur d’encoder le score de chaque joueur.
				Une fois ceci fini, il faut afficher la moyenne des scores. 
			*/

			Console.OutputEncoding = System.Text.Encoding.Unicode;

			const ushort MIN_PLAYER = 2;
			const ushort MAX_PLAYER = 10;

			// Vérifier si l'entrée de l'utilisateurice est bien un nombre entier non négatif, entre 1 et 10
			ushort parsedUserInput;
			do
			{
				Console.WriteLine($"Veuillez indiquer le nombre de joueureuses (entre {MIN_PLAYER} et {MAX_PLAYER}) :");
			}
			while (!ushort.TryParse(Console.ReadLine(), out parsedUserInput) || parsedUserInput > MAX_PLAYER || parsedUserInput < MIN_PLAYER);
			//Console.WriteLine($"➡️ {parsedUserInput} est bien un nombre entier non négatif, entre {MIN_PLAYER} et {MAX_PLAYER}.\n");

			// Initialiser le tableau d'équipe avec la taille entrée par l'utilisateurice
			ushort[] team = new ushort[parsedUserInput];

			// Demander le score par le nombre de joueureuses inscrit
			for (int i = 0; i < team.Length; i++)
			{
				// Vérifier si l'entrée de l'utilisateurice est bien un nombre entier non négatif
				do
				{
					Console.WriteLine($"Score J{i+1} :");
				}
				while (!ushort.TryParse(Console.ReadLine(), out parsedUserInput));
				//Console.WriteLine($"➡️ {parsedUserInput} est bien un nombre entier non négatif.\n");

				// Encoder le score dans le tableau
				team[i] = parsedUserInput;
			}

			// Itérer sur chaque indice pour calculer la somme totale de l'équipe
			double sum = 0;
            foreach (ushort scores in team)
            {
				sum += scores;
            }

			double average = sum / team.Length;

            Console.WriteLine($"➡️ Moyenne de l'équipe : {average}");
        }
	}
}
