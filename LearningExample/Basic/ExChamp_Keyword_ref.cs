using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientQA.LearningExample.Core;

namespace ClientQA.LearningExample.Basic
{
    public class ExChamp_Keyword_ref : A_ChampionThreadExample
    {

        public string m_currentComputerIp = "127.0.0.1";
        public int m_defaultPort = 7073;
        public int m_playerIndex = 0;
        public override void Run(ChampionThread championToUse)
        {   
            int newPlayerIndex = 0;
            ChangePlayerIndexToRandomValue(ref newPlayerIndex, 1, 4);
        }

        private void ChangePlayerIndexToRandomValue(ref int newPlayerIndex, int minInclusive, int maxInclusive)
        {
            // On génère un outil pou faire de l'aléatoire
            Random r = new Random();
            // On demande un nombre aléatoier entre min et max et on le stock dans la référencet de la variable
            newPlayerIndex= r.Next(minInclusive, maxInclusive);
        }

        public void ChangePlayerIpWithCurrentComputer(ref ChampionThread whoToAffect) { 
            whoToAffect.SetTargetIpv4(m_currentComputerIp);
            whoToAffect.SetTargetPort(m_defaultPort);
            whoToAffect.SetPlayerIndex(m_playerIndex);

        }

        protected override string ProvideLearningUrlHere()
        => "https://github.com/EloiStree/HelloSharpForUnity3D/issues/211";

        protected override LearnDifficultyLevel ProvideDifficultyLevelhere()
        => LearnDifficultyLevel.BasicPlus;
    }
}


