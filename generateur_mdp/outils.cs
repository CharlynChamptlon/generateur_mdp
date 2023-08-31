using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCS
{
    static class outils
    {
        public static int DemanderNombrePositifNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue, "Erreur : le nombre doit être positif et non nul.");
        }

        public static int DemanderNombreEntre(string question, int min, int max, string messageErreurPersonnalise = null)
        {

            int nombre = DemanderNombre(question);
            if (nombre >= min && nombre <= max) { return nombre; }

            if (messageErreurPersonnalise == null) { 
                Console.WriteLine($"Erreur : Vous devez entrer un nombre entre {min} et {max}.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(messageErreurPersonnalise);
                Console.WriteLine();
            }
            
            return DemanderNombreEntre(question, min, max, messageErreurPersonnalise);

        }
        public static int DemanderNombre(string question)
        {
            while (true)
            {
                Console.Write(question);
                string reponse = Console.ReadLine();
                try
                {
                    int rep = int.Parse(reponse);
                    return rep;
                }
                catch
                {
                    Console.WriteLine("ERREUR: vous devez rentrer un nombre entier!");
                }
            }
        }
    }
}
