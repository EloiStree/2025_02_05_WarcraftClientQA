    public class LambdaActionDictionary
    {
        // What is lambda:
        // https://www.programiz.com/csharp-programming/lambda-expression#:~:text=C%23%20Lambda%20Expression%20is%20a,%2C%20num%20%3D>%20num%20*%207

        public Dictionary<string, Action> m_simpleActionRegister = new Dictionary<string, Action>();
        public Dictionary<string, Action<Champion, object>> m_specificRegister = new Dictionary<string, Action<Champion, object>>();

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
        public void AddActionTool(string exactLabel, Action<Champion, object> action)
        {

            if (m_specificRegister.ContainsKey(exactLabel))
            {
                m_specificRegister[exactLabel] = action;
            }
            else
            {
                m_specificRegister.Add(exactLabel, action);
            }
        }
        public void ExecuteIfExistActionTool(string exactLabel, Champion target, object parameter, out bool found)
        {
            if (m_specificRegister.ContainsKey(exactLabel))
            {
                m_specificRegister[exactLabel](target, parameter);
                found = true;

            }
            else
            {
                found = false;
            }
        }
    }

