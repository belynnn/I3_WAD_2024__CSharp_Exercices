namespace Exo07___Boucle
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// EXERCICE 7
			/*
				A l'aide d'une boucle, afficher la table de mutliplication par 2.
				La table cite les calculs avec les multipluicateurs de 1 à 10.
			*/

			// CORRECTION
			const int TABLE = 2;
			/*
			short multiplicateur = 1;
			const int TABLE = 2;
			Console.WriteLine($"{TABLE} x {multiplicateur} = {TABLE * multiplicateur}");
			multiplicateur++;
			Console.WriteLine($"{TABLE} x {multiplicateur} = {TABLE * multiplicateur}");
			multiplicateur++;
			*/
			// ETC

			// WHILE
			/*
			short multiplicateur = 1;
			while (multiplicateur <= 10) 
			{
				Console.WriteLine($"{multiplicateur}{(multiplicateur < 10 ? " " : "")} x {TABLE} = {multiplicateur * TABLE}");
				multiplicateur++;
			}
			*/

			// FOR
			/*
            for (short i = 1; i <= 10; i++)
            {
				Console.WriteLine($"{i}{(i < 10 ? " " : "")} x {2} = {i * 2}");
            }
			*/

			// DO...WHILE
			int multiplicateur = 1;
			do
			{
				Console.WriteLine($"{multiplicateur}{(multiplicateur < 10 ? " " : "")} x {TABLE} = {multiplicateur * TABLE}");
				multiplicateur++;
			} while (multiplicateur <= 10);
		}
	}
}
