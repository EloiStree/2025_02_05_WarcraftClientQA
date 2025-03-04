namespace ClientQA.LearningExample.Core
{
    public abstract class A_ChampionThreadExample : I_ChampionThreadExample
    {
        public string m_urlToLearnMore;
        public LearnDifficultyLevel m_difficultyLevelOfTheExample;


        public A_ChampionThreadExample()
        {
            m_urlToLearnMore = ProvideLearningUrlHere();
            m_difficultyLevelOfTheExample = ProvideDifficultyLevelhere();
            Console.WriteLine($"Topic {this.GetType()}({m_difficultyLevelOfTheExample.ToString()}): {m_urlToLearnMore}");
        }

        protected abstract string ProvideLearningUrlHere();
        protected abstract LearnDifficultyLevel ProvideDifficultyLevelhere();

        public void Print(string messageToDipslay) {
            Console.WriteLine(">" + messageToDipslay);
        }

        public string LearnURL
        {
            get
            {
                return m_urlToLearnMore;
            }
        }
        public LearnDifficultyLevel Difficulty
        {

            get
            {
                return m_difficultyLevelOfTheExample;
            }
        }
        public void GetDifficultyLevel(out LearnDifficultyLevel difficultyLevelOfTheExample)
        {

            difficultyLevelOfTheExample = m_difficultyLevelOfTheExample;
        }

        public void GetUrlToLearnMore(out string url)
        {
            url = m_urlToLearnMore;
        }

        public void OpenLearnMoreUrl()
        {
            throw new NotImplementedException();
        }
        public abstract void Run(ChampionThread championToUse);
    }


}
