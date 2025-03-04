using ClientQA.LearningExample.Core;

namespace ClientQA.TeacherCode
{
    internal class ExChamp_Topic_IntegerArrayAndloop : A_ChampionThreadExample
    {

            public override void Run(ChampionThread championToUse)
        {

            // Dans World of Warcraft, vous avez des sorts de 0 à 9.
            // Essayons de faire un groupe pour attaquer et un groupe pour se soigner.

            int[] attaque = new int[] { 1, 2, 3, 4, 5 };
            int[] soin = new int[] { 6, 7, 8, 9 };

            // Entre chaque sort, il y a deux secondes.
            // Essayons à la main.
            championToUse.TapPower(attaque[0]);
            championToUse.WaitTwoSeconds();
            championToUse.TapPower(attaque[1]);
            championToUse.WaitTwoSeconds();
            championToUse.TapPower(attaque[2]);
            championToUse.WaitTwoSeconds();
            // ...

            // Ce serait plus simple si l'on bouclait, non ?

            // Créons un compteur mis à zéro.
            int compteur = 0;
            // Stockons la taille du tableau attaque.
            int tailleAttaque = attaque.Length;
            // Tant que le compteur est plus petit que la taille du tableau attaque.
            while (compteur < tailleAttaque)
            {
                // On tape le pouvoir du tableau attaque à l'index du compteur.
                championToUse.TapPower(attaque[compteur]);
                // On attend deux secondes.
                championToUse.WaitTwoSeconds();
                // On incrémente le compteur.
                compteur++;
            }

            // Bon... Admettons que l'on soit bourrin ?
            // On ne pourrait pas cliquer sur toutes les touches ?

            // Utilisons un foreach pour voir si cela est possible.
            foreach (int pouvoir in attaque)
            {
                championToUse.TapPower(pouvoir);
                championToUse.WaitSomeMilliseconds(60);
            }

            // Il y a un problème : si un des sorts se déclenche,
            // le reste est "non accessible".
            // On pourrait spammer de manière aléatoire ?

            // Si, si, essayons avec 10 touches aléatoires.
            System.Random r = new System.Random();
            for (int i = 0; i < 10; i++)
            {
                // On demande un nombre aléatoire entre 0 et la taille du tableau attaque et on le stocke dans la variable pouvoir.
                int pouvoir = r.Next(0, tailleAttaque);
                // On tape le pouvoir du tableau attaque à l'index du compteur.
                championToUse.TapPower(attaque[pouvoir]);
                // On attend quelques millisecondes.
                championToUse.WaitSomeMilliseconds(60);
            }

            // Notez que vous pouvez inverser le tableau.
            int[] tableauInverse = new int[tailleAttaque];
            for (int i = 0; i < tailleAttaque; i++)
            {
                tableauInverse[i] = attaque[tailleAttaque - i - 1];
            }

            // Ou créer un nouveau tableau aléatoire.
            System.Random r1 = new System.Random();
            int[] tableauAleatoire = new int[tailleAttaque];
            for (int i = 0; i < tailleAttaque; i++)
            {
                tableauAleatoire[i] = attaque[r1.Next(0, tailleAttaque)];
            }

            // Vous aimez les macros ?

            // Voici des sorts à lancer ;)

            string macro = "15234666";
            // Transformons cette chaîne en un tableau de caractères.
            char[] macroArray = macro.ToCharArray();
            // Pour chaque caractère dans le tableau, le transformer en entier.
            int[] ints = new int[macroArray.Length];
            for (int i = 0; i < macroArray.Length; i++)
            {
                if (int.TryParse(macroArray[i].ToString(), out int result))
                {
                    // Si c'est un chiffre, on le stocke.
                    ints[i] = result;
                }
                else
                {
                    // Sinon, on le stocke en -1.
                    ints[i] = -1;
                }
            }

            // On peut maintenant lancer les sorts.
            foreach (int pouvoir in ints)
            {
                if (pouvoir != -1)
                {
                    championToUse.TapPower(pouvoir);
                    championToUse.WaitTwoSeconds();
                }
            }

            // Voilà, voilà.

            // Les tableaux, c'est bien, mais c'est un peu rigide.
            // Vous avez une taille fixe.

            // Si l'on veut juste tirer les deux premiers sorts, 
            // on doit créer un tableau de taille 2.
            int[] deuxPremiersSortsAttaque = new int[2];
            deuxPremiersSortsAttaque[0] = attaque[0];
            deuxPremiersSortsAttaque[1] = attaque[1];
            championToUse.TapPower(deuxPremiersSortsAttaque[0]);
            championToUse.WaitSomeSeconds(2);
            championToUse.TapPower(deuxPremiersSortsAttaque[1]);

            // Si vous avez besoin de dynamisme, il vous faut une liste.

            List<int> attaqueList = new List<int>();
            attaqueList.Add(5);
            attaqueList.Add(3);
            attaqueList.Add(1);
            attaqueList.Add(4);

            foreach (int pouvoir in attaqueList)
            {
                championToUse.TapPower(pouvoir);
                championToUse.WaitSomeMilliseconds(1700);
            }
        }


        protected override LearnDifficultyLevel ProvideDifficultyLevelhere()
        => LearnDifficultyLevel.BasicPlus;

        protected override string ProvideLearningUrlHere()
        => "https://github.com/EloiStree/HelloSharpForUnity3D/issues/28";
    }
}