namespace ClientQA.LearningExample.Core
{
    public interface I_ChampionThreadExample
    {
        public void GetDifficultyLevel(out LearnDifficultyLevel difficultyLevelOfTheExample);
        public void GetUrlToLearnMore(out string url);
        public void OpenLearnMoreUrl();
        public void Run(ChampionThread championToUse);
    }


}
