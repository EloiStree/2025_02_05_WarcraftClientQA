    public class LambdaActionDictionary
    {
        // What is lambda:
        // https://www.programiz.com/csharp-programming/lambda-expression#:~:text=C%23%20Lambda%20Expression%20is%20a,%2C%20num%20%3D>%20num%20*%207

        public Dictionary<string, Action> m_simpleActionRegister = new Dictionary<string, Action>();
        public Dictionary<string, Action<ChampionThread, object>> m_actionWithParameterRegister = new Dictionary<string, Action<ChampionThread, object>>();

        public void AddSimpleAction(string exactLabel, Action action)
        {
            if (m_simpleActionRegister.ContainsKey(exactLabel))
            {
                m_simpleActionRegister[exactLabel] = action;
            }
            else
            {
                m_simpleActionRegister.Add(exactLabel, action);
            }
        }
        public void ExecuteIfExistSimpleAction(string exactLabel, out bool found)
        {
            if (m_simpleActionRegister.ContainsKey(exactLabel))
            {
                m_simpleActionRegister[exactLabel]();
                found = true;

            }
            else
            {
                found = false;
            }
        }


        public void AddChampionWithInfoAction(string exactLabel, Action<ChampionThread, object> action)
        {

            if (m_actionWithParameterRegister.ContainsKey(exactLabel))
            {
                m_actionWithParameterRegister[exactLabel] = action;
            }
            else
            {
                m_actionWithParameterRegister.Add(exactLabel, action);
            }
        }
        public void ExecuteIfExistActionTool(string exactLabel, ChampionThread target, object parameter, out bool found)
        {
            if (m_actionWithParameterRegister.ContainsKey(exactLabel))
            {
                m_actionWithParameterRegister[exactLabel](target, parameter);
                found = true;
            }
            else
            {
                found = false;
            }
        }
    }

