namespace Exercice03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCICE 3
            /*
            Demander à l’utilisateur d’encoder 1 nombre (int), si la somme des deux moitiés de celui-ci donne le nombre, afficher
            « le nombre est paire » sinon « le nombre est impaire ».
            Vérifier que l'utilisateur a bien entré un nombre entier et non du texte.
            */

            // CORRECTION
            Console.WriteLine("Veuillez indiquer un nombre (entier) : ");
            string? userInput = Console.ReadLine();
            bool isConverted = int.TryParse(userInput, out int userNb);

			if (!isConverted)
			{
				Console.WriteLine("On avait dit un nombre entier...");
			}
			else
			{
				if (userNb / 2 + userNb / 2 == userNb)
				{
					Console.WriteLine($"Le nombre {userNb} est paire.");
				}
				else
				{
					Console.WriteLine($"Le nombre {userNb} est impaire.");
				}
			}

            //Console.WriteLine("Veuillez entrer un nombre entier :\n");
            //string userAnswer = Console.ReadLine();
            //int number;

                //if (int.TryParse(userAnswer, out number))
                //{
                //    int half1 = number / 2;
                //    int doubleHalf1 = half1 * 2;

                //    if (doubleHalf1 == number)
                //    {
                //        Console.WriteLine("Le nombre est paire.");
                //    }
                //    else
                //    {
                //        Console.WriteLine("Le nombre est impaire.");
                //    }
                //}
                //else
                //{
                //    Console.WriteLine("Vous n'avez pas entré un nombre entier valide.");
                //}
        }
    }
}
