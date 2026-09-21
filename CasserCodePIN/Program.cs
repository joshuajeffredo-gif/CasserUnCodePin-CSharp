using System;
using System.Threading;

namespace CasserCodePIN
{
    class Program
    {
        public static void Main(string[] args)
        {
            // start représente l'heure de démarrage du programme
            DateTime start = DateTime.Now;
            Console.WriteLine("Début du programme");

            // **********************************
            // Générateur de nombre aléatoire
            Random rnd = new Random();
            // Code secret compris entre 0 et 9999
            int codeSecret = rnd.Next(9999);
            // **********************************

            // **********************************
            // booléen qui indique si on a trouvé le code secret
            bool trouve = false;
            // compteur de boucle
            int i = 0;
            while (i < 10000 && trouve == false)
            {
                Console.Write(i + " ");
                i++;
                if (i == codeSecret)
                {
                    trouve = true;
                    Console.WriteLine("\n Vous avez trouvé le code : " + i);
                    break;
                }
                Thread.Sleep(1000);
            }
            // **********************************


            Console.WriteLine("Fin du programme");
            // durée du programme = heure de fin - heure de démarrage
            TimeSpan duree = DateTime.Now - start;
            Console.WriteLine("durée du programme : " + duree);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}