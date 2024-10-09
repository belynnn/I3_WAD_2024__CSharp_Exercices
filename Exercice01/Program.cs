namespace Exercice01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCICE 1 - int.Parse
            Console.WriteLine("Veuillez entrer le nombre 1 :\n");
            string userAnswer1 = Console.ReadLine();

            Console.WriteLine("Veuillez entrer le nombre 2 :\n");
            string userAnswer2 = Console.ReadLine();

            int userAnswerParsed1 = int.Parse(userAnswer1);
            int userAnswerParsed2 = int.Parse(userAnswer2);

            Console.WriteLine($"{userAnswerParsed1} + {userAnswerParsed2} = {userAnswerParsed1 + userAnswerParsed2}");

            // CORRECTION 1
            Console.WriteLine("Veuillez entrer le nombre 1 :\n");
            int corrUserAnswer1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez entrer le nombre 2 :\n");
            int corrUserAnswer2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{corrUserAnswer1} + {corrUserAnswer2} = {corrUserAnswer1 + corrUserAnswer2}");



            // EXERCICE 1 - int.Tryparse
            Console.WriteLine("Veuillez entrer le nombre 1 :\n");
            string userAnswer3 = Console.ReadLine();

            Console.WriteLine("Veuillez entrer le nombre 2 :\n");
            string userAnswer4 = Console.ReadLine();

            int resultToConvert1;
            bool isConverted1;
            isConverted1 = int.TryParse(userAnswer3, out resultToConvert1);
            Console.WriteLine($"Conversion réussie ? {isConverted1}.");

            int resultToConvert2;
            bool isConverted2;
            isConverted2 = int.TryParse(userAnswer4, out resultToConvert2);
            Console.WriteLine($"Conversion réussie ? {isConverted2}.");

            Console.WriteLine($"{resultToConvert1} + {resultToConvert2} = {resultToConvert1 + resultToConvert2}");
        }
    }
}
