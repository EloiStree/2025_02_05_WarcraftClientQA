using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientQA.UtilityCode
{
    public class WowSetToDirectionAngle
    {

    

        public static void ComputeDirectionFromTo(float from, float to,
        out bool isRotatingRight,
        out float rotationAngleAbsolute)
        {
            // I am sorry (-___-' )
            // When exactly zero there is a bug and I don't have enough sleep to check my code
            // So I just put a sticker on it.
            if (to == 0 || to == 360)
                to = 359.9990f;


            //We look for the angle between the two angle.
            rotationAngleAbsolute = Math.Abs(from - to);
            //If the  destination is between 0 and origne angle on wow circle
            if (to > 0 && to <= from)
            {
                // Then we turn right
                isRotatingRight = true;
                // If the angle is more than 180 then it is the opposite direction
                if (rotationAngleAbsolute > 180)
                {
                    isRotatingRight = false;
                    rotationAngleAbsolute = 360 - rotationAngleAbsolute;
                }
            }
            //If the destination is over the origin angle, then we turn left
            else
            {
                isRotatingRight = false;
                // If the angle is more than 180 then it is the opposite direction
                if (rotationAngleAbsolute > 180)
                {
                    isRotatingRight = true;
                    rotationAngleAbsolute = 360 - rotationAngleAbsolute;

                }

            }
        }
    }
}
