using System;

namespace Denombrements
{
    /// <summary>
    /// Correction du système de dénombrement en C#
    /// Romane Chaussis
    /// 17/10/2025
    /// </summary>
    class Program
    {
        /// <summary>
        /// Fonction de calcul qui multiplie les entiers entre nb1 et nb2
        /// </summary>
        static long Calcul(int nb1, int nb2)
        {
            long resultat = 1;
            for (int k = nb1; k <= nb2; k++)
            {
                resultat *= k;
            }
            return resultat;
        }
        /// <summary>
        /// Fonction pour lire un entier au clavier avec gestion d'erreur
        /// </summary>
        static int LireEntier()
        {
            int nb;
            while (!int.TryParse(Console.ReadLine(), out nb))
            {
                Console.Write("Erreur de saisie, recommencez : ");
            }
            return nb;
        }
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                string choix = (Console.ReadLine());

                switch (choix)
                {
                    case "0":
                        return;
                    // Permutation
                    case "1":
                        {
                            Console.Write("Nombre total d'éléments à gérer : ");
                            int n = LireEntier();
                            if (n < 0)
                            {
                                Console.WriteLine("Le nombre doit être supérieur ou égal à 0. ");
                                break;
                            }

                            long r;
                            if (n == 0)
                            {
                                r = 1;
                            }
                            else
                            {
                                r = Calcul(1, n);
                            }
                            Console.WriteLine(n + "! = " + r);
                            break;
                        }
                    // Arrangement
                    case "2":
                        {
                            Console.Write("Nombre total d'éléments à gérer : ");
                            int t = LireEntier();
                            if (t < 0)
                            {
                                Console.WriteLine("Le nombre doit être supérieur ou égal à 0. ");
                                break;
                            }
                            Console.Write("Nombre d'éléments dans le sous-ensemble : ");
                            int n = LireEntier();
                            if (t < n || n < 0 || n > t)
                            {
                                Console.WriteLine("Le nombre d'éléments du sous-ensemble doit être supérieur ou égal à 0 et ne pas dépasser le nombre total d'éléments. ");
                                break;
                            }
                            long r;
                            if (n == 0)
                            {
                                r = 1;
                            }
                            else
                            {
                                r = Calcul(t - n + 1, t);
                            }
                            Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                            break;
                        }
                    // Combinaison
                    case "3":
                        {
                            Console.Write("Nombre total d'éléments à gérer : ");
                            int t = LireEntier();
                            Console.Write("Nombre d'éléments dans le sous-ensemble : ");
                            int n = LireEntier();

                            if (t < 0 || n < 0 || n > t)
                            {
                                Console.WriteLine("Le nombre d'éléments du sous-ensemble doit être supérieur ou égal à 0 et ne pas dépasser le nombre total d'éléments.");
                                break;
                            }
                            long r1, r2;
                            if (n == 0)
                            {
                                r1 = 1;
                                r2 = 1;
                            }
                            else
                            {
                                r1 = Calcul(t - n + 1, t);
                                r2 = Calcul(1, n);
                            }
                            Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                            break;
                        }
                    default:
                        Console.WriteLine("Choix incorrect, tapez 0, 1, 2 ou 3.");
                        break;
                }
            }
        }
    }
}
