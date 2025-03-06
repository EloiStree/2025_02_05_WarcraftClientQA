using ClientQA.Example.ToCopy.MovingChampion;
using ClientQA.LearningExample.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XboxClientQA.LearningExample.Basic
{
    public class ExChamp_ConsoleMoveAndRotate: A_ChampionThreadExample
    {
        public override void Run(ChampionThread champion )
        {
            ExerciceToComplete_AskPlayerWhereToGo moveChampion = new ExerciceToComplete_AskPlayerWhereToGo();
            moveChampion.Run(champion);

        }

        protected override LearnDifficultyLevel ProvideDifficultyLevelhere()
        {
            return LearnDifficultyLevel.BasicPlus;
        }

        protected override string ProvideLearningUrlHere()
        {
            return "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
        }
    }
}
