using ClientQA.TeacherCode.CoordinateWow;
using ClientQA.UtilityCode;

namespace ClientQA.LearningExample.Basic
{
    public class ExerciceSolution_AskPlayerWhereToGo : I_AskPlayerWhereToGoAndMove
    {

       

        public void Run(ChampionThread champion)
        {
            SetPlayerMoveSpeed(champion.m_speedMoveForward);
            SetPlayerRotationSpeed(champion.m_rotationAngle);
            Step00_AskWithConsoleThePlayerAngle(out float playerAngle);
            Step01_AskWithConsoleOrigin(out WowWorldPosition origin);
            Step02_AskWithConsoleDestination(out WowWorldPosition destination);
            Step04_ComputeTheDistance(in origin, in destination, out double distance);
            Step05_ComputeTimeToRun(in distance, out int timeToRunInMilliseconds);
            Step06_DisplayInComingDistance(in distance);
            Step07_DisplayTimeToRunInMilliseconds(in timeToRunInMilliseconds);
            Step08_ComputeTheAngleOfDestination(in origin, in destination, out float angleDestination);
            Step09_ComputeRotationTime(in playerAngle, in angleDestination, out RotationDirection rotationDirection, out int millisecondsToRotate);
            Step10_DisplayRotationTime(in rotationDirection, in angleDestination);
            FinalStep_MoveTheChampion(champion, in rotationDirection, in millisecondsToRotate, in timeToRunInMilliseconds);
        }


        public float m_moveSpeed = 7;
        public float m_rotationSpeed = 180;
        public void SetPlayerMoveSpeed(float moveSpeed = 7)
        {
            m_moveSpeed = moveSpeed;
        }

        public void SetPlayerRotationSpeed(float rotationSpeed = 180)
        {
            m_rotationSpeed = rotationSpeed;
        }

        public void Step00_AskWithConsoleThePlayerAngle(out float playerAngle)
        {
            Console.WriteLine("Enter the player angle");
            playerAngle = float.Parse(Console.ReadLine());
        }

        public void Step01_AskWithConsoleOrigin(out WowWorldPosition origin)
        {
            Console.WriteLine("Enter the origin x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the origin y");
            double y = double.Parse(Console.ReadLine());
            origin = new WowWorldPosition(x, y);
        }

        public void Step02_AskWithConsoleDestination(out WowWorldPosition destination)
        {
            Console.WriteLine("Enter the destination x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the destination y");
            double y = double.Parse(Console.ReadLine());
            destination = new WowWorldPosition(x, y);
        }

        public void Step04_ComputeTheDistance(in WowWorldPosition origin, in WowWorldPosition destination, out double distance)
        {
            distance = Math.Sqrt(Math.Pow(destination.m_xRightToleft - origin.m_xRightToleft, 2) + Math.Pow(destination.m_yDownToUp - origin.m_yDownToUp, 2));
        }

        public void Step05_ComputeTimeToRun(in double distance, out int timeToRunInMilliseconds)
        {
            timeToRunInMilliseconds = (int)(distance / m_moveSpeed * 1000);
        }

        public void Step06_DisplayInComingDistance(in double distance)
        {
            Console.WriteLine($"Distance to run {distance}");
        }

        public void Step07_DisplayTimeToRunInMilliseconds(in int timeToRunInMilliseconds)
        {
            Console.WriteLine($"Time to run {timeToRunInMilliseconds}");
        }

        public void Step08_ComputeTheAngleOfDestination(in WowWorldPosition origin, in WowWorldPosition destination, out float angleDestination)
        {
            WowWorldPositionUtility.ComputeWowAngleFrom(origin, destination, out angleDestination);
        }

        public void Step09_ComputeRotationTime(in float angleStart, in float angleDestination, out RotationDirection rotationDirection, out int millisecondsToRotate)
        {
            WowSetToDirectionAngle.ComputeDirectionFromTo(
            angleStart, angleDestination,
            out bool isRight, out float angleToRotate);
         
            rotationDirection = isRight ? RotationDirection.Right : RotationDirection.Left;
            millisecondsToRotate = (int)(angleToRotate / m_rotationSpeed * 1000);
        }

        public void Step10_DisplayRotationTime(in RotationDirection rotationDirection, in float angleToRotate)
        {
            Console.WriteLine($"Rotation {rotationDirection} {angleToRotate}");
        }
        public void FinalStep_MoveTheChampion(in ChampionThread champion, in RotationDirection rotation, in int rotationTimeInMilliSeconds, in int moveTimeInMilliseconds)
        {
            if (rotation == RotationDirection.Left)
            {
                champion.StartRotateLeft();
                champion.WaitSomeMilliseconds(rotationTimeInMilliSeconds);
                champion.StopRotateLeft();
            }
            else
            {
                champion.StartRotateRight();
                champion.WaitSomeMilliseconds(rotationTimeInMilliSeconds);
                champion.StopRotateRight();
            }

            champion.StartMovingForward();
            champion.WaitSomeMilliseconds(moveTimeInMilliseconds);
            champion.StopMovingForward();
        }
    }
}


