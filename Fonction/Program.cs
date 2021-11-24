using System;

namespace SIO
{
    class Program
    {
        static void Main()
        {

            Console.Write("Valeur de a :");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Valeur de b :");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Valeur de c :");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"La valeur la plus grande entre a et b est {max(a, b)}");

            Console.WriteLine($"La valeur la plus grande des trois est {max(a, b, c)}");

            Console.ReadKey();
        }

        // déclaration des fonctions


        /// <summary>
        /// fonction retournant la valeur la plus grande entre deux entiers passés en paramètre
        /// </summary>
        /// <param name="x">premier nombre</param>
        /// <param name="y">second nombre</param>
        /// <returns>La valeur la plus grande entre x et y</returns>
        static int max(int x = 0, int y = 0)
        {
            int resultat;
            if (x > y)
            {
                resultat = x;
            }
            else
            {
                resultat = y;
            }
            return resultat;
        }

        /// <summary>
        ///    surcharge de la fonction max pour s'appliquer à une liste de valeurs passée en paramètre
        /// </summary>
        /// <param name="lesValeurs">Tableau d'entier contenant les valeurs de la liste</param>
        /// <returns>La valeur la plus grande de la liste</returns>
        static int max(params int[] lesValeurs)
        {
            int result = lesValeurs[0];
            foreach (int uneValeur in lesValeurs)
            {
                if (uneValeur > result) result = uneValeur;
            }
            return result;
        }
    }
}
