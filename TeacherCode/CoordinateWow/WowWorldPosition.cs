namespace ClientQA.TeacherCode.CoordinateWow
{
    /// <summary>
    /// I am a class storing the position in world game engine position.
    /// Going from -19999 to 19999
    /// </summary>
    public class WowWorldPosition
    {

        public WowWorldPosition() { }
        public WowWorldPosition(double x, double y) {

            m_xRightToleft = x;
            m_yDownToUp = y;
        }
        /// <summary>
        /// From right -19999 to left 19999 (⬅️)
        /// </summary>
        public double m_xRightToleft;


        /// <summary>
        ///  From Down -19999 to up 19999 (⬆️)
        /// </summary>
        public double m_yDownToUp;


    }
}