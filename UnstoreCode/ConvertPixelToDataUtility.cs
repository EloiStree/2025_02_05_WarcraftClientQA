using ClientQA.TeacherCode;
using static ClientQA.TeacherCode.TeacherProgram;

namespace XboxClientQA.UnstoreCode
{
    public static class ConvertPixelToDataUtility {

        public static void ConvertPixelToLifeXpLevel(PixelColor32 pixel, out float percentLife, out float percentXp, out int level)
        {

             level = pixel.m_r;
             percentLife = pixel.m_g / 255f;
             percentXp = pixel.m_b / 255f;

        }
        public static void ConvertPixelToIntValue(PixelColor32 pixel, out int value)
        {
            //rrggbb  999999
            bool isNegativeX = pixel.m_r >= 100;
            pixel.m_r = (byte)(pixel.m_r % 100);
            int bxc = pixel.m_b;
            int gxc = pixel.m_g * 100;
            int rxc = pixel.m_r * 10000;
            value = (rxc + gxc + bxc) * (isNegativeX ? -1 : 1);


        }
        public static void ConvertPixelToMap2D(PixelColor32 pixel, out float mapPercentX, out float mapPercentY, out float playerAngle)
        {
            mapPercentX = pixel.m_r / 255f * 100f;
            mapPercentY = pixel.m_g / 255f * 100f;
            playerAngle = pixel.m_b / 255f * 360f;

        }
    }
}
