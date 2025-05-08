// To learn Reserver Keywords in C#
// https://github.com/EloiStree/HelloSharpForUnity3D/issues/354

// To learn Char in QWERTY keyboard and UTF8
// https://github.com/EloiStree/HelloSharpForUnity3D/issues/557


// Keyword: identation https://github.com/EloiStree/HelloSharpForUnity3D/issues/411

// Keyword: using https://github.com/EloiStree/HelloSharpForUnity3D/issues/281
// Keyword: System  https://github.com/EloiStree/HelloSharpForUnity3D/issues/545


// Keyword: Generic https://github.com/EloiStree/HelloSharpForUnity3D/issues/84

// Keyword: Linq https://github.com/EloiStree/HelloSharpForUnity3D/issues/223
// Keyword: namespace https://github.com/EloiStree/HelloSharpForUnity3D/issues/90
namespace Eloi.Toolbox
{
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
