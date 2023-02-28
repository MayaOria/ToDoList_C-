using System;
using System.Collections.Generic;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> toDoList = new List<string>();
            string user_choice = "";
            string tache;
            string input;
            int numero;
            int i;

            while (user_choice != "E")
            {
                Console.WriteLine("To Do Liste");
                if (toDoList.Count < 1)
                {
                    do

                    {
                        Console.WriteLine("Votre liste est actuellement vide");
                        Console.WriteLine("Pour ajouter une tâche à la liste, appuyer sur A. Pour sortir du programme, appuyez sur E");
                        user_choice = Console.ReadLine();

                        switch (user_choice)
                        {
                            case "A":

                                Console.WriteLine("Quelle tâche voulez-vous ajouter ? ");
                                tache = Console.ReadLine();
                                toDoList.Add(tache);
                                Console.Clear();

                                break;

                        }
                    }

                    while (user_choice != "A" && user_choice != "E");
                }
                else
                {
                    i = 1;
                    foreach (string item in toDoList)
                    {

                        Console.Write(i + ":");
                        Console.WriteLine(item);
                        i++;
                    }

                    do
                    {


                        Console.WriteLine("Pour ajouter une tâche, tapez A. Pour supprimer une tâche, tapez S, Pour sortir du programme tapez E");
                        user_choice = Console.ReadLine();

                        switch (user_choice)
                        {
                            case "A":
                                Console.Clear();
                                Console.WriteLine("Ajoutez une tâche : ");
                                tache = Console.ReadLine();
                                toDoList.Add(tache);
                                Console.Clear();
                                break;

                            case "S":

                                do
                                {

                                    Console.WriteLine("Quel est le numéro de la tâche que vous souhaitez supprimer ?");
                                    input = Console.ReadLine();
                                }

                                while ((!int.TryParse(input, out numero)) || (numero > toDoList.Count) || (numero < 0));

                                numero--;
                                toDoList.RemoveAt(numero);




                                break;
                        }
                    }

                    while (user_choice != "A" && user_choice != "E" && user_choice != "S");

                }

            }
        }
    }
}
