using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ClientQA.Ninja;
using ClientQA.TeacherCode.CoordinateWow;
using ClientQA.UtilityCode;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Eloi.IID;
using System.Security.Cryptography;
using System.Net.Sockets;
using ClientQA.Toolboxes;
using ClientQA.LearningExample.Basic;
using ClientQA.LearningExample.Core;
using Eloi.Example.Cours;
using ClientQA.Pickup;
using ClientQA.IntWebsocket;
using Eloi.TrustedWss;
namespace ClientQA.IntWebsocket
{
}
namespace ClientQA.TeacherCode
{


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
            int b1 = (b / 16) % 16;
            int b2 = (b) % 16;
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
ID({this.m_tagInListIndex}|{this.m_playerLevel})-{this.m_playerIdFFFFHHHHHHHH}
Target {this.m_targetFFFFHHHHHHHH}
Map: {this.m_mapX} ,{this.m_mapY} , {this.m_angle360} 
World: {this.m_worldX} , {this.m_worldY} 
Life: {this.m_playerLifePercent} 
XP: {this.m_playerXpPercent}
Target:{m_targetLifePercent} {m_targetPowerPercent} {m_targetLevel}
Pet: {this.m_partyPetLifePercent} 
Party:  {this.m_partyAlly1LifePercent} {this.m_partyAlly2LifePercent} {this.m_partyAlly3LifePercent} {this.m_partyAlly4LifePercent} 
";
        }
    }
    public class PlayerReceivedAsInteger
    {
        public int m_playerTag;
        public int m_i01MapX;
        public int m_i02MapY;
        public int m_i03Angle360;
        public int m_i04WorldX;
        public int m_i05WorldY;
        public int m_i06PlayerLevel;
        public int m_i07PlayerLifePercent;
        public int m_i08PlayerXpPercent;
        public int m_i09PartyLife;
        public int m_i10PlayerIdPartOne;
        public int m_i11PlayerIdPartTwo;
        public int m_i12PlayerIdPartThree;
        public int m_i13TargetIdPartOne;
        public int m_i14TargetIdPartTwo;
        public int m_i15TargetIdPartThree;
        public int m_i16TargetLifePercent;
        public int m_i17TargetPowerPercent;
    }
    /// <summary>
    /// I am class that receive integer and reconstruct the info of the scraped game data using UWC
    /// https://github.com/EloiStree/2025_03_02_UWCMirror2Warcraft
    /// </summary>
    public class UWCMirror2Warcraft {


        public Dictionary<int, UWCChampionInfo> m_championsFromInteger = new Dictionary<int, UWCChampionInfo>();
        public Dictionary<int, PlayerReceivedAsInteger> m_playerAsInteger = new Dictionary<int, PlayerReceivedAsInteger>();

      

        int indexFilter = -40;
        public UWCMirror2Warcraft(string serverUrl) {

            WssTrustedWebsocketIIDThread listener = new WssTrustedWebsocketIIDThread(serverUrl);
            listener.AddBytesReceived((byte[] b) =>
            {
                int lenght = b.Length;
                if (lenght == 16)
                {

                    int index = BitConverter.ToInt32(b, 0);
                    if (index != indexFilter) return;

                    int value = BitConverter.ToInt32(b, 4);
                    ulong date = BitConverter.ToUInt64(b, 8);
                    //Console.WriteLine($"index {index} value {value} date {date}");

                    // Add Code Here

                    int playerIndexTag = (int)(value / 100000000);

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

                            PlayerReceivedAsInteger player = new PlayerReceivedAsInteger();
                            player.m_playerTag = playerIndexTag;
                            m_playerAsInteger.Add(playerIndexTag, player);
                            m_championsFromInteger.Add(playerIndexTag, new UWCChampionInfo());
                            Console.WriteLine($"Add player {playerIndexTag}");
                        }

                        m_championsFromInteger[playerIndexTag].m_tagInListIndex = playerIndexTag;
                        //101002705 map x
                        //102004313 map y
                        //103012705
                        //104002064
                        //-105010405
                        //108000549

                        int dataType = ((int)(absValue / 1000000)) % 100;
                        if (dataType != 0)
                        {
                            if (dataType == 1)
                            {

                                int mapX = (int)(value % 1000000);
                                m_playerAsInteger[playerIndexTag].m_i01MapX = mapX;
                                m_championsFromInteger[playerIndexTag].m_mapX = mapX / 100f;
                                //Print($"Player {playerIndexTag} mapX {m_championsFromInteger[playerIndexTag].m_mapX}");
                            }
                            else if (dataType == 2)
                            {
                                int mapY = (int)(value % 1000000);
                                m_playerAsInteger[playerIndexTag].m_i02MapY = mapY;
                                m_championsFromInteger[playerIndexTag].m_mapY = mapY / 100f;
                                //Print($"Player {playerIndexTag} mapY {m_championsFromInteger[playerIndexTag].m_mapY}");
                            }
                            else if (dataType == 3)
                            {
                                int angle360 = (int)(value % 1000000);
                                m_playerAsInteger[playerIndexTag].m_i03Angle360 = angle360;
                                m_championsFromInteger[playerIndexTag].m_angle360 = angle360 / 100f;
                                //Print($"Player {playerIndexTag} angle360 {m_championsFromInteger[playerIndexTag].m_angle360}");
                            }
                            else if (dataType == 4)
                            {

                                int worldX = (int)(absValue % 1000000);
                                if (!sign)
                                    worldX = -worldX;
                                m_playerAsInteger[playerIndexTag].m_i04WorldX = worldX;
                                m_championsFromInteger[playerIndexTag].m_worldX = worldX;
                            }
                            else if (dataType == 5)
                            {
                                int worldY = (int)(absValue % 1000000);
                                if (!sign)
                                    worldY =- worldY;
                                m_playerAsInteger[playerIndexTag].m_i05WorldY = worldY;
                                m_championsFromInteger[playerIndexTag].m_worldY = worldY;
                            }
                            else if (dataType == 6)
                            {
                                int playerLevel = (int)(value % 1000000);
                                m_playerAsInteger[playerIndexTag].m_i06PlayerLevel = playerLevel;
                                m_championsFromInteger[playerIndexTag].m_playerLevel = playerLevel;
                            }
                            else if (dataType == 7)
                            {
                                int playerLifePercent = (int)(value % 1000000);
                                m_playerAsInteger[playerIndexTag].m_i07PlayerLifePercent = playerLifePercent;
                                m_championsFromInteger[playerIndexTag].m_playerLifePercent = playerLifePercent / 10000f;
                                //Print($"Player {playerIndexTag} lifePercent {m_championsFromInteger[playerIndexTag].m_playerLifePercent}");
                            }
                            else if (dataType == 8)
                            {
                                int playerXpPercent = (int)(value % 1000000);
                                m_playerAsInteger[playerIndexTag].m_i08PlayerXpPercent = playerXpPercent;
                                m_championsFromInteger[playerIndexTag].m_playerXpPercent = playerXpPercent / 10000f;
                                //Print($"Player {playerIndexTag} xpPercent {m_championsFromInteger[playerIndexTag].m_playerXpPercent}");
                            }


                            else if (dataType == 16)
                            {
                                int lifePercent = (int)(value % 1000000);
                                m_playerAsInteger[playerIndexTag].m_i16TargetLifePercent = lifePercent;
                                m_championsFromInteger[playerIndexTag].m_targetLifePercent = lifePercent / 10000f;
                            }
                            else if (dataType == 17)
                            {
                                int powerPercent = (int)(value % 1000000);
                                m_playerAsInteger[playerIndexTag].m_i17TargetPowerPercent = powerPercent;
                                m_championsFromInteger[playerIndexTag].m_targetPowerPercent = powerPercent / 10000f;
                            }
                            else if (dataType == 20)
                            {
                                int eventAsInt = (int)(value % 1000000);
                                // Unit start casting spell
                                if (eventAsInt == 1)
                                {

                                }
                            }


                            else if (dataType == 9)
                            {
                                int teamLife = (int)(value % 1000000);
                                byte playerLife= (byte)((teamLife / 100000)%10);
                                byte ally1 = (byte)((teamLife / 10000) % 10);
                                byte ally2 = (byte)((teamLife / 1000) % 10);
                                byte ally3 = (byte)((teamLife / 100) % 10);
                                byte ally4 = (byte)((teamLife / 10) % 10);
                                byte petLife = (byte)((teamLife) % 10);

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
                                int idPartOne = (int)(value % 1000000);
                                m_playerAsInteger[playerIndexTag].m_i10PlayerIdPartOne = idPartOne;
                                int b1 = (idPartOne / 1000) % 1000;
                                int b2 = (idPartOne) % 1000;
                                m_championsFromInteger[playerIndexTag].m_playerGuid[0] = (byte)b1;
                                m_championsFromInteger[playerIndexTag].m_playerGuid[1] = (byte)b2;
                                //Print($"Player {playerIndexTag} idPartOne {m_championsFromInteger[playerIndexTag].m_playerGuid[0]} {m_championsFromInteger[playerIndexTag].m_playerGuid[1]}");

                                m_championsFromInteger[playerIndexTag].UpdatePlayerIdFocusing();
                            }
                            else if (dataType == 11)
                            {
                                int idPartTwo = (int)(value % 1000000);
                                m_playerAsInteger[playerIndexTag].m_i11PlayerIdPartTwo = idPartTwo;
                                int b1 = (idPartTwo / 1000) % 1000;
                                int b2 = (idPartTwo) % 1000;
                                m_championsFromInteger[playerIndexTag].m_playerGuid[2] = (byte)b1;
                                m_championsFromInteger[playerIndexTag].m_playerGuid[3] = (byte)b2;
                                //Print($"Player {playerIndexTag} idPartTwo {m_championsFromInteger[playerIndexTag].m_playerGuid[2]} {m_championsFromInteger[playerIndexTag].m_playerGuid[3]}");

                                m_championsFromInteger[playerIndexTag].UpdatePlayerIdFocusing();
                            }
                            else if (dataType == 12)
                            {
                                int idPartThree = (int)(value % 1000000);
                                m_playerAsInteger[playerIndexTag].m_i12PlayerIdPartThree = idPartThree;
                                int b1 = (idPartThree / 1000) % 1000;
                                int b2 = (idPartThree) % 1000;
                                m_championsFromInteger[playerIndexTag].m_playerGuid[4] = (byte)b1;
                                m_championsFromInteger[playerIndexTag].m_playerGuid[5] = (byte)b2;
                                //Print($"Player {playerIndexTag} idPartThree {m_championsFromInteger[playerIndexTag].m_playerGuid[4]} {m_championsFromInteger[playerIndexTag].m_playerGuid[5]}");

                                m_championsFromInteger[playerIndexTag].UpdatePlayerIdFocusing();


                                //if (m_championsFromInteger[playerIndexTag].IsPlayerGUID())
                                //{
                                    
                                //    UWCChampionInfo champ = m_championsFromInteger[playerIndexTag];
                                //    string description = champ.GetMultilineDescription();
                                //    Print(description);

                                //}

                            }
                            else if (dataType == 13)
                            {
                                int idPartOne = (int)(value % 1000000);
                                m_playerAsInteger[playerIndexTag].m_i13TargetIdPartOne= idPartOne;
                                int b1 = (idPartOne / 1000) % 1000;
                                int b2 = (idPartOne) % 1000;
                                m_championsFromInteger[playerIndexTag].m_targetGuid[0] = (byte)b1;
                                m_championsFromInteger[playerIndexTag].m_targetGuid[1] = (byte)b2;
                                //Print($"Player {playerIndexTag} idPartOne {m_championsFromInteger[playerIndexTag].m_playerGuid[0]} {m_championsFromInteger[playerIndexTag].m_playerGuid[1]}");

                                m_championsFromInteger[playerIndexTag].UpdatePlayerIdFocusing();
                            }
                            else if (dataType == 14)
                            {
                                int idPartTwo = (int)(value % 1000000);
                                m_playerAsInteger[playerIndexTag].m_i14TargetIdPartTwo = idPartTwo;
                                int b1 = (idPartTwo / 1000) % 1000;
                                int b2 = (idPartTwo) % 1000;
                                m_championsFromInteger[playerIndexTag].m_targetGuid[2] = (byte)b1;
                                m_championsFromInteger[playerIndexTag].m_targetGuid[3] = (byte)b2;
                                //Print($"Player {playerIndexTag} idPartTwo {m_championsFromInteger[playerIndexTag].m_playerGuid[2]} {m_championsFromInteger[playerIndexTag].m_playerGuid[3]}");

                                m_championsFromInteger[playerIndexTag].UpdatePlayerIdFocusing();
                            }
                            else if (dataType == 15)
                            {
                                int idPartThree = (int)(value % 1000000);
                                m_playerAsInteger[playerIndexTag].m_i15TargetIdPartThree = idPartThree;
                                int b1 = (idPartThree / 1000) % 1000;
                                int b2 = (idPartThree) % 1000;
                                m_championsFromInteger[playerIndexTag].m_targetGuid[4] = (byte)b1;
                                m_championsFromInteger[playerIndexTag].m_targetGuid[5] = (byte)b2;
                                //Print($"Player {playerIndexTag} idPartThree {m_championsFromInteger[playerIndexTag].m_playerGuid[4]} {m_championsFromInteger[playerIndexTag].m_playerGuid[5]}");

                                m_championsFromInteger[playerIndexTag].UpdatePlayerIdFocusing();


                                if (m_championsFromInteger[playerIndexTag].IsPlayerGUID())
                                {

                                    UWCChampionInfo champ = m_championsFromInteger[playerIndexTag];
                                    string description = champ.GetMultilineDescription();
                                    Print(description);

                                }

                            }
                            else
                            {


                            }



                        }

                    }
                }
            });
        }

        private void Print(string text)
        {
            Console.WriteLine(text);
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
    }

    public partial class TeacherProgram
    {

        

        public static void TeacherMain(string[] args)
        {


            UWCMirror2Warcraft fetchGameInfo = new UWCMirror2Warcraft("wss://apint.ddns.net:4725");
            ChampionThread m_champion = new ChampionThread("apint.ddns.net", 3615, 0);
            string championId = "1402-0AFC1A03";
            
            while (true)
            {
                fetchGameInfo.TryToFetchPlayerByID(championId, out bool found, out UWCChampionInfo champ);
                if (found) {

                    Console.WriteLine(champ.GetMultilineDescription());
                     
                }

                Console.Write(".");
                Thread.Sleep(1000);
            }
        }
    }
}
