namespace Exercice07
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

            for (int i = 1; i <= 10; i++)
            {
				Console.WriteLine($"{i}{(i < 10 ? " " : "")} x {2} = {i * 2}");
            }
        }
	}
}
