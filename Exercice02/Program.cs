namespace Exercice02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCICE 2 - Structure conditionnelle
            /*
            Demander à l’utilisateur d’encoder 1 nombre (int), si la somme des deux moitiés de celui-ci donne le nombre, afficher
            « le nombre est paire » sinon « le nombre est impaire ».
            */
            Console.WriteLine("Veuillez entrer le nombre 1 :\n");
            string userAnswer = Console.ReadLine();

            int resultToConvert;
            bool isConverted;
            isConverted = int.TryParse(userAnswer, out resultToConvert);
            Console.WriteLine($"Conversion réussie ? {isConverted}.");
        }
    }
}
