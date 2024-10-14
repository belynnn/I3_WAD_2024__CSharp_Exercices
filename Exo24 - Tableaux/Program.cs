namespace Exo24___Tableaux
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Exercice 24
			/*
				Inverser un tableau : soit un tableau T. Saisir ce tableau. Changer de place les éléments de ce
				tableau de façon à ce que le nouveau tableau soit une sorte de miroir de l'ancien et afficher le
				nouveau tableau. 
			*/

			Console.OutputEncoding = System.Text.Encoding.Unicode;

			// Initialiser un tableau
			ushort[] ushorts = { 4, 3, 2, 1, 0 };

			// Afficher les valeurs du tableau
			/*
			foreach (ushort value in ushorts)
			{
				Console.WriteLine($"{value}");
			}
			*/

			// Itérer sur chaque indice
			for (ushort i = 0; i < ushorts.Length / 2; i++)
            {
                ushort temp = ushorts[i];
				ushorts[i] = ushorts[ushorts.Length - 1 - i];
				ushorts[ushorts.Length - 1 - i] = temp;
			}

			// Afficher les valeurs du tableau inversé
            foreach (ushort value in ushorts)
            {
                Console.WriteLine($"{value}");
            }
        }
	}
}
