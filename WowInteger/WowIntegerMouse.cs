public static class WowIntegerMouse {

    /*
       1599998888
       15 Mouse Move type
       9999: percent width screen 0-9999
       8888: percent height screen 0-9999
       Label	Press	Release
       Mouse Left	1260	2260
       Mouse Middle	1261	2261
       Mouse Right	1262	2262
       Mouse Button 4	1263	2263
       Mouse Button 5	1264	2264
       Mouse Double Click Left	1265	2265
       Mouse Triple Click Left	1266	2266
       Mouse Double Click Right	1267	2267
       Mouse Triple Click Right	1268	2268
     */
    public static void PackMoveMouse(float left2RightPercent01, float down2TopPercent01, out int action) { 
        action = 1500000000;
        action+= (int)(left2RightPercent01 * 9999)*10000;
        action+= (int)(down2TopPercent01 * 9999);
    }
    public static void IsMouseAction(int action, out bool isMouseAction)
    {
        isMouseAction = action >= 1500000000 && action < 1600000000;
    }
    public static void UnpackMoveMouse(int action, out bool isMoveAction, out float left2RightPercent01, out float down2TopPercent01)
    {
        isMoveAction = action >= 1500000000 && action < 1600000000;
        if (isMoveAction)
        {
            left2RightPercent01 = 0;
            down2TopPercent01 = 0;
            return;
        }
        down2TopPercent01 = (action) / 9999.0f;
        left2RightPercent01 = (action / 10000f) / 9999.0f;
    }

    public const int MouseLeft = 1260;
    public const int MouseMiddle = 1261;
    public const int MouseRight = 1262;
    public const int MouseButton4 = 1263;
    public const int MouseButton5 = 1264;
    public const int MouseDoubleClickLeft = 1265;
    public const int MouseTripleClickLeft = 1266;
    public const int MouseDoubleClickRight = 1267;
    public const int MouseTripleClickRight = 1268;

}
