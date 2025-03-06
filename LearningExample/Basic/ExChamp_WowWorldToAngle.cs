using ClientQA.LearningExample.Core;
using ClientQA.TeacherCode.CoordinateWow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace XboxClientQA.LearningExample.Basic
{
    public class ExChamp_WowWorldToAngle : A_ChampionThreadExample
    {
        public override void Run(ChampionThread championToUse)
        {
            WowWorldPosition origin = new WowWorldPosition();
            WowWorldPosition destination = new WowWorldPosition();
            float playerAngle = 0;
            float destinationAngle = 0;
            Compute( origin, destination, playerAngle, destinationAngle);
        }

        private void Compute(WowWorldPosition origin, WowWorldPosition destination, float playerAngle, float destinationAngle)
        {

        }

        protected override LearnDifficultyLevel ProvideDifficultyLevelhere()
        {
            return LearnDifficultyLevel.Medior;
        }

        protected override string ProvideLearningUrlHere()
        {
            return "";
        }
    }
}
