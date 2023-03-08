using System;

/**
 * titre: Test mathématiques
 * description: application qui permet de réaliser 3 calculs mathématiques : permutation, arrangement et combinaison
 * auteur: 
 * date création: 13/06/2020
 * date dernière modification: 08/03/2023
 */

namespace Denombrements
{
    class Program
    {
        static int Permutation (int a, int b)
        {
            int resultat =1;
            for (int i=a; i<=b; i++)
            {
                resultat *= i;
            }
            return resultat;
        }
        static void Main(string[] args)
        {
            string c = "1";
            while (c != "0")
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = Console.ReadLine();
                int total = 0;
                int n=0;
                int resultatPermutation, resultatArrangement, numerateurCombinaison, denominateurCombinaison;

                //Saisie du nombre d'éléments à gérer
                if (c != "0")
                {
                    Console.Write("nombre total d'éléments à gérer = ");
                    total = int.Parse(Console.ReadLine());
                }

                switch (c)
                {
                    case "0":
                        break;
                    case "1": //Permutation
                        // Calcul du résultat
                        resultatPermutation = Permutation(1, total);
                        Console.WriteLine(total + "! = " + resultatPermutation);
                        break;

                    case "2": //Arrangement

                        //Saisir du nombre d'éléments dans le sous-ensemble
                        Console.Write("nombre d'éléments dans le sous ensemble = "); 
                        n = int.Parse(Console.ReadLine()); 

                        // Calcul du résultat
                        resultatArrangement = Permutation(total - n + 1, total);

                        //Affichage résultat
                        Console.WriteLine("A(" + total + "/" + n + ") = " + resultatArrangement);
                        break;

                    case "3": //Combinaison

                        //Saisir du nombre d'éléments dans le sous-ensemble
                        Console.Write("nombre d'éléments dans le sous ensemble = "); 
                        n = int.Parse(Console.ReadLine());

                        //Initialisation et calcul du numerateur
                        numerateurCombinaison = Permutation(total - n + 1, total);
                            
                        // Calcul du dénominateur
                        denominateurCombinaison= Permutation(1, n);
                            
                        //Affichage résultat
                        Console.WriteLine("C(" + total + "/" + n + ") = " + (numerateurCombinaison / denominateurCombinaison));
                        break;

                    default:
                        Console.WriteLine("ERREUR: erreur de saisie.");
                        break;

                }

            }   
        }
    }
}
