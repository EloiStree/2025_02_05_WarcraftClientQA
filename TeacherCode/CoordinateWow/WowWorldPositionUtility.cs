using ClientQA.UtilityCode;
using XboxClientQA.LearningExample.Basic;

namespace ClientQA.TeacherCode.CoordinateWow
{
    public static class WowWorldPositionUtility
    {

        public static void ComputeDistance(
    WowWorldPosition origin,
    WowWorldPosition destination,
    out double distanceInworldPosition)
        {
            double x = Math.Abs(destination.m_xRightToleft - origin.m_xRightToleft);
            double y = Math.Abs(destination.m_yDownToUp - origin.m_yDownToUp);
             distanceInworldPosition = Math.Sqrt(x * x + y * y);
        }



        public static void ComputeWowDirectionFromTo(
            in float playerAngle,
            in WowWorldPosition from,
            in WowWorldPosition to,
            out RotationDirection direction,
            out float angleToRotate,
            out double distance)

        {
            // Not tested
            ComputeDistance(from, to, out distance);
            ComputeWowAngleFrom(from, to, out float worldAngle);
            WowSetToDirectionAngle.GetRotationFromTo(
           playerAngle, worldAngle,
           out bool goLeft, out angleToRotate);
            direction = goLeft ? RotationDirection.Left : RotationDirection.Right;
        }

        public static void ComputeWowAngleFrom(in WowWorldPosition from, in WowWorldPosition to, out float angleDestination)
        {
            //CREDIT: THOMAS TOUSSAIN

            angleDestination = 0;
            //On replace le vecteur au centre du plan cartésien
            double distanceX = to.m_xRightToleft - from.m_xRightToleft;
            double distanceY = to.m_yDownToUp - from.m_yDownToUp;
            // Cela ressemble à ça.
            Console.WriteLine($" World Coordonate: x{distanceX} y {distanceY}");

            // Comme l'axis X va de gauche à droite
            // Contre de droite à gauche en math
            // Inversons le X
            distanceX = -distanceX;
            Console.WriteLine($"World X Mirror: x{distanceX} y {distanceY}");


            if (distanceY < 0 && distanceX > 0)
            {// Si l'on est en bas à droite dans le plan cartésien.

                // On doit inverser le Y poru le ramener sur la zone XY 
                distanceY = -distanceY;
                // Calculons l'angle
                double inRadiansAngle = Math.Atan2(distanceY, distanceX);
                //Transformons le en degree
                double inDegree = (180.0 / Math.PI) * inRadiansAngle;

                Console.WriteLine("Rad: " + inRadiansAngle);
                Console.WriteLine("Degree: " + inDegree);
                // Convertison l'angle sur une rotation propore à world of warcraft.
                double inWowDegree = 270 - inDegree;
                Console.WriteLine("Degree in Wow: " + inWowDegree);

                angleDestination = (float)inWowDegree;
            }
            else if (distanceY < 0 && distanceX < 0)
            {
                // On tourne l'angle vers le dessus
                distanceY = -distanceY;
                // On mirroit l'angle vers la droite
                distanceX = -distanceX;

                double inRadiansAngle = Math.Atan2(distanceY, distanceX);
                double inDegree = (180.0 / Math.PI) * inRadiansAngle;
                Console.WriteLine("Rad: " + inRadiansAngle);
                Console.WriteLine("Degree: " + inDegree);
                double inWowDegree = 90 + inDegree;
                Console.WriteLine("Degree in Wow: " + inWowDegree);
                angleDestination = (float)inWowDegree;
            }
            else if (distanceY > 0 && distanceX > 0)
            {

                double inRadiansAngle = Math.Atan2(distanceY, distanceX);
                double inDegree = (180.0 / Math.PI) * inRadiansAngle;
                Console.WriteLine("Rad: " + inRadiansAngle);
                Console.WriteLine("Degree: " + inDegree);
                double inWowDegree = 270 + inDegree;
                Console.WriteLine("Degree in Wow: " + inWowDegree);
                angleDestination = (float)inWowDegree;

            }
            else if (distanceY > 0 && distanceX < 0)
            {
                distanceX = -distanceX;
                double inRadiansAngle = Math.Atan2(distanceY, distanceX);
                double inDegree = (180.0 / Math.PI) * inRadiansAngle;
                Console.WriteLine("Rad: " + inRadiansAngle);
                Console.WriteLine("Degree: " + inDegree);
                double inWowDegree = 90 - inDegree;
                Console.WriteLine("Degree in Wow: " + inWowDegree);
                angleDestination = (float)inWowDegree;
            }



        }

    }
}