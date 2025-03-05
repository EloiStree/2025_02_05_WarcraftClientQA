using ClientQA.LearningExample.Core;

namespace ClientQA.LearningExample.Basic
{
    internal class ExChamp_Topic_StringStartWithAndIndexOf : A_ChampionThreadExample
    {
        public override void Run(ChampionThread championToUse)
        {
            // Si l'on veut tourner à gauche de 21 degrés.
            // Ne pourrait-on pas faire des "macro" personnalisées ?
            // Example de macro personnalisée
            // RL21
            // RL45
            // M2.42
            // ML1
            // MR4

            // Essayons de voir différent manière des les traiter.

            // Vous pouvez le faire avec des charactères

            string macro = @"
            RL21    
            RL45
            M2.42
            ML1
            MR4
            ";

            // Coupons le text en morceaux
            string[] commands = macro.Split(' ');
            // Nettoyons les espaces en trop
            for (int i = 0; i < commands.Length; i++)
            {
                commands[i] = commands[i].Trim();
            }

            // Pour chaque morceau essaysons de les identifier
            foreach (string command in commands)
            {

                // Stockons la longueur du morceau car nous allons l'utiliser plusieurs fois
                int lenght = command.Length;
                // Si la longeur est 0, on ne fait rien car la commande est vide
                if (lenght == 0)
                    continue;

                if (lenght > 2)
                {

                    if (command[0] == 'R' && command[1] == 'L')
                    {
                        string value = command.Substring(2);
                        if (int.TryParse(value, out int angle))
                        {
                            championToUse.RotationOfLeftAngle(angle);
                            continue;
                        }
                    }
                    // Essayons pour le fun avec un StartWith
                    if (command.StartsWith("RL"))
                    {
                        string value = command.Substring(2);
                        if (int.TryParse(value, out int angle))
                        {
                            championToUse.RotationOfLeftAngle(angle);
                            continue;
                        }
                    }

                    // Une autre manière de faire est de vérifier 
                    // La présente au début de ML
                    // Index of retourne -1 si la chaine n'est pas trouvé
                    // Sinon il retourne la position de la recherche
                    if (command.IndexOf("ML") == 0)
                    {
                        string value = command.Substring(2);
                        if (int.TryParse(value, out int distance))
                        {
                            championToUse.StrafeForDistanceLeftRight(distance);
                            continue;
                        }
                    }

                }
            }
        }


        public void GetMillisecondsDependingOfDot(string text, out int resultAsMilliseconds)
        {

            if (text.Contains('.'))
            {
                string[] parts = text.Split('.');
                int.TryParse(parts[1], out int milli);
                int.TryParse(parts[0], out int seconds);
                resultAsMilliseconds = seconds * 1000 + milli;
            }
            else
            {
                int.TryParse(text, out resultAsMilliseconds);
            }
        }


        protected override LearnDifficultyLevel ProvideDifficultyLevelhere()
        {
            throw new NotImplementedException();
        }

        protected override string ProvideLearningUrlHere()
        {
            throw new NotImplementedException();
        }
    }
}