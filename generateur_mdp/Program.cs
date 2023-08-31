using FormationCS;
using System;


namespace generateur_mdp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            const int NB_MDP = 10;
            int longueur_mdp = outils.DemanderNombrePositifNonNul("Quelle est la longueur du mot de passe ? ");
            Console.WriteLine(longueur_mdp);

            //Liste des alphabets
            string minuscules = "abcdefghijklmnopqrstuvwxz";
            string majuscules = minuscules.ToUpper();
            string chiffres = "0123456789";
            string caractereSpec = "?:!*#";
            string alphabet1 = minuscules;
            string alphabet2 = alphabet1 + majuscules;
            string alphabet3 = alphabet2 + chiffres;
            string alphabet4 = alphabet3 + caractereSpec;
            Console.WriteLine();

            //Liste des choix possibles d'un genre de mot de passe
            Console.WriteLine("Vous voulez un mot de passe avec :");
            Console.WriteLine("1 - Uniquement des caractères en minuscule");
            Console.WriteLine("2 - Des caractères minuscules et majuscules");
            Console.WriteLine("3 - Des caractères et des chiffres");
            Console.WriteLine("4 - Caractères, chiffres et caractères spéciaux");
            int choix = FormationCS.outils.DemanderNombreEntre("Votre choix : ", 1, 4);
            string alphabet = "";

            if (choix == 1 ) { alphabet = alphabet1; }
            else if (choix == 2) { alphabet = alphabet2; }
            else if (choix == 3) { alphabet = alphabet3; }
            else if (choix == 4) { alphabet = alphabet4; }
            string mdp = "";
            Random rand = new Random();
            for (int j = 0;j < NB_MDP; j++)
            {
                mdp = "";
                for (int i = 0; i < longueur_mdp; i++)
                {
                    int caract = rand.Next(0, alphabet.Length);
                    mdp = mdp + alphabet[caract];
                }
                Console.WriteLine(mdp);
            }
            
            
            
        }
    }
}
