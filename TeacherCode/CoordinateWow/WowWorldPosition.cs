using Eloi.Toolbox;

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



        public override string ToString()
        {
            return $"X: {m_xRightToleft}, Y: {m_yDownToUp}";
        }

        public void GetAsUnityVector2(out UnityVector2 vector)
        {
            vector = new UnityVector2((float)m_xRightToleft, (float)m_yDownToUp);
        }
    }
}