namespace ClientQA.LearningExample.Basic
{
    public interface I_TextToChampionInterpretor {

        public void TryToExecute(in string command, in ChampionThread champion, out bool isCommandValide, out bool executed);
        public void RunDefaultTestes(in ChampionThread champion);
    }
}
