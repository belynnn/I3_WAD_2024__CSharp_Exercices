namespace Exo11___Smallest
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// EXERCICE 11
			/*
				Ecrire une application console qui demande à l’utilisateur de taper 10 entiers et qui affiche le
				plus petit de ces entiers. 
			*/

			Console.OutputEncoding = System.Text.Encoding.Unicode;
			short? smallestNb = null;

            for (int i = 1; i < 11; i++)
            {
				string message = $"\n➡️ Veuillez indiquer un {i}{(i == 1 ? "er" : "ème")} nombre entier :\n";
				Console.WriteLine(message);
				string userInput = Console.ReadLine();

				bool isConverted = short.TryParse(userInput, out short parsedUserInput);

				if (!isConverted)
				{
					Console.WriteLine($"{userInput} n'est pas un nombre entier...");
					i--;
				}

				if (smallestNb == null)
				{
					smallestNb = parsedUserInput;
				}
				else
				{
					smallestNb = (parsedUserInput < smallestNb) ? parsedUserInput : smallestNb;
					//if (parsedUserInput < smallestNb)
					//{
					//	smallestNb = parsedUserInput;
					//}
				}
            }
			
			Console.WriteLine($"Le plus petit nombre est {smallestNb} !\n🎉✨🎊🎉✨🎊🎉✨🎊🎉✨🎊🎉✨🎊🎉✨🎊🎉✨🎊🎉✨🎊🎉✨🎊");
		}
	}
}
