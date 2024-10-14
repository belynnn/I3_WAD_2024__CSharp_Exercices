namespace Exo22___Tableaux
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// EXERCICE 22
			/*
				Dans une application Console, initialiser un tableau de 10 entiers avec les valeurs 2, 4, 8, 16,
				32, 64, 128, 256, 512, 1024 à l’aide d’une boucle (c’est l’ordinateur qui doit calculer les
				valeurs, pas l’utilisateur).
				Ensuite, à l’aide d’une boucle afficher la valeur de chaque cellule du tableau.
			*/

			const ushort SIZE = 10;
			ushort[] ushorts = new ushort[SIZE];
			ushort firstValue = 2;

            for (int i = 0; i < ushorts.Length; i++)
            {
				ushorts[i] = firstValue;
				firstValue *= 2;
            }

            foreach (ushort value in ushorts)
            {
				Console.WriteLine(value);
            }
        }
	}
}
