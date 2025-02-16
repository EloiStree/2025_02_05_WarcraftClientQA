



using System.Net.Sockets;

public class PushIntegerToGameUDP
{

    public string m_ipAddress;
    public int m_port;
    public int m_playerIndex;
    private UdpClient m_udpClient = new UdpClient();

    public PushIntegerToGameUDP(string ipv4 = "127.0.0.1", int port = 2504, int playerIndex =0)
    {
        m_ipAddress = ipv4;
        m_port = port;
        m_playerIndex = playerIndex;
    }

    public void PushInteger(int integerValue)
    {
        m_udpClient = new UdpClient();
        byte[] bytesIndex = BitConverter.GetBytes(m_playerIndex);
        byte[] bytesInteger = BitConverter.GetBytes(integerValue);
        byte[] bytesToSend = new byte[bytesIndex.Length + bytesInteger.Length];
        bytesIndex.CopyTo(bytesToSend, 0);
        bytesInteger.CopyTo(bytesToSend, bytesIndex.Length);
        m_udpClient.Send(bytesToSend, bytesToSend.Length, m_ipAddress, m_port);
        m_udpClient.Close();//0 1 10 11 100 101  110 111 1000 1001 1010
    }

    public void SwithPlayerIndex(int playerIndex)
    {
        m_playerIndex = playerIndex;
    }
}

//Console.WriteLine("Hello, World!");






///// <summary>
///// Reference of the integer of the keyboard.
///// It allows to give a request of what to do on the remote computer.
///// The enum is based on window keyboard.
///// </summary>
///// <summary>
///// Represent mapping to remote control a xbox gamepad with event.
///// </summary>
//public static class XboxIntegerAction
//{
//    public const int RandomInput = 1399;
//    public const int ReleaseAll = 1390;
//    public const int ReleaseAllButMenu = 1391;
//    public const int ClearTimedCommand = 1398;
//    public const int PressA = 1300;
//    public const int PressX = 1301;
//    public const int PressB = 1302;
//    public const int PressY = 1303;
//    public const int PressLeftSideButton = 1304;
//    public const int PressRightSideButton = 1305;
//    public const int PressLeftStick = 1306;
//    public const int PressRightStick = 1307;
//    public const int PressMenuRight = 1308;
//    public const int PressMenuLeft = 1309;
//    public const int ReleaseDpad = 1310;
//    public const int PressArrowNorth = 1311;
//    public const int PressArrowNortheast = 1312;
//    public const int PressArrowEast = 1313;
//    public const int PressArrowSoutheast = 1314;
//    public const int PressArrowSouth = 1315;
//    public const int PressArrowSouthwest = 1316;
//    public const int PressArrowWest = 1317;
//    public const int PressArrowNorthwest = 1318;
//    public const int PressXboxHomeButton = 1319;
//    public const int RandomAxis = 1320;
//    public const int StartRecording = 1321;
//    public const int SetLeftStickNeutral = 1330;
//    public const int SetLeftStickUp = 1331;
//    public const int SetLeftStickUpRight = 1332;
//    public const int SetLeftStickRight = 1333;
//    public const int SetLeftStickDownRight = 1334;
//    public const int SetLeftStickDown = 1335;
//    public const int SetLeftStickDownLeft = 1336;
//    public const int SetLeftStickLeft = 1337;
//    public const int SetLeftStickUpLeft = 1338;
//    public const int SetRightStickNeutral = 1340;
//    public const int SetRightStickUp = 1341;
//    public const int SetRightStickUpRight = 1342;
//    public const int SetRightStickRight = 1343;
//    public const int SetRightStickDownRight = 1344;
//    public const int SetRightStickDown = 1345;
//    public const int SetRightStickDownLeft = 1346;
//    public const int SetRightStickLeft = 1347;
//    public const int SetRightStickUpLeft = 1348;
//    public const int SetLeftStickHorizontal100 = 1350;
//    public const int SetLeftStickHorizontalNeg100 = 1351;
//    public const int SetLeftStickVertical100 = 1352;
//    public const int SetLeftStickVerticalNeg100 = 1353;
//    public const int SetRightStickHorizontal100 = 1354;
//    public const int SetRightStickHorizontalNeg100 = 1355;
//    public const int SetRightStickVertical100 = 1356;
//    public const int SetRightStickVerticalNeg100 = 1357;
//    public const int SetLeftTrigger100 = 1358;
//    public const int SetRightTrigger100 = 1359;
//    public const int SetLeftStickHorizontal075 = 1360;
//    public const int SetLeftStickHorizontalNeg075 = 1361;
//    public const int SetLeftStickVertical075 = 1362;
//    public const int SetLeftStickVerticalNeg075 = 1363;
//    public const int SetRightStickHorizontal075 = 1364;
//    public const int SetRightStickHorizontalNeg075 = 1365;
//    public const int SetRightStickVertical075 = 1366;
//    public const int SetRightStickVerticalNeg075 = 1367;
//    public const int SetLeftTrigger075 = 1368;
//    public const int SetRightTrigger075 = 1369;
//    public const int SetLeftStickHorizontal050 = 1370;
//    public const int SetLeftStickHorizontalNeg050 = 1371;
//    public const int SetLeftStickVertical050 = 1372;
//    public const int SetLeftStickVerticalNeg050 = 1373;
//    public const int SetRightStickHorizontal050 = 1374;
//    public const int SetRightStickHorizontalNeg050 = 1375;
//    public const int SetRightStickVertical050 = 1376;
//    public const int SetRightStickVerticalNeg050 = 1377;
//    public const int SetLeftTrigger050 = 1378;
//    public const int SetRightTrigger050 = 1379;
//    public const int SetLeftStickHorizontal025 = 1380;
//    public const int SetLeftStickHorizontalNeg025 = 1381;
//    public const int SetLeftStickVertical025 = 1382;
//    public const int SetLeftStickVerticalNeg025 = 1383;
//    public const int SetRightStickHorizontal025 = 1384;
//    public const int SetRightStickHorizontalNeg025 = 1385;
//    public const int SetRightStickVertical025 = 1386;
//    public const int SetRightStickVerticalNeg025 = 1387;
//    public const int SetLeftTrigger025 = 1388;
//    public const int SetRightTrigger025 = 1389;
//}







///// <summary>
///// Reference of the integer of the keyboard.
///// It allows to give a request of what to do on the remote computer.
///// The enum is based on window keyboard.
///// </summary>
///// <summary>
///// Represent mapping to remote control a xbox gamepad with event.
///// </summary>
//public enum XboxIntegerActionEnum
//{
//    RandomInput = 1399,
//    ReleaseAll = 1390,
//    ReleaseAllButMenu = 1391,
//    ClearTimedCommand = 1398,
//    PressA = 1300,
//    PressX = 1301,
//    PressB = 1302,
//    PressY = 1303,
//    PressLeftSideButton = 1304,
//    PressRightSideButton = 1305,
//    PressLeftStick = 1306,
//    PressRightStick = 1307,
//    PressMenuRight = 1308,
//    PressMenuLeft = 1309,
//    ReleaseDpad = 1310,
//    PressArrowNorth = 1311,
//    PressArrowNortheast = 1312,
//    PressArrowEast = 1313,
//    PressArrowSoutheast = 1314,
//    PressArrowSouth = 1315,
//    PressArrowSouthwest = 1316,
//    PressArrowWest = 1317,
//    PressArrowNorthwest = 1318,
//    PressXboxHomeButton = 1319,
//    RandomAxis = 1320,
//    StartRecording = 1321,
//    SetLeftStickNeutral = 1330,
//    SetLeftStickUp = 1331,
//    SetLeftStickUpRight = 1332,
//    SetLeftStickRight = 1333,
//    SetLeftStickDownRight = 1334,
//    SetLeftStickDown = 1335,
//    SetLeftStickDownLeft = 1336,
//    SetLeftStickLeft = 1337,
//    SetLeftStickUpLeft = 1338,
//    SetRightStickNeutral = 1340,
//    SetRightStickUp = 1341,
//    SetRightStickUpRight = 1342,
//    SetRightStickRight = 1343,
//    SetRightStickDownRight = 1344,
//    SetRightStickDown = 1345,
//    SetRightStickDownLeft = 1346,
//    SetRightStickLeft = 1347,
//    SetRightStickUpLeft = 1348,
//    SetLeftStickHorizontal100 = 1350,
//    SetLeftStickHorizontalNeg100 = 1351,
//    SetLeftStickVertical100 = 1352,
//    SetLeftStickVerticalNeg100 = 1353,
//    SetRightStickHorizontal100 = 1354,
//    SetRightStickHorizontalNeg100 = 1355,
//    SetRightStickVertical100 = 1356,
//    SetRightStickVerticalNeg100 = 1357,
//    SetLeftTrigger100 = 1358,
//    SetRightTrigger100 = 1359,
//    SetLeftStickHorizontal075 = 1360,
//    SetLeftStickHorizontalNeg075 = 1361,
//    SetLeftStickVertical075 = 1362,
//    SetLeftStickVerticalNeg075 = 1363,
//    SetRightStickHorizontal075 = 1364,
//    SetRightStickHorizontalNeg075 = 1365,
//    SetRightStickVertical075 = 1366,
//    SetRightStickVerticalNeg075 = 1367,
//    SetLeftTrigger075 = 1368,
//    SetRightTrigger075 = 1369,
//    SetLeftStickHorizontal050 = 1370,
//    SetLeftStickHorizontalNeg050 = 1371,
//    SetLeftStickVertical050 = 1372,
//    SetLeftStickVerticalNeg050 = 1373,
//    SetRightStickHorizontal050 = 1374,
//    SetRightStickHorizontalNeg050 = 1375,
//    SetRightStickVertical050 = 1376,
//    SetRightStickVerticalNeg050 = 1377,
//    SetLeftTrigger050 = 1378,
//    SetRightTrigger050 = 1379,
//    SetLeftStickHorizontal025 = 1380,
//    SetLeftStickHorizontalNeg025 = 1381,
//    SetLeftStickVertical025 = 1382,
//    SetLeftStickVerticalNeg025 = 1383,
//    SetRightStickHorizontal025 = 1384,
//    SetRightStickHorizontalNeg025 = 1385,
//    SetRightStickVertical025 = 1386,
//    SetRightStickVerticalNeg025 = 1387,
//    SetLeftTrigger025 = 1388,
//    SetRightTrigger025 = 1389
//}
