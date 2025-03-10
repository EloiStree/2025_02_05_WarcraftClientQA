using ClientQA.UtilityCode;
using ClientQA.LearningExample.Basic;

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
            //NOT TESTED
            ComputeDistance(from, to, out distance);
            ComputeWowAngleFrom(from, to, out float worldAngle);
            WowSetToDirectionAngle.ComputeDirectionFromTo(
           playerAngle, worldAngle,
           out bool isRight, out angleToRotate);
            direction = isRight ? RotationDirection.Right : RotationDirection.Left;
        }

        public static void ComputeWowAngleFrom(in WowWorldPosition from, in WowWorldPosition to, out float angleDestination)
        {
            angleDestination = 0;
            // On repositionne le vecteur par rapport à l'origine du plan cartésien
            double x = to.m_xRightToleft - from.m_xRightToleft;
            double y = to.m_yDownToUp - from.m_yDownToUp;

            // L'axe X dans World of Warcraft va de gauche à droite,
            // tandis qu'en mathématiques il est orienté de droite à gauche.
            // On applique donc une symétrie sur l'axe X.
            x = -x;

            if (y < 0 && x > 0)
            {
                // Cas où l'on est en bas à droite dans le plan cartésien mathématique
                // On applique une symétrie sur l'axe Y pour ramener le point dans la partie supérieure du plan
                y = -y;

                // Calcul de l'angle en radians à l'aide de la fonction atan2 (opposé / adjacent)
                double inRadiansAngle = Math.Atan2(y, x);

                // Conversion de l'angle en degrés
                double inDegree = (180.0 / Math.PI) * inRadiansAngle;

                // Ajustement de l'angle pour respecter l'orientation counter-clockwise de WoW
                double inWowDegree = 270 - inDegree;

                angleDestination = (float)inWowDegree;
            }
            else if (y < 0 && x < 0)
            {
                // Cas où l'on est en bas à gauche dans le plan cartésien mathématique
                // Symétrie sur l'axe Y pour ramener dans la partie supérieure du plan
                y = -y;
                // Symétrie sur l'axe X pour ramener dans la partie droite du plan
                x = -x;

                double inRadiansAngle = Math.Atan2(y, x);
                double inDegree = (180.0 / Math.PI) * inRadiansAngle;

                // Ajout de 90° pour respecter l'orientation counter-clockwise de WoW
                double inWowDegree = 90 + inDegree;

                angleDestination = (float)inWowDegree;
            }
            else if (y > 0 && x > 0)
            {
                // Cas où l'on est déjà dans la partie correcte du plan

                double inRadiansAngle = Math.Atan2(y, x);
                double inDegree = (180.0 / Math.PI) * inRadiansAngle;

                // Ajout de 270° pour s'aligner avec l'orientation counter-clockwise de WoW
                double inWowDegree = 270 + inDegree;

                angleDestination = (float)inWowDegree;
            }
            else if (y > 0 && x < 0)
            {
                // Cas où l'on est en haut à gauche dans le plan cartésien mathématique
                // Symétrie sur l'axe X pour ramener dans la partie droite du plan
                x = -x;

                double inRadiansAngle = Math.Atan2(y, x);
                double inDegree = (180.0 / Math.PI) * inRadiansAngle;

                // Soustraction de 90° pour respecter l'orientation counter-clockwise de WoW
                double inWowDegree = 90 - inDegree;

                angleDestination = (float)inWowDegree;
            }
        }
    }
}