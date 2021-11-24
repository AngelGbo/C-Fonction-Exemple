using System;

namespace SIO
{
    class Program
    {
        static void Main()
        {
            const double TAUX_COMMISSION = 0.05;
            
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Appel d'une fonction avec un paramètre modifiable et un paramètre en sortie
            Console.WriteLine("Appel d'une fonction avec un paramètre modifiable et un paramètre en sortie");

            while (true)
            {
                double montant = 0;
                Console.Write("Montant des ventes du mois (0 pour arrêter) : ");
                montant = double.Parse(Console.ReadLine());
                if (montant == 0) break;

                double prime = montant * TAUX_COMMISSION;
                if (plafonner(prime, out double perte))
                {
                    Console.WriteLine("La prime a été plafonnée à {0:C}, la perte s'élève à {1:C} ", prime, perte);
                }
                else
                {
                    Console.WriteLine("La prime s'élève à {0:C} ", prime);
                }
            }
            Console.WriteLine("Fin du test");
            Console.ReadKey();
        }
    
        /// <summary>
        /// fonction permettant de plafonner la prime à 500 € et de calculer la perte
        /// </summary>
        /// <remarks>
        ///     version utilisant des paramètres en entrée-sortie et en sortie
        /// </remarks>
        /// <param name="prime">prime initiale modifiable par la fonction</param>
        /// <param name="perte">paramètre en sortie recevant la valeur de la perte calculée par la fonction</param>
        /// <returns>true si la prime a été plafonnée ou false sinon</returns>
        static bool plafonner(double prime, out double perte)
        {
            if (prime > 500)
            {
                perte = prime - 500;
                prime = 500;
                return true;
            }
            else
            {
                perte = 0;
                return false;
            }
        }
    }
}
