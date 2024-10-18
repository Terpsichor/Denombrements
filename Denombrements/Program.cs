using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// Demande la saisie d'un entier et le retourne
        /// </summary>
        /// <param name="message">le message a afficher à l'utilisateur</param>
        /// <returns></returns>
        static int Saisie(string message)
        {
            bool correct = false;
            int nbr = 0;
            do
            {
                try
                {
                    Console.Write(message);
                    nbr = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Saisissez un entier.");
                }
            } while (!correct);
            return nbr;
        }

        /// <summary>
        /// Multiplication d'une suite d'entier, d'une valeur à une autre.
        /// </summary>
        /// <param name="val1">La première valeur</param>
        /// <param name="val2">La seconde valeur</param>
        /// <returns></returns>
        static long Multiplication(int val1, int val2)
        {
            long resultat = 1;
            for (int k = val1; k <= val2; k++)
            {
                resultat *= k;
            }
            return resultat;
        }

        /// <summary>
        /// Programme de calcul de Permutation, Arrangement et Combinaison
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int choix = 1, nombre, total;
            long resultat, resultat1, resultat2;

            while (choix != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                choix = Saisie("Choix :                            ");

                switch (choix)
                {
                    case 1:
                        nombre = Saisie("nombre total d'éléments à gérer = ");
                        // calcul de resultat
                        resultat = Multiplication(1, nombre);
                        /*for (int k = 1; k <= nombre; k++)
                        {
                            resultat *= k;
                        } */
                        Console.WriteLine(nombre + "! = " + resultat);
                        break;

                    case 2:
                        total = Saisie("nombre total d'éléments à gérer = ");
                        nombre = Saisie("nombre d'éléments dans le sous ensemble = ");
                        // calcul de resultat
                        resultat = Multiplication((total - nombre + 1), total);
                        /*for (int k = (total - nombre + 1); k <= total; k++)
                        {
                            resultat *= k;
                        } */
                        Console.WriteLine("A(" + total + "/" + nombre + ") = " + resultat);
                        break;

                    case 3:
                        total = Saisie("nombre total d'éléments à gérer = ");
                        nombre = Saisie("nombre d'éléments dans le sous ensemble = ");
                        // calcul de r1
                        resultat1 = Multiplication((total - nombre + 1), total);
                        /*for (int k = (total - nombre + 1); k <= total; k++)
                        {
                            resultat1 *= k;
                        } */
                        // calcul de r2
                        resultat2 = Multiplication(1, nombre);
                        /*for (int k = 1; k <= nombre; k++)
                        {
                            resultat2 *= k;
                        } */
                        Console.WriteLine("C(" + total + "/" + nombre + ") = " + (resultat1 / resultat2));
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
