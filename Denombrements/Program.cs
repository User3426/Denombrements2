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
        /// Calcule l'arrangement A(t, n), c'est-à-dire le nombre de façons de choisir 
        /// et d'ordonner n éléments parmi t sans répétition.
        /// </summary>
        /// <param name="n">Le nombre d'éléments à sélectionner.</param>
        /// <param name="t">Le nombre total d'éléments disponibles.</param>
        /// <returns></returns>
        static long calcul2(int n, int t)
        {
            long r = 1;
            for (int k = (t - n + 1); k <= t; k++)
                r *= k;
            return r;
        }
        /// <summary>
        /// multiplier une suite d'entiers
        /// </summary>
        /// <param name="n">nombre jusqu'auquel multiplier</param>
        /// <returns></returns>
        static long suiteEntier(int n)
        {
            long r = 1;
            for (int k = 1; k <= n; k++)
                r *= k;
            return r;
        }
        static void Main(string[] args)
        {
            int c = 1;
            while (c != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = int.Parse(Console.ReadLine());

                if (c == 0) { Environment.Exit(0); }

                if (c == 1)
                {
                    // saisir le nombre d'éléments à gérer
                    Console.Write("nombre total d'éléments à gérer = ");
                    int n = int.Parse(Console.ReadLine());
                    // calcul de r                                       
                    long r = suiteEntier(n);
                    Console.WriteLine(n + "! = " + r);
                }
                else
                {
                    if (c == 2)
                    {
                        // saisir le nombre d'éléments à gérer
                        Console.Write("nombre total d'éléments à gérer = "); 
                        int t = int.Parse(Console.ReadLine()); 
                        // saisir le sous ensemble 
                        Console.Write("nombre d'éléments dans le sous ensemble = "); 
                        int n = int.Parse(Console.ReadLine());
                        // calcul de r
                        long r = calcul2(n, t);
                        
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                    }
                    else
                    {
                        // saisir le nombre d'éléments à gérer et le sous ensemble
                        Console.Write("nombre total d'éléments à gérer = "); 
                        int t = int.Parse(Console.ReadLine());
                        Console.Write("nombre d'éléments dans le sous ensemble = "); 
                        int n = int.Parse(Console.ReadLine());
                        // calcul de r1
                        long r1 = calcul2(n, t);
                        // calcul de r2
                        long r2 = suiteEntier(n);
                        
                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
