using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace XboxClientQA.TeacherCode.CoordinateWow
{

    public class ToCodeException : Exception { }

    public class WowCoord
    {

        public static bool IsAtRight(
            WowCoord origin, 
            WowCoord target)
        {
            return target.X  > origin.X ;
        }
        public bool IsAtRight(WowCoord point)
        {
            return point.X > this.X;
        }

        public static bool IsAtLeft(
            WowCoord origin,
            WowCoord target)
        {
            return target.X < origin.X;
        }
        public bool IsAtLeft(WowCoord point)
        {
            return point.X < this.X;
        }

        public static bool IsAtUp(
            WowCoord origin,
            WowCoord target)
        {
            return target.Y < origin.Y;
        }
        public bool IsAtUp(WowCoord point)
        {
            return point.Y < this.Y;
        }

        public static bool IsAtDown(
            WowCoord origin,
            WowCoord target)
        {
            return target.Y > origin.Y;
        }

        public bool IsAtDown(WowCoord point)
        {
            return point.Y > this.Y;
        }



        public static float GetDistanceBetween(WowCoord origin, WowCoord target)
        {
            float x = target.X - origin.X;
            float y = target.Y - origin.Y;
            return (float)Math.Sqrt(x * x + y * y);
        }

        public float GetDistanceBetween(WowCoord point)
        {
            return GetDistanceBetween(this, point);
        }

        public static float GetAngleBetween(WowCoord origin, WowCoord target)
        {
            return target.Angle - origin.Angle;
        }
        public float GetAngleBetween(WowCoord point)
        {
            return GetAngleBetween(this, point);
        }


        /// <summary>
        /// Left to right position on wow map from 0 to 100 percent X
        /// </summary>
        private float m_xLeftToRightPercent100=0;
        /// <summary>
        /// Up to down position on wow map from 0 to 100 percent Y
        /// </summary>
        private float m_yUpToDownPercent100=0;


        /// <summary>
        /// Angle from 0 to 360 clockwise from the top
        /// </summary>
        private float m_angleCounterClockwise360 =0;


        public WowCoord()
        {
            m_xLeftToRightPercent100 = 50;
            m_yUpToDownPercent100 = 50;
            m_angleCounterClockwise360=180;
        }
        public WowCoord(float x, float y, float angle)
        {
            m_xLeftToRightPercent100 = x;
            m_yUpToDownPercent100 = y;
            SetAngleCounterClockwise360(angle);
        }

        #region GET SET A LA C#

        public float Angle
        {
            get { return m_angleCounterClockwise360; }
            set { SetAngleCounterClockwise360(value); }
        }

        public float X
        {
            get { return m_xLeftToRightPercent100; }
            set { SetXLeftToRightPercent100(value); }
        }
        public float Y
        {
            get { return m_yUpToDownPercent100; }
            set { SetYUpToDownPercent100(value); }
        }


        #endregion


        #region IS
        
        public bool IsLookingLeft()
        {
            float angle = this.Angle;
            if(angle>0 && angle < 180)
            {
                return true;
            }
            return false;

        }
        public bool IsLookingRight()
        {
            return !IsLookingLeft();
        }

        public bool IsLookingUp() {

            return (Angle > 180.0 && Angle < 360f);
        }
        public bool IsLookingDown()
        {
            return !IsLookingUp();
        }

        public bool IsAngleBetween(float angle0to360,
            float angleMin, 
            float angleMax )
        {

            if(angleMin > angleMax)
            {
                float temp = angleMin;
                angleMin = angleMax;
                angleMax = temp;
            }

            return (Angle > angleMin && Angle < angleMax);

        }      




        #endregion


        #region SETTERS

        public void SetAngleCounterClockwise360(float value)
        {
            if(value < 0f)
            {
                throw new OutOfAngleException("Angle must be positive");
            }
            if (value > 360f)
            {
                throw new OutOfAngleException("Angle must be less than 360");
            }
            m_angleCounterClockwise360 = value;
        }

        public void SetXLeftToRightPercent100(float value)
        {
            if (value < 0f)
            {
                throw new OutOfTheWowMapException("X must be positive");
            }
            if (value > 100f)
            {
                throw new OutOfTheWowMapException("X must be less than 100");
            }
            m_xLeftToRightPercent100 = value;
        }

        public void SetYUpToDownPercent100(float value)
        {
            if (value < 0f)
            {
                throw new OutOfTheWowMapException("Y must be positive");
            }
            if (value > 100f)
            {
                throw new OutOfTheWowMapException("Y must be less than 100");
            }
            m_yUpToDownPercent100 = value;
        }

        #endregion

        #region GETTERS
        public float GetAngleCounterClockwise360()
            => m_angleCounterClockwise360;
        public void GetAngleCounterClockwise360(out float value)
        => value = m_angleCounterClockwise360;

        public float GetXLeftToRightPercent100()
        {
            return m_xLeftToRightPercent100;
        }
        public void GetXLeftToRightPercent100(out float value)
        {
            value = m_xLeftToRightPercent100;
        }

        public float GetYUpToDownPercent100()
        {
            return m_yUpToDownPercent100;
        }
        public void GetYUpToDownPercent100(out float value)
        {
            value = m_yUpToDownPercent100;
        }

      
        #endregion

    }


    public class OutOfAngleException : Exception
    {
        public OutOfAngleException(string message) : base(message)
        {
        }
    }
    public class OutOfTheWowMapException : Exception
    {
        public OutOfTheWowMapException(string message) : base(message)
        {
        }
    }
}