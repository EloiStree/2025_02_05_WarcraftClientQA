using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using XboxClientQA.UtilityCode;

namespace XboxClientQA.TeacherCode.CoordinateWow
{

    public class ConsoleWowCoord { 
    
    
        public static void AskForPosition(out WowCoord current,string displayMessage)
        {
            try { 
                Console.WriteLine(displayMessage);
                Console.WriteLine("Enter X:");
                float x = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Y:");
                float y = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Angle:");
                float angle = float.Parse(Console.ReadLine());
                current = new WowCoord(x, y, angle);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                current = new WowCoord();
            }
        }
        public static void AskForDirectionInfo(
            out WowCoord origin,
            out WowCoord target,
            out float distance,
            out bool isLeftDirection,
            out float angleToRotate,
            out float rotationTime,
            bool debugConsole =true)
        {
        
            AskForPosition(out origin,"Give origin");
            AskForPosition(out target,"Give target");
            WowCoord.GetCountClockwiseAngle(
                origin, target,
                out float dirAngle);
            distance = WowCoord.GetDistanceBetween(origin, target);
            WowSetToDirectionAngle
                .GetRotationFromTo(origin.Angle, dirAngle,
                out isLeftDirection, out angleToRotate);
            ChampionMoveAndRotate.
                Rotate(angleToRotate, out rotationTime);

            if (debugConsole) { 
                Console.WriteLine("Distance: " + distance);
                Console.WriteLine("Direction Angle: " + dirAngle);
                Console.WriteLine("Is Left Direction: " + isLeftDirection);
                Console.WriteLine("Angle To Rotate: " + angleToRotate);
                Console.WriteLine("Rotation Time: " + rotationTime);
            }
        }


        public static void AskForAngleOnly(out float angle, string displayMessage) {

            try
            {
                Console.WriteLine(displayMessage);
                angle = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                angle = 0;
            }

        }


        public static void FetchAngleInto(
           ref WowCoord origin,
           ref  WowCoord target
           )
        {
            AskForAngleOnly(out float startAngle, 
                "Give start angle");
            AskForAngleOnly(out float stopAngle,
                "Give stop angle");
            origin.Angle = startAngle;
            target.Angle = stopAngle;
        }

      
    }


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


        public static void GetCountClockwiseAngle(WowCoord origin,
            WowCoord target,
            out float angleCounterClockwise)
        {
            origin.GetVector2D(out Vector2 originVector);
            target.GetVector2D(out Vector2 targetVector);
            Vector2 direction = targetVector - originVector;
            direction.X = -direction.X;
            // Get clockwise angle from y axis
            // Generated with 🤖 Copilote
            angleCounterClockwise = (float)Math.Atan2(direction.X, -direction.Y) * (180f / (float)Math.PI);
            if (angleCounterClockwise < 0)
            {
                angleCounterClockwise += 360f;
            }

        }
        public void GetCountClockwiseAngle(WowCoord target, out float angle) {

            GetCountClockwiseAngle(this, target, out angle);
        }


        public void GetVector2D(out float x, out float y)
        {
            x = X;
            y = Y;
        }
        public void GetVector2D(out Vector2 vector)
        {
            vector = new Vector2(X, Y);
        }


        public static float GetDistanceBetween(WowCoord origin, WowCoord target)
        {
            float x = target.X - origin.X;
            float y = target.Y - origin.Y;
            return (float)Math.Sqrt((x * x) + (y * y));
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

        public override string ToString()
        {
            string justForDemo =this.X + ","+this.Y + ","+this.Angle;
            return $"[{this.X},{this.Y},{this.Angle}]";
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