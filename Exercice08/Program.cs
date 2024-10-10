namespace Exercice08
{
	internal class Program
	{
		static void Main(string[] args)
		{
            // EXERCICE 8
            /*
				A l'aide de deux boucles, afficher les tables de multiplication de 1 à 9.
				Chaque table cite les calculs avec les multiplicateurs de 1 à 10.
			*/

			for (int i = 1; i < 10; i++)
			{
				Console.WriteLine($"\n---------------\n| Table de {i}  |\n---------------");
				for (int j = 0; j <= 10; j++)
				{
					Console.WriteLine($"| {j}{(j < 10 ? " " : "")} x {i} = {i * j}{((i * j) > 10 ? "" : " ")} |");
				}
				Console.WriteLine($"---------------");
			}

		}
	}
}
