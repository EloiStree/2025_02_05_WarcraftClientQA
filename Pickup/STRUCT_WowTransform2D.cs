using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XboxClientQA.Pickup
{



    public struct STRUCT_WowTransform2D
    {
        public float m_xLeftRightPercentRaw;
        public float m_yTopDownPercentRaw;
        public float m_angleDegreeInverseClockWiseRaw;
        public STRUCT_WowTransform2D(float leftRightPercent, float topDownPercent, float angleInverseClockWise)
        {
            m_xLeftRightPercentRaw = leftRightPercent;
            m_yTopDownPercentRaw = topDownPercent;
            m_angleDegreeInverseClockWiseRaw = angleInverseClockWise;
        }

        public void GetLeftRightPercent(out float leftRightPercent)
        {
            leftRightPercent = m_xLeftRightPercentRaw;
        }
        public void GetTopDownPercent(out float topDownPercent)
        {
            topDownPercent = m_yTopDownPercentRaw;
        }
        public void GetAngleInverseClockWise(out float angleInverseClockWise)
        {
            angleInverseClockWise = m_angleDegreeInverseClockWiseRaw;
        }
        public void GetRightLeftPercent(out float rightLeftPercent)
        {
            rightLeftPercent = 1f - m_xLeftRightPercentRaw;
        }
        public void GetDownTopPercent(out float downTopPercent)
        {
            downTopPercent = 1f - m_yTopDownPercentRaw;
        }

        public void SetFromRGB(int r, int g, int b)
        {
            m_xLeftRightPercentRaw = (r / 255f)*100f;
            m_yTopDownPercentRaw = (g / 255f)*100f;
            m_angleDegreeInverseClockWiseRaw = b / 255f * 360f;
        }

        public override string? ToString()
        {
            return string.Format("X:{0} Y:{1} A:{2}", m_xLeftRightPercentRaw, m_yTopDownPercentRaw, m_angleDegreeInverseClockWiseRaw);
        }
    }
}
