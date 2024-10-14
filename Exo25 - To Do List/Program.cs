using System.Collections;

namespace Exo25___To_Do_List
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// EXERCICE 25
			/*
				Créez une application Console permettant de gérer une To-Do List (liste de choses à faire).
				L’utilisateur doit pouvoir introduire une tâches, supprimer une tâche et modifier une tâche. 
			*/

			Console.OutputEncoding = System.Text.Encoding.Unicode;

			const string ADD_TASK = "A";
			const string EDIT_TASK = "E";
			const string DELETE_TASK = "D";
			const string NEW_LINE = "\n";

			Console.WriteLine($"Bienvenue dans ~Not~To~Do~List~ 2000 !\n");
            Console.WriteLine($"Pour ajouter une nouvelle tâche à ne pas faire [{ADD_TASK}]");
            Console.WriteLine($"Pour éditer une tâche à ne pas faire [{EDIT_TASK}]");
            Console.WriteLine($"Pour supprimer une tâche à ne pas faire [{DELETE_TASK}]");
            Console.WriteLine(NEW_LINE);

			Hashtable ht = new Hashtable();
		}
	}
}
