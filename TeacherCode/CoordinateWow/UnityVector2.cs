// To learn Reserver Keywords in C#
// https://github.com/EloiStree/HelloSharpForUnity3D/issues/354

// To learn Char in QWERTY keyboard and UTF8
// https://github.com/EloiStree/HelloSharpForUnity3D/issues/557


// Keyword: identation https://github.com/EloiStree/HelloSharpForUnity3D/issues/411

// Keyword: using https://github.com/EloiStree/HelloSharpForUnity3D/issues/281
// Keyword: System  https://github.com/EloiStree/HelloSharpForUnity3D/issues/545
using System;
using System.Collections;


// Keyword: Generic https://github.com/EloiStree/HelloSharpForUnity3D/issues/84
using System.Collections.Generic;

// Keyword: Linq https://github.com/EloiStree/HelloSharpForUnity3D/issues/223
using System.Linq; 
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ClientQA.TeacherCode;

// Keyword: namespace https://github.com/EloiStree/HelloSharpForUnity3D/issues/90
namespace Eloi.Toolbox
{
    // Keyword: NotImplementedException 
    // Keyword: Exception 
    public class LearningException : System.NotImplementedException
    {


        // Keyword: @ https://github.com/EloiStree/HelloSharpForUnity3D/issues/405
        // Keyword: $ https://github.com/EloiStree/HelloSharpForUnity3D/issues/522
        // Keyword: $@ https://github.com/EloiStree/HelloSharpForUnity3D/issues/556
        public LearningException(string whatToCode, string urlToLearn) : base($@"
        You did not code it yets ;).
What to code : {whatToCode}
Learn what to code: {urlToLearn}
        ")
        {
        }
    }


    public class HowToUseUnityVector2 {

        public static void Test(ChampionThread champion) {


            #region SANS CONSTRUCTEUR
            UnityVector2 directionJoueur = new UnityVector2();
            directionJoueur.X = 20;
            directionJoueur.Y = 2;



            UnityVector2 directionJoueurEnSeconds = new UnityVector2();
            directionJoueurEnSeconds.X =
                directionJoueur.X / 7f;
            directionJoueurEnSeconds.Y =
                directionJoueur.Y / 7f;


            MoveChampionTools.TranslateInSeconds(champion,
                directionJoueurEnSeconds);

            #endregion

            #region AVEC CONSTRUCTEUR
            MoveChampionTools.TranslateInSeconds(champion,
                new UnityVector2(10, 0));

            #endregion


        }
    }


    /// <summary>
    /// Represent a 2D Vector like in Unity#D
    /// </summary>
    public class UnityVector2
    {
        // Keyword : class https://github.com/EloiStree/HelloSharpForUnity3D/issues/34
        // Keyword: Diagram Class UML https://github.com/EloiStree/HelloSharpForUnity3D/issues/435


        #region CLASS MEMBER
        // Keyword: Class Member https://github.com/EloiStree/HelloSharpForUnity3D/issues/258

        /// <summary>
        /// Represent in general left to right
        /// </summary>
        private float m_x;

        /// <summary>
        /// Represent in general up or forward
        /// </summary>
        private float m_y;
        #endregion



        // Keyword: property https://github.com/EloiStree/HelloSharpForUnity3D/issues/56
        #region GETTER SETTER A LA C#

        public float X
        {
            //Keyword: get  https://github.com/EloiStree/HelloSharpForUnity3D/issues/300
            get { return m_x; }

            //Keyword: set https://github.com/EloiStree/HelloSharpForUnity3D/issues/301
            set { m_x = value; }
        }

        public float Y
        {
            get { return m_y; }
            set { m_y = value; }
        }
        #endregion

        #region GETTER SETTER A LA Java
        public float GetX()
        {
            return m_x;
        }
        public void SetX(float x)
        {
            m_x = x;
        }
        public float GetY()
        {
            return m_y;
        }
        public void SetY(float y)
        {
            m_y = y;
        }

        public void SetXY(float x, float y)
        {
            m_x = x;
            m_y = y;
        }
        public void SetXY(UnityVector2 vector)
        {
            m_x = vector.m_x;
            m_y = vector.m_y;
        }
        public void GetCopyXY(out float x, out float y)
        {
            x = m_x;
            y = m_y;
        }

        //For the fun
        // Keyword: ref https://github.com/EloiStree/HelloSharpForUnity3D/issues/211
        public void GetCopyInXY(ref float x, ref float y)
        {
            x = m_x;
            y = m_y;
        }
        public void GetCopy(out UnityVector2 vector)
        {
            vector = new UnityVector2(m_x, m_y);
        }
        public UnityVector2 GetCopy()
        {
            return new UnityVector2(m_x, m_y);
        }

        // TopicL Is On Get Set https://github.com/EloiStree/HelloSharpForUnity3D/issues/564

        public void IsEqualsZero(out bool isEqualsZero)
        {
            isEqualsZero = m_x == 0 && m_y == 0;
        }
        public bool IsMagnitudeBiggerThat(float magnitudeDistance)
        {
            return GetDistance() >magnitudeDistance;
        }
        public bool IsEqualsZero()
        {
            return m_x == 0 && m_y == 0;
        }
        #endregion


        #region CONSTRUCTEUR
        public UnityVector2()
        {
            m_x = 0;
            m_y = 0;

        }

        public UnityVector2(float x, float y)
        {
            m_x = x;
            m_y = y;
        }
        public UnityVector2(string x, string y)
        {
            float.TryParse(x, out m_x);
            float.TryParse(y, out m_y);

        }

        #endregion


        #region TOOL IN UNITY3D
        public void Normalized()
        {
            // Keyword: Normalized Vector https://github.com/EloiStree/HelloSharpForUnity3D/issues/558
            //https://youtu.be/u70ZpQH1muc?t=4
            float magnitude = (float)Math.Sqrt(m_x * m_x + m_y * m_y);
            if (magnitude > 0)
            {
                m_x /= magnitude;
                m_y /= magnitude;
            }
        }
        public void Normalize(out UnityVector2 normalizedCopy)
        {
            // Keyword: Normalized Vector https://github.com/EloiStree/HelloSharpForUnity3D/issues/558
            float magnitude = (float)Math.Sqrt(m_x * m_x + m_y * m_y);
            if (magnitude > 0)
            {
                normalizedCopy = new UnityVector2(m_x / magnitude, m_y / magnitude);
            }
            else
            {
                normalizedCopy = new UnityVector2(0, 0);
            }
        }

        // Keyword: return https://github.com/EloiStree/HelloSharpForUnity3D/issues/379
        // Keyword: void https://github.com/EloiStree/HelloSharpForUnity3D/issues/392
        public float GetDistance()
        {
            GetDistance(out float distance);
            return distance;
        }


        // Keyword: out https://github.com/EloiStree/HelloSharpForUnity3D/issues/213
        public void GetDistance(out float distance)
        {

            // Keyword: distance https://github.com/EloiStree/HelloSharpForUnity3D/issues/559
            distance = (float)Math.Sqrt((m_x * m_x )+ (m_y * m_y));
        }
        #endregion


        // Keyword: readonly https://github.com/EloiStree/HelloSharpForUnity3D/issues/86
        public static readonly UnityVector2 RIGHT = new UnityVector2(1, 0);
        public static readonly UnityVector2 LEFT = new UnityVector2(-1, 0);
        public static readonly UnityVector2 UP = new UnityVector2(0, 1);
        public static readonly UnityVector2 DOWN = new UnityVector2(0, -1);
        public static readonly UnityVector2 FORWARD = new UnityVector2(0, 1);
        public static readonly UnityVector2 BACKWARD = new UnityVector2(0, -1);


        #region CONST VARIABLE

        // Keyword: const https://github.com/EloiStree/HelloSharpForUnity3D/issues/85

        public const float PI = 3.14159265358979323846f;
        public const int ENGINER_PI = 3; // JOKE
        // Keyword: Radian https://github.com/EloiStree/HelloSharpForUnity3D/issues/565
        public const float DEG_TO_RAD = PI / 180f; // Conversion factor from degrees to radians
        public const float RAD_TO_DEG = 180f / PI; // Conversion factor from radians to degrees
        public const float FULL_CIRCLE_DEGREES = 360f; // Full circle in degrees
        public const float HALF_CIRCLE_DEGREES = 180f; // Half circle in degrees
        public const float QUARTER_CIRCLE_DEGREES = 90f; // Quarter circle in degrees
        public const float LIFE = 42;
        public const int GITS = 2501;


        #endregion



        #region STATIC METHOD TOOL


        public static void GetDirectionOfTwoPoints(in UnityVector2 origine, in UnityVector2 destionation, out UnityVector2 direction)
        {
            direction = new UnityVector2(destionation.X - origine.X, destionation.Y - origine.Y);
        }

        public static void GetAngleBetweenThreePoints(
            in UnityVector2 from, in UnityVector2 center, in UnityVector2 to, out float angle)
             {
            UnityVector2 directonA = from-center;
            UnityVector2 directonB = to-center;
            GetAngle(directonA, directonB, out angle);

        }



        public static float GetDistance(in  UnityVector2 a, in UnityVector2 b)
        {
            return (float)Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
        }

        public static float GetAngle(in UnityVector2 a, in UnityVector2 b)
        {
            return (float)Math.Atan2(b.Y - a.Y, b.X - a.X);
        }


        // Keyword: in https://github.com/EloiStree/HelloSharpForUnity3D/issues/212
        // Keyword: out https://github.com/EloiStree/HelloSharpForUnity3D/issues/213
        public static void GetDistance(in UnityVector2 a, in UnityVector2 b, out float distance)
        {
            distance = (float)Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
        }

        public static void GetAngle(in UnityVector2 a, in UnityVector2 b, out float angle)
        {
            angle = (float)Math.Atan2(b.Y - a.Y, b.X - a.X);
        }

        #endregion


        #region NETHODE AND OPERATOR OVERLOADING
        // Keyword: Overloading https://github.com/EloiStree/HelloSharpForUnity3D/issues/257

        // Keyword: Method Overloading https://github.com/EloiStree/HelloSharpForUnity3D/issues/257
        public void SetX(string x) { float.TryParse(x, out m_x); }
        public void SetY(string y) { float.TryParse(y, out m_y); }

        public void SetX(int x) { m_x = x; }
        public void SetY(int y) { m_y = y; }
        public void SetXY(int x, int y)
        {
            m_x = x;
            m_y = y;
        }
        public void SetXY(string x, string y)
        {
            float.TryParse(x, out m_x);
            float.TryParse(y, out m_y);
        }


        // Keyword: operator overloading https://github.com/EloiStree/HelloSharpForUnity3D/issues/257
        public static UnityVector2 operator +(UnityVector2 a, UnityVector2 b)
        {
            return new UnityVector2(a.X + b.X, a.Y + b.Y);
        }
        public static UnityVector2 operator -(UnityVector2 a, UnityVector2 b)
        {
            return new UnityVector2(a.X - b.X, a.Y - b.Y);
        }
        public static UnityVector2 operator *(UnityVector2 a, float b)
        {
            return new UnityVector2(a.X * b, a.Y * b);
        }
        public static UnityVector2 operator /(UnityVector2 a, float b)
        {
            return new UnityVector2(a.X / b, a.Y / b);
        }
        public static UnityVector2 operator *(float a, UnityVector2 b)
        {
            return new UnityVector2(a * b.X, a * b.Y);
        }
        public static UnityVector2 operator /(float a, UnityVector2 b)
        {
            return new UnityVector2(a / b.X, a / b.Y);
        }
        public static UnityVector2 operator *(UnityVector2 a, UnityVector2 b)
        {
            return new UnityVector2(a.X * b.X, a.Y * b.Y);
        }
        public static UnityVector2 operator /(UnityVector2 a, UnityVector2 b)
        {
            return new UnityVector2(a.X / b.X, a.Y / b.Y);
        }
        public static UnityVector2 operator -(UnityVector2 a)
        {
            return new UnityVector2(-a.X, -a.Y);
        }
        public static UnityVector2 operator +(UnityVector2 a)
        {
            return new UnityVector2(+a.X, +a.Y);
        }


        public static bool operator ==(UnityVector2 a, UnityVector2 b)
        {
            return a.X == b.X && a.Y == b.Y;
        }
        public static bool operator !=(UnityVector2 a, UnityVector2 b)
        {
            return !(a == b);
        }
        /// <summary>
        /// Retrieves the X and Y coordinates of the vector as a tuple.
        /// </summary>
        /// <returns>A tuple containing the X and Y coordinates of the vector.</returns>
        public (float X, float Y) GetXY()
        {
            return (m_x, m_y);
        }
        #endregion

        #region PARAMS LIST and ARRAY


        // Keyword: params https://github.com/EloiStree/HelloSharpForUnity3D/issues/68
        // Keyword: array https://github.com/EloiStree/HelloSharpForUnity3D/issues/28
        public void Add(params UnityVector2[] values)
        {
            foreach (var value in values)
            {
                m_x += value.X;
                m_y += value.Y;
            }
        }
        // Keyword: IEnumerable https://github.com/EloiStree/HelloSharpForUnity3D/issues/88
        public void Add(IEnumerable<UnityVector2> values)
        {
            foreach (var value in values)
            {
                m_x += value.X;
                m_y += value.Y;
            }
        }

        // Keyword: List https://github.com/EloiStree/HelloSharpForUnity3D/issues/304

        public void Add(List<UnityVector2> values)
        {
            foreach (var value in values)
            {
                m_x += value.X;
                m_y += value.Y;
            }
        }

        #endregion


        // Keyword: ToString https://github.com/EloiStree/HelloSharpForUnity3D/issues/441
        public override string ToString()
        {
            return $"X:{m_x} Y:{m_y}";
        }

        #region ENUM EXAMPLE

        // Keyword: enum https://github.com/EloiStree/HelloSharpForUnity3D/issues/55 
        public enum DirectionArrow
        {
            UP,
            DOWN,
            LEFT,
            RIGHT
        }
        public enum DirectionHat
        {
            UP,
            DOWN,
            LEFT,
            RIGHT,
            UP_LEFT,
            UP_RIGHT,
            DOWN_LEFT,
            DOWN_RIGHT
        }
        public enum DirectionCompass
        {
            NORTH,
            SOUTH,
            EAST,
            WEST,
            NORTH_EAST,
            NORTH_WEST,
            SOUTH_EAST,
            SOUTH_WEST
        }

        public void SetDirectionEnum(DirectionArrow direction, float distanceMultiplicator=1f)
        {
            switch (direction)
            {
                case DirectionArrow.UP:
                    m_y = 1 * distanceMultiplicator;
                    break;
                case DirectionArrow.DOWN:
                    m_y = -1 * distanceMultiplicator;
                    break;
                case DirectionArrow.LEFT:
                    m_x = -1 * distanceMultiplicator;
                    break;
                case DirectionArrow.RIGHT:
                    m_x = 1 * distanceMultiplicator;
                    break;
            }
        }

        public void SetDirectionEnum(DirectionHat direction, float distanceMultiplicator = 1f)
        {
            switch (direction)
            {
                case DirectionHat.UP:
                    m_y = 1 * distanceMultiplicator;
                    break;
                case DirectionHat.DOWN:
                    m_y = -1 * distanceMultiplicator;
                    break;
                case DirectionHat.LEFT:
                    m_x = -1 * distanceMultiplicator;
                    break;
                case DirectionHat.RIGHT:
                    m_x = 1 * distanceMultiplicator;
                    break;
                case DirectionHat.UP_LEFT:
                    m_x = -1 * distanceMultiplicator;
                    m_y = 1 * distanceMultiplicator;
                    break;
                case DirectionHat.UP_RIGHT:
                    m_x = 1 * distanceMultiplicator;
                    m_y = 1 * distanceMultiplicator;
                    break;
                case DirectionHat.DOWN_LEFT:
                    m_x = -1 * distanceMultiplicator;
                    m_y = -1 * distanceMultiplicator;
                    break;
                case DirectionHat.DOWN_RIGHT:
                    m_x = 1 * distanceMultiplicator;
                    m_y = -1 * distanceMultiplicator;
                    break;
            }
        }

        public void SetDirectionEnum(DirectionCompass direction, float distanceMultiplicator = 1f)
        {
            switch (direction)
            {
                case DirectionCompass.NORTH:
                    m_y = 1 * distanceMultiplicator;
                    break;
                case DirectionCompass.SOUTH:
                    m_y = -1 * distanceMultiplicator;
                    break;
                case DirectionCompass.EAST:
                    m_x = 1 * distanceMultiplicator;
                    break;
                case DirectionCompass.WEST:
                    m_x = -1 * distanceMultiplicator;
                    break;
                case DirectionCompass.NORTH_EAST:
                    m_x = 1 * distanceMultiplicator;
                    m_y = 1 * distanceMultiplicator;
                    break;
                case DirectionCompass.NORTH_WEST:
                    m_x = -1 * distanceMultiplicator;
                    m_y = 1 * distanceMultiplicator;
                    break;
                case DirectionCompass.SOUTH_EAST:
                    m_x = 1 * distanceMultiplicator;
                    m_y = -1 * distanceMultiplicator;
                    break;
                case DirectionCompass.SOUTH_WEST:
                    m_x = -1 * distanceMultiplicator;
                    m_y = -1 * distanceMultiplicator;
                    break;
            }
        }

        // Keyword: Equals https://github.com/EloiStree/HelloSharpForUnity3D/issues/562
        public override bool Equals(object? obj)
        {
            return obj is UnityVector2 vector &&
                   m_x == vector.m_x &&
                   m_y == vector.m_y &&
                   X == vector.X &&
                   Y == vector.Y;
        }


        // Keyword: GetHashCode https://github.com/EloiStree/HelloSharpForUnity3D/issues/563
        public override int GetHashCode()
        {
            return HashCode.Combine(m_x, m_y, X, Y);
        }



        #endregion

    }

    /// <summary>
    ///  FlySteady 21 per seconds left forward right
    ///  FlyStedy 4 per seconds backward
    ///  
    /// </summary>
    // Keyword: static class https://github.com/EloiStree/HelloSharpForUnity3D/issues/39

    public static class MoveChampionTools {



        public static void TranslateOfDistanceWalkSequence(ChampionThread champions, params UnityVector2[] directions)
        {
            foreach (var direction in directions)
            {
                TranslateOfDistanceWalk(champions, direction);
            }
        }
        public static void TranslateOfDistanceSteadyFlySequence(ChampionThread champions, params UnityVector2[] directions)
        {
            foreach (var direction in directions)
            {
                TranslateOfDistanceSteadyFly(champions, direction);
            }
        }

        public static void TranslateOfDistanceWalk(ChampionThread champion, UnityVector2 direction)
        {

            champion.GetWalkSpeedByDefault(out float leftFrontRightSpeed, out float backwardSpeed);
            TranslateInDistance(champion, direction, leftFrontRightSpeed, backwardSpeed);
        }

        public static void TranslateOfDistanceSteadyFly(ChampionThread champion, UnityVector2 direction)
        {

            champion.GetSteadyFlySpeedByDefault(out float leftFrontRightSpeed, out float backwardSpeed);
            TranslateInDistance(champion, direction, leftFrontRightSpeed, backwardSpeed);
        }




        public static void TranslateInDistance(ChampionThread champion,
            UnityVector2 directionInDistance, float leftFrontRightSpeed, float backwardSpeed)
        {
            UnityVector2 distancsInSeconds = new UnityVector2();
            if (directionInDistance.X > 0)
            {
                distancsInSeconds.X = directionInDistance.X / leftFrontRightSpeed;
            }
            else if (directionInDistance.X < 0)
            {
                distancsInSeconds.X = directionInDistance.X / leftFrontRightSpeed;
            }
            if (directionInDistance.Y > 0)
            {
                distancsInSeconds.Y = directionInDistance.Y / leftFrontRightSpeed;
            }
            else if (directionInDistance.Y < 0)
            {
                distancsInSeconds.Y = directionInDistance.Y / backwardSpeed;
            }

            TranslateInSeconds(champion, distancsInSeconds);

        }

        public static void TranslateInSeconds(
            ChampionThread champion,
            UnityVector2 directionEnSeconds
            )
        {
            bool isGoingRight = directionEnSeconds.X > 0;
            bool isGoingLeft = directionEnSeconds.X < 0;
            bool isGoingForward = directionEnSeconds.Y > 0;
            bool isGoingBackward = directionEnSeconds.Y < 0;
            float absX = Math.Abs(directionEnSeconds.X);
            float absY = Math.Abs(directionEnSeconds.Y);

            bool useExperimental = false;
            if (useExperimental)
            {
                // There is bug in this code  so i switch to old code

                if (isGoingRight)
                {
                    champion.StartStrafeRight();
                }
                 if (isGoingLeft)
                {
                    champion.StartStrafeLeft();
                }
                if (isGoingForward)
                {
                    champion.StartMovingForward();
                }
                 if (isGoingBackward)
                {
                    champion.StartMovingBackward();
                }


                // Check if x is less that y
                if (absX < absY) {


                    float firstWait = absX;
                    float secondWait = absY - absX;

                    champion.WaitSomeSeconds(firstWait);
                    if (isGoingRight)
                    {
                        champion.StopStrafeRight();
                    }
                    else if (isGoingLeft)
                    {
                        champion.StopStrafeLeft();
                    }

                    champion.WaitSomeSeconds(secondWait);
                    if (isGoingForward)
                    {
                        champion.StopMovingForward();
                    }
                    else if (isGoingBackward)
                    {
                        champion.StopMovingBackward();
                    }

                }
                else if (absY < absX)
                {
                    float firstWait = absY;
                    float secondWait = absX - absY;
                    champion.WaitSomeSeconds(firstWait);
                    if (isGoingForward)
                    {
                        champion.StopMovingForward();
                    }
                     if (isGoingBackward)
                    {
                        champion.StopMovingBackward();
                    }
                    champion.WaitSomeSeconds(secondWait);
                    if (isGoingRight)
                    {
                        champion.StopStrafeRight();
                    }
                     if (isGoingLeft)
                    {
                        champion.StopStrafeLeft();
                    }
                }

            }
            else {

                // Dumb easy code
                if (directionEnSeconds.X < 0)
                {
                    champion.StartStrafeLeftFor(Math.Abs(directionEnSeconds.X));
                }
                else if (directionEnSeconds.X > 0)
                {
                    champion.StartStrafeRightFor(Math.Abs(directionEnSeconds.X));
                }
                if (directionEnSeconds.Y < 0)
                {
                    champion.StartMovingBackwardFor(Math.Abs(directionEnSeconds.Y));
                }
                else if (directionEnSeconds.Y > 0)
                {
                    champion.StartMovingForwardFor(Math.Abs(directionEnSeconds.Y));
                }
            }


        }

    }

}
