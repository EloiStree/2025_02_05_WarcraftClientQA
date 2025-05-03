namespace XboxClientQA.UWCMirror
{
    /// <summary>
    /// I am a class that present received data from the game from int format in more readable value
    /// </summary>
    public class UWCChampionInfo
    {

        public float m_mapX;
        public float m_mapY;
        public float m_angle360;
        public float m_worldX;
        public float m_worldY;
        public int m_playerLevel;
        public float m_playerLifePercent;
        public float m_playerXpPercent;
        public string m_playerIdFFFFHHHHHHHH;
        public string m_targetFFFFHHHHHHHH;
        public byte[] m_playerGuid = new byte[6];
        public byte[] m_targetGuid = new byte[6];
        public float m_partyPlayerLifePercent;
        public float m_partyAlly1LifePercent;
        public float m_partyAlly2LifePercent;
        public float m_partyAlly3LifePercent;
        public float m_partyAlly4LifePercent;
        public float m_partyPetLifePercent;
        public int m_tagInListIndex;


        public bool m_asTarget;
        public int m_targetLevel;
        //public float m_targetLife;
        //public float m_targetPower;
        public float m_targetSpellLoading;
        public float m_targetLifePercent;
        public float m_targetPowerPercent;

        public void UpdatePlayerIdFocusing()
        {
            {
                char hexF1, hexF2;
                ByteToFF(m_playerGuid[0], out hexF1, out hexF2);
                m_playerIdFFFFHHHHHHHH = $"{hexF1}{hexF2}";
                ByteToFF(m_playerGuid[1], out hexF1, out hexF2);
                m_playerIdFFFFHHHHHHHH += $"{hexF1}{hexF2}";
                m_playerIdFFFFHHHHHHHH += "-";
                ByteToFF(m_playerGuid[2], out hexF1, out hexF2);
                m_playerIdFFFFHHHHHHHH += $"{hexF1}{hexF2}";
                ByteToFF(m_playerGuid[3], out hexF1, out hexF2);
                m_playerIdFFFFHHHHHHHH += $"{hexF1}{hexF2}";
                ByteToFF(m_playerGuid[4], out hexF1, out hexF2);
                m_playerIdFFFFHHHHHHHH += $"{hexF1}{hexF2}";
                ByteToFF(m_playerGuid[5], out hexF1, out hexF2);
                m_playerIdFFFFHHHHHHHH += $"{hexF1}{hexF2}";

                ByteToFF(m_targetGuid[0], out hexF1, out hexF2);
                m_targetFFFFHHHHHHHH = $"{hexF1}{hexF2}";
                ByteToFF(m_targetGuid[1], out hexF1, out hexF2);
                m_targetFFFFHHHHHHHH += $"{hexF1}{hexF2}";
                m_targetFFFFHHHHHHHH += "-";
                ByteToFF(m_targetGuid[2], out hexF1, out hexF2);
                m_targetFFFFHHHHHHHH += $"{hexF1}{hexF2}";
                ByteToFF(m_targetGuid[3], out hexF1, out hexF2);
                m_targetFFFFHHHHHHHH += $"{hexF1}{hexF2}";
                ByteToFF(m_targetGuid[4], out hexF1, out hexF2);
                m_targetFFFFHHHHHHHH += $"{hexF1}{hexF2}";
                ByteToFF(m_targetGuid[5], out hexF1, out hexF2);
                m_targetFFFFHHHHHHHH += $"{hexF1}{hexF2}";


            }
        }

        public void ByteToFF(byte b, out char hexF1, out char hexF2)
        {
            int b1 = b / 16 % 16;
            int b2 = b % 16;
            hexF1 = (char)(b1 < 10 ? '0' + b1 : 'A' + b1 - 10);
            hexF2 = (char)(b2 < 10 ? '0' + b2 : 'A' + b2 - 10);
        }

        public bool IsPlayerGUID()
        {


            if (HasNotTarget())
            {
                return false;
            }
            IsFocusingNPC(out bool isNPC, out bool isNpcDeath);
            if (isNPC)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool HasNotTarget()
        {
            for (int i = 0; i < m_playerGuid.Length; i++)
            {
                if (m_playerGuid[i] != 255) return false;
            }
            return true;
        }
        public void IsFocusingNPC(out bool isNPC, out bool isNpcDeath)
        {
            isNpcDeath = false;
            isNPC = false;
            if (m_playerGuid[0] == 255
                && m_playerGuid[1] == 0
                && m_playerGuid[2] == 0
                && m_playerGuid[4] == 0
                && m_playerGuid[5] == 0)
            {
                isNPC = m_playerGuid[2] == 0 || m_playerGuid[2] == 255;
                if (isNPC)
                {
                    isNpcDeath = m_playerGuid[3] == 0;
                }
            }
        }

        public string GetMultilineDescription()
        {
            return $@"
ID({m_tagInListIndex}|{m_playerLevel})-{m_playerIdFFFFHHHHHHHH}
Target {m_targetFFFFHHHHHHHH}
Map: {m_mapX} ,{m_mapY} , {m_angle360} 
World: {m_worldX} , {m_worldY} 
Life: {m_playerLifePercent} 
XP: {m_playerXpPercent}
Target:{m_targetLifePercent} {m_targetPowerPercent} {m_targetLevel}
Pet: {m_partyPetLifePercent} 
Party:  {m_partyAlly1LifePercent} {m_partyAlly2LifePercent} {m_partyAlly3LifePercent} {m_partyAlly4LifePercent} 
";
        }
    }

}
