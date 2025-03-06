using ClientQA.TeacherCode.CoordinateWow;

namespace XboxClientQA.LearningExample.Basic
{
    public class ExerciceToComplete_AskPlayerWhereToGo : I_AskPlayerWhereToGoAndMove
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
            Step09_ComputeRotationTime(in playerAngle, in angleDestination, out I_AskPlayerWhereToGoAndMove.RotationDirection rotationDirection, out int millisecondsToRotate);
            Step10_DisplayRotationTime(in rotationDirection, in angleDestination);
            FinalStep_MoveTheChampion(champion, in rotationDirection, in millisecondsToRotate, in timeToRunInMilliseconds);
        }

        public void SetPlayerMoveSpeed(float moveSpeed = 7)
        {
            throw new NotImplementedException();
        }

        public void SetPlayerRotationSpeed(float rotationSpeed = 180)
        {
            throw new NotImplementedException();
        }

        public void Step00_AskWithConsoleThePlayerAngle(out float playerAngle)
        {
            throw new NotImplementedException();
        }

        public void Step01_AskWithConsoleOrigin(out WowWorldPosition origin)
        {
            throw new NotImplementedException();
        }

        public void Step02_AskWithConsoleDestination(out WowWorldPosition destination)
        {
            throw new NotImplementedException();
        }

        public void Step04_ComputeTheDistance(in WowWorldPosition origin, in WowWorldPosition destination, out double distance)
        {
            throw new NotImplementedException();
        }

        public void Step05_ComputeTimeToRun(in double distance, out int timeToRunInMilliseconds)
        {
            throw new NotImplementedException();
        }

        public void Step06_DisplayInComingDistance(in double distance)
        {
            throw new NotImplementedException();
        }

        public void Step07_DisplayTimeToRunInMilliseconds(in int timeToRunInMilliseconds)
        {
            throw new NotImplementedException();
        }

        public void Step08_ComputeTheAngleOfDestination(in WowWorldPosition origin, in WowWorldPosition destination, out float angleDestination)
        {
            throw new NotImplementedException();
        }

        public void Step09_ComputeRotationTime(in float angleStart, in float angleDestination, out I_AskPlayerWhereToGoAndMove.RotationDirection rotationDirection, out int millisecondsToRotate)
        {
            throw new NotImplementedException();
        }

        public void Step10_DisplayRotationTime(in I_AskPlayerWhereToGoAndMove.RotationDirection rotationDirection, in float angleToRotate)
        {
            throw new NotImplementedException();
        }
        public void FinalStep_MoveTheChampion(in ChampionThread champion, in I_AskPlayerWhereToGoAndMove.RotationDirection rotation, in int rotationTimeInMilliSeconds, in int moveTimeInMilliseconds)
        {
            throw new NotImplementedException();
        }
    }
}
