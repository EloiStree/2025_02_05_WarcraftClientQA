namespace ClientQA.LearningExample.Basic
{
    public class ExerciceToComplete_StringToArrayMacro : I_TextToChampionInterpretor
    {
        public void TryToExecute(in string command, in ChampionThread champion, out bool isCommandValide, out bool executed)
        {
            isCommandValide = false;
            executed = false;

            if (command.StartsWith("im:")) {
                isCommandValide = true;
                executed= TryToParseIntegerToAction(command);
            }
            else if (command.IndexOf("cm:") == 0)
            {
                isCommandValide = true;
                executed= TryToParseCharToAction(command);
            }
            else
            {
                isCommandValide = false;
                executed = false;
            }
        }

        public void RunDefaultTestes(in ChampionThread toTestOn)
        {
            string[] commands = new string[] {
                "im:456123",
                "im:100:123",
                "im:100.0s:123",
                "im:100ms:123",
                "cm:456123",
                "cm:100:Qq",
                "cm:100.0s:Jj",
                "cm:100.0ms:Jj"
            };
            foreach (var command in commands)
            {
               TryToExecute(command.Trim(), toTestOn, out bool isCommandValide, out bool isExecuted);
            } 
        }

        private bool TryToParseIntegerToAction(string command)
        {
            //Example of command
            //im:456123
            //im:100:123
            //im:100.0s:123
            //im:100ms:123
            // See IntegerArrayAndLoop.cs for example
            // ADD YOUR CODE HERE

            return false;
        }
        private bool TryToParseCharToAction(string command)
        {
            //Example of command
            //cm:456123
            //cm:100:Qq
            //cm:100.0s:Jj
            //cm:100.0ms:Jj
            // See MarcoOfCharsWithSwithc.cs for example
            // ADD YOUR CODE HERE

            return false;
        }

    }
}
