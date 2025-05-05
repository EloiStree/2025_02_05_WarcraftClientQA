using System.Security.Cryptography.X509Certificates;
using XboxClientQA.UdpListenerToIID;
using XboxClientQA.WssConnection;

namespace XboxClientQA.UWCMirror
{
    /// <summary>
    /// I am class that receive integer and reconstruct the info of the scraped game data using UWC
    /// https://github.com/EloiStree/2025_03_02_UWCMirror2Warcraft
    /// </summary>
    public class UWCMirrorIntToWarcraftChampionsInfo
    {


        public Dictionary<int, UWCChampionInfo> m_championsFromInteger = new Dictionary<int, UWCChampionInfo>();
        public Dictionary<int, UWCPlayerReceivedAsInteger> m_playerAsInteger = new Dictionary<int, UWCPlayerReceivedAsInteger>();


        public Action<UWCChampionInfo> m_onChampionUpdated;
        public Action<UWCChampionInfo,int> m_onChampionEvent;


        int indexFilter = -40;
        internal void PushInInteger(int value)
        {

                    int playerIndexTag = value / 100000000;

                    if (playerIndexTag != 0)
                    {
                        bool sign = playerIndexTag > 0;
                        int absValue = value;
                        if (!sign)
                        {
                            playerIndexTag = -playerIndexTag;
                            absValue = -value;
                        }

                        if (!m_playerAsInteger.ContainsKey(playerIndexTag))
                        {

                            UWCPlayerReceivedAsInteger player = new UWCPlayerReceivedAsInteger();
                            player.m_playerTag = playerIndexTag;
                            m_playerAsInteger.Add(playerIndexTag, player);
                            UWCChampionInfo champion = new UWCChampionInfo();
                            m_championsFromInteger.Add(playerIndexTag, champion);
                            m_onChampionUpdated?.Invoke(champion);
                        }

                        m_championsFromInteger[playerIndexTag].m_tagInListIndex = playerIndexTag;
                        //101002705 map x
                        //102004313 map y
                        //103012705
                        //104002064
                        //-105010405
                        //108000549

                        int dataType = absValue / 1000000 % 100;
                        if (dataType != 0)
                        {
                            if (dataType == 1)
                            {

                                int mapX = value % 1000000;
                                m_playerAsInteger[playerIndexTag].m_i01MapX = mapX;
                                m_championsFromInteger[playerIndexTag].m_mapX = mapX / 100f;
                                //Print($"Player {playerIndexTag} mapX {m_championsFromInteger[playerIndexTag].m_mapX}");
                            }
                            else if (dataType == 2)
                            {
                                int mapY = value % 1000000;
                                m_playerAsInteger[playerIndexTag].m_i02MapY = mapY;
                                m_championsFromInteger[playerIndexTag].m_mapY = mapY / 100f;
                                //Print($"Player {playerIndexTag} mapY {m_championsFromInteger[playerIndexTag].m_mapY}");
                            }
                            else if (dataType == 3)
                            {
                                int angle360 = value % 1000000;
                                m_playerAsInteger[playerIndexTag].m_i03Angle360 = angle360;
                                m_championsFromInteger[playerIndexTag].m_angle360 = angle360 / 100f;
                                //Print($"Player {playerIndexTag} angle360 {m_championsFromInteger[playerIndexTag].m_angle360}");
                            }
                            else if (dataType == 4)
                            {

                                int worldX = absValue % 1000000;
                                if (!sign)
                                    worldX = -worldX;
                                m_playerAsInteger[playerIndexTag].m_i04WorldX = worldX;
                                m_championsFromInteger[playerIndexTag].m_worldX = worldX;
                            }
                            else if (dataType == 5)
                            {
                                int worldY = absValue % 1000000;
                                if (!sign)
                                    worldY = -worldY;
                                m_playerAsInteger[playerIndexTag].m_i05WorldY = worldY;
                                m_championsFromInteger[playerIndexTag].m_worldY = worldY;
                            }
                            else if (dataType == 6)
                            {
                                int playerLevel = value % 1000000;
                                m_playerAsInteger[playerIndexTag].m_i06PlayerLevel = playerLevel;
                                m_championsFromInteger[playerIndexTag].m_playerLevel = playerLevel;
                            }
                            else if (dataType == 7)
                            {
                                int playerLifePercent = value % 1000000;
                                m_playerAsInteger[playerIndexTag].m_i07PlayerLifePercent = playerLifePercent;
                                m_championsFromInteger[playerIndexTag].m_playerLifePercent = playerLifePercent / 10000f;
                                //Print($"Player {playerIndexTag} lifePercent {m_championsFromInteger[playerIndexTag].m_playerLifePercent}");
                            }
                            else if (dataType == 8)
                            {
                                int playerXpPercent = value % 1000000;
                                m_playerAsInteger[playerIndexTag].m_i08PlayerXpPercent = playerXpPercent;
                                m_championsFromInteger[playerIndexTag].m_playerXpPercent = playerXpPercent / 10000f;
                                //Print($"Player {playerIndexTag} xpPercent {m_championsFromInteger[playerIndexTag].m_playerXpPercent}");
                            }


                            else if (dataType == 16)
                            {
                                int lifePercent = value % 1000000;
                                m_playerAsInteger[playerIndexTag].m_i16TargetLifePercent = lifePercent;
                                m_championsFromInteger[playerIndexTag].m_targetLifePercent = lifePercent / 10000f;
                            }
                            else if (dataType == 17)
                            {
                                int powerPercent = value % 1000000;
                                m_playerAsInteger[playerIndexTag].m_i17TargetPowerPercent = powerPercent;
                                m_championsFromInteger[playerIndexTag].m_targetPowerPercent = powerPercent / 10000f;
                            }
                            else if (dataType == 20)
                            {
                                int eventAsInt = value % 1000000;
                                // Unit start casting spell
                                switch(eventAsInt)
                                {
                                    case 0:
                                        m_onChampionUpdated?.Invoke(m_championsFromInteger[playerIndexTag]); 
                                        break;
                                   
                                    default:
                                        break;
                                }
                                m_onChampionEvent?.Invoke(m_championsFromInteger[playerIndexTag], eventAsInt);
                            }


                            else if (dataType == 9)
                            {
                                int teamLife = value % 1000000;
                                byte playerLife = (byte)(teamLife / 100000 % 10);
                                byte ally1 = (byte)(teamLife / 10000 % 10);
                                byte ally2 = (byte)(teamLife / 1000 % 10);
                                byte ally3 = (byte)(teamLife / 100 % 10);
                                byte ally4 = (byte)(teamLife / 10 % 10);
                                byte petLife = (byte)(teamLife % 10);

                                m_playerAsInteger[playerIndexTag].m_i09PartyLife = teamLife;
                                m_championsFromInteger[playerIndexTag].m_partyPlayerLifePercent = playerLife / 9f;
                                m_championsFromInteger[playerIndexTag].m_partyAlly1LifePercent = ally1 / 9f;
                                m_championsFromInteger[playerIndexTag].m_partyAlly2LifePercent = ally2 / 9f;
                                m_championsFromInteger[playerIndexTag].m_partyAlly3LifePercent = ally3 / 9f;
                                m_championsFromInteger[playerIndexTag].m_partyAlly4LifePercent = ally4 / 9f;
                                m_championsFromInteger[playerIndexTag].m_partyPetLifePercent = petLife / 9f;

                                // Print($"Player {playerIndexTag} partyLife {m_championsFromInteger[playerIndexTag].m_partyPlayerLifePercent} {m_championsFromInteger[playerIndexTag].m_partyAlly1LifePercent} {m_championsFromInteger[playerIndexTag].m_partyAlly2LifePercent} {m_championsFromInteger[playerIndexTag].m_partyAlly3LifePercent} {m_championsFromInteger[playerIndexTag].m_partyAlly4LifePercent} {m_championsFromInteger[playerIndexTag].m_partyPetLifePercent}");
                            }
                            else if (dataType == 10)
                            {
                                int idPartOne = value % 1000000;
                                m_playerAsInteger[playerIndexTag].m_i10PlayerIdPartOne = idPartOne;
                                int b1 = idPartOne / 1000 % 1000;
                                int b2 = idPartOne % 1000;
                                m_championsFromInteger[playerIndexTag].m_playerGuid[0] = (byte)b1;
                                m_championsFromInteger[playerIndexTag].m_playerGuid[1] = (byte)b2;
                                //Print($"Player {playerIndexTag} idPartOne {m_championsFromInteger[playerIndexTag].m_playerGuid[0]} {m_championsFromInteger[playerIndexTag].m_playerGuid[1]}");

                                m_championsFromInteger[playerIndexTag].UpdatePlayerIdFocusing();
                            }
                            else if (dataType == 11)
                            {
                                int idPartTwo = value % 1000000;
                                m_playerAsInteger[playerIndexTag].m_i11PlayerIdPartTwo = idPartTwo;
                                int b1 = idPartTwo / 1000 % 1000;
                                int b2 = idPartTwo % 1000;
                                m_championsFromInteger[playerIndexTag].m_playerGuid[2] = (byte)b1;
                                m_championsFromInteger[playerIndexTag].m_playerGuid[3] = (byte)b2;
                                //Print($"Player {playerIndexTag} idPartTwo {m_championsFromInteger[playerIndexTag].m_playerGuid[2]} {m_championsFromInteger[playerIndexTag].m_playerGuid[3]}");

                                m_championsFromInteger[playerIndexTag].UpdatePlayerIdFocusing();
                            }
                            else if (dataType == 12)
                            {
                                int idPartThree = value % 1000000;
                                m_playerAsInteger[playerIndexTag].m_i12PlayerIdPartThree = idPartThree;
                                int b1 = idPartThree / 1000 % 1000;
                                int b2 = idPartThree % 1000;
                                m_championsFromInteger[playerIndexTag].m_playerGuid[4] = (byte)b1;
                                m_championsFromInteger[playerIndexTag].m_playerGuid[5] = (byte)b2;
                                //Print($"Player {playerIndexTag} idPartThree {m_championsFromInteger[playerIndexTag].m_playerGuid[4]} {m_championsFromInteger[playerIndexTag].m_playerGuid[5]}");

                                m_championsFromInteger[playerIndexTag].UpdatePlayerIdFocusing();



                            }
                            else if (dataType == 13)
                            {
                                int idPartOne = value % 1000000;
                                m_playerAsInteger[playerIndexTag].m_i13TargetIdPartOne = idPartOne;
                                int b1 = idPartOne / 1000 % 1000;
                                int b2 = idPartOne % 1000;
                                m_championsFromInteger[playerIndexTag].m_targetGuid[0] = (byte)b1;
                                m_championsFromInteger[playerIndexTag].m_targetGuid[1] = (byte)b2;
                                //Print($"Player {playerIndexTag} idPartOne {m_championsFromInteger[playerIndexTag].m_playerGuid[0]} {m_championsFromInteger[playerIndexTag].m_playerGuid[1]}");

                                m_championsFromInteger[playerIndexTag].UpdatePlayerIdFocusing();
                            }
                            else if (dataType == 14)
                            {
                                int idPartTwo = value % 1000000;
                                m_playerAsInteger[playerIndexTag].m_i14TargetIdPartTwo = idPartTwo;
                                int b1 = idPartTwo / 1000 % 1000;
                                int b2 = idPartTwo % 1000;
                                m_championsFromInteger[playerIndexTag].m_targetGuid[2] = (byte)b1;
                                m_championsFromInteger[playerIndexTag].m_targetGuid[3] = (byte)b2;
                                //Print($"Player {playerIndexTag} idPartTwo {m_championsFromInteger[playerIndexTag].m_playerGuid[2]} {m_championsFromInteger[playerIndexTag].m_playerGuid[3]}");

                                m_championsFromInteger[playerIndexTag].UpdatePlayerIdFocusing();
                            }
                            else if (dataType == 15)
                            {
                                int idPartThree = value % 1000000;
                                m_playerAsInteger[playerIndexTag].m_i15TargetIdPartThree = idPartThree;
                                int b1 = idPartThree / 1000 % 1000;
                                int b2 = idPartThree % 1000;
                                m_championsFromInteger[playerIndexTag].m_targetGuid[4] = (byte)b1;
                                m_championsFromInteger[playerIndexTag].m_targetGuid[5] = (byte)b2;
                                //Print($"Player {playerIndexTag} idPartThree {m_championsFromInteger[playerIndexTag].m_playerGuid[4]} {m_championsFromInteger[playerIndexTag].m_playerGuid[5]}");

                                m_championsFromInteger[playerIndexTag].UpdatePlayerIdFocusing();



                            }
                            else
                            {


                            }



                        }

                    }
                
        }

        public void AddPrintDebugOnPlayerAdd()
        {

            m_onChampionUpdated += (c) =>
            {
                Console.WriteLine($"Add player:\n{c.GetMultilineDescription()}");

            };
        }


        public void TryToFetchPlayerByID(string championId, out bool found, out UWCChampionInfo champ)
        {

            List<UWCChampionInfo> champions = m_championsFromInteger.Values.ToList();
            foreach (UWCChampionInfo champion in champions)
            {
                if (champion == null) continue;
                if (champion.m_playerIdFFFFHHHHHHHH == null) continue;
                if (champion.m_playerIdFFFFHHHHHHHH == championId)
                {
                    found = true;
                    champ = champion;
                    return;
                }
            }
            found = false;
            champ = null;
        }

        public void GetChampionsId(out List<string> ids)
        {
            ids = new List<string>();
            List<UWCChampionInfo> champions = m_championsFromInteger.Values.ToList();
            foreach (UWCChampionInfo champion in champions)
            {
                if (champion == null) continue;
                if (champion.m_playerIdFFFFHHHHHHHH == null) continue;
                ids.Add(champion.m_playerIdFFFFHHHHHHHH);
            }
        }

        public void GetChampions(out List<UWCChampionInfo> champions)
        {
            if (m_championsFromInteger == null)
                champions = new List<UWCChampionInfo>();
            else 

                champions = m_championsFromInteger.Values.ToList();
        }

       

        internal void PushInBytesIID(byte[] obj)
        {
            if (obj == null || obj.Length <= 0)
                return;


            int value =ParseGivenBytesToIntegerFromIID.ParseByteToInt(obj);
            //Console.WriteLine($"PushInBytesIID {value}");
            PushInInteger(value);
        }
    }
}
