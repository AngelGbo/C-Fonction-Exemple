using System;

namespace SIO
{
    class Program
    {
        /// <summary>
        /// Cette procédure ajoute un article ...
        /// </summary>
        static void ajout()
        {
            Console.Write("Traitement Ajout ");
            Console.ReadKey();
        }

        /// <summary>
        /// Cette procédure supprime un article ...
        /// </summary>
        static void suppression()
        {
            Console.Write("Traitement Suppression ");
            Console.ReadKey();
        }

        /// <summary>
        /// Cette procédure affiche les articles
        /// </summary>
        static void afficher()
        {
            Console.Write("Traitement Consultation ");
            Console.ReadKey();
        }


        /// <summary>
        /// Cette procédure affiche le menu de l'application.
        /// </summary>
        static void menu()
        {
            Console.WriteLine("Gestion des articles  ");
            Console.WriteLine("1 : Ajout d'un article");
            Console.WriteLine("2 : Suppression d'un article");
            Console.WriteLine("3 : Affichage des articles");
            Console.Write("\nSélection (0 pour quitter): ");
        }

        static void Main()
        {

            while (true)
            {
                menu();
                string rep = Console.ReadLine();
                Console.Clear();
                if (rep == "0") break;
                else if (rep == "1") ajout();
                else if (rep == "2") suppression();
                else if (rep == "3") afficher();
                else
                {
                    Console.WriteLine("Option inexistante");
                    Console.ReadKey();
                }
                Console.Clear();

            }
            Console.WriteLine("Programme terminé, taper une touche pour fermer la fenêtre");
            Console.ReadKey();
        }
    }
}