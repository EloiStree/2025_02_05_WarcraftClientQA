namespace ClientQA.TeacherCode.CoordinateWow
{
    public static class WowWorldPositionUtility {

        public static double Distance(
    WowWorldPosition origin,
    WowWorldPosition destination)
        {
            double x = Math.Abs(destination.m_xRightToleft - origin.m_xRightToleft);
            double y = Math.Abs(destination.m_yDownToUp - origin.m_yDownToUp);
            double hypothenuse = Math.Sqrt(x * x + y * y);
            return hypothenuse;
        }
    }
}