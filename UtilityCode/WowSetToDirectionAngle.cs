using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XboxClientQA.UtilityCode
{
    public class WowSetToDirectionAngle
    {

        public static void GetRotationFromTo(float fromAngle, float toAngle, out bool goLeft, out float angleToRotate)
        {
            float bigAngle = fromAngle;
            float smallAngle = toAngle;
            if(bigAngle< toAngle)
            {
                bigAngle = toAngle;
                smallAngle = fromAngle;
            }
            float angleDiff = bigAngle - smallAngle;

            bool originIsLessDestination = fromAngle<toAngle;
            bool left= originIsLessDestination;
            bool inverse = angleDiff > 180f;

            if (inverse)
            {
                angleDiff = 360f - angleDiff;
                left = !left;
            }

            goLeft = left;
            angleToRotate = angleDiff;

        }
    }
}
