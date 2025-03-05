using ClientQA.LearningExample.Core;
using static System.Net.WebRequestMethods;

namespace ClientQA.LearningExample.Basic
{
    internal class ExChamp_Topic_MacroOfCharsWithSwitchAndIf : A_ChampionThreadExample
    {

        public override void Run(ChampionThread championToUse)
        {
            // Essayons de faire une macro avec des caractères et un Switch

            string testAllMoves = "QqDdSsZzWwXxJjCc";
            string testAllPower = "1234567890";


            //Essayons de voir si tout les mouvements fonctionnnent
            PlayCharMacro(championToUse, testAllMoves, 3);

            //Essayons de voir tout les pouvoirs fonctionnent
            PlayCharMacro(championToUse, testAllPower, 4);

        }

        public void PlayCharMacro(ChampionThread champion, string macro, float timeBetweenAction = 2.0f)
        {
            // Nous alons prentre tout le charactère dans le text macro
            foreach (char c in macro)
            {
                // Essayer de faire une action si la lettre est reconnue
                CharToAction(champion, c, out bool found);
                if (found)
                {
                    // Si l'acion est trouvé, on attend un peu avant de continuer
                    Thread.Sleep((int)(timeBetweenAction * 1000));
                }

                else
                {
                    // Si l'acion n'est pas trouvé, on affiche un message d'erreur dans la console.
                    Console.WriteLine("Action not found for char: " + c);

                    // Ou émettre une exception si vous aimez la discipline
                    throw new Exception("Action not found for char: " + c);

                }
            }
        }

        public void CharToAction(ChampionThread champion, char c, out bool found)
        {

            found = true;
            switch (c)
            {

                case '0': champion.TapPower0(); return;
                case '1': champion.TapPower1(); return;
                case '2': champion.TapPower2(); return;
                case '3': champion.TapPower3(); return;
                case '4': champion.TapPower4(); return;
                case '5': champion.TapPower5(); return;
                case '6': champion.TapPower6(); return;
                case '7': champion.TapPower7(); return;
                case '8': champion.TapPower8(); return;
                case '9': champion.TapPower9(); return;
            }

            switch (c)
            {

                case 'Q': champion.StartRotateLeft(); return;
                case 'q': champion.StopRotateRight(); return;
                case 'D': champion.StartRotateRight(); return;
                case 'd': champion.StopRotateRight(); return;
                case 'Z': champion.StartMovingForward(); return;
                case 'z': champion.StopMovingForward(); return;
                case 'S': champion.StartMovingBackward(); return;
                case 's': champion.StopMovingBackward(); return;
                case 'W': champion.StartStrafeLeft(); return;
                case 'w': champion.StopStrafeLeft(); return;
                case 'X': champion.StartStrafeRight(); return;
                case 'x': champion.StopStrafeRight(); return;
                case 'J': champion.StartMovingUpward(); return;
                case 'j': champion.StopMovingUpward(); return;
                case 'C': champion.StartMovingDownward(); return;
                case 'c': champion.StopMovingDownward(); return;
            }

            found = false;
        }

        protected override LearnDifficultyLevel ProvideDifficultyLevelhere()
        => LearnDifficultyLevel.BasicPlus;

        protected override string ProvideLearningUrlHere()
        => "https://github.com/EloiStree/HelloSharpForUnity3D/issues/360";
    }
}