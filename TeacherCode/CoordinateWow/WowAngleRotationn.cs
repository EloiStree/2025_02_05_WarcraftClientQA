namespace ClientQA.TeacherCode.CoordinateWow
{
    /// <summary>
    /// I am a class that represents an angle in wow.
    /// It is a counter clockwise 0 to 360 angle.
    /// </summary>
    public class WowAngleRotationn { 
    
        /// <summary>
        ///  The angle of player is a radian 7.2 from left 0 to right 360 
        /// </summary>
        public float m_angleCounterClockwise0To360;
        public float Angle {

            
            get { 
                return m_angleCounterClockwise0To360;
            }
            set
            {
                if (value < 0f)
                {
                    throw new Exception("Value should not be under zero");
                }
                if (value > 360f)
                {
                    throw new Exception("Value should not be over 360");
                }
                m_angleCounterClockwise0To360 = value;
            }
        }

    }
}