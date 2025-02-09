

/// <summary>
/// This class give tool to compute angle rotation and distance move.
/// </summary>
public class ChampionMoveAndRotate {
    public static float m_speedHorizontalPerSecond = 7;
    public static float m_speedVerticalForwardPerSecond = 7;
    public static float m_speedVerticalBackwarPerSecond = 4;
    public static float m_rotationAngleSpeedPerSecond = 180;//360;

    public static void MoveForward(float distance, out float walkDelayInSeconds)
    {
        walkDelayInSeconds = distance / m_speedVerticalForwardPerSecond;
    }
    public static void Move(float distance, float speed, out float walkDelayInSeconds)
    {
        walkDelayInSeconds = distance / speed;
    }
    public static void MoveBackward(float distance, out float walkDelayInSeconds)
    {
        walkDelayInSeconds = distance / m_speedVerticalBackwarPerSecond;
    }
    public static void MoveHorizontal(float distance, out float walkDelayInSeconds)
    {
        walkDelayInSeconds = distance / m_speedHorizontalPerSecond;
    }
    public static void Rotate(float angle, out float rotateDelayInSeconds)
    {
        rotateDelayInSeconds = angle / m_rotationAngleSpeedPerSecond;
    }
    public static void Rotate(float angle, float angleSpeed, out float rotateDelayInSeconds)
    {
        rotateDelayInSeconds = angle / angleSpeed;
    }

    public static void MoveForward(ChampionThread champion, float distance)
    {
        MoveForward(distance, out float walkDelayInSeconds);
        champion.StartMovingForward();
        champion.WaitSomeSeconds(walkDelayInSeconds);
        champion.StopMovingForward();

    }

    public static void MoveBackward(ChampionThread champion, float distance)
    {
        MoveBackward(distance, out float walkDelayInSeconds);
        champion.StartMovingBackward();
        champion.WaitSomeSeconds(walkDelayInSeconds);
        champion.StopMovingBackward();
    }
    public static void MoveLeft(ChampionThread champion, float distance)
    {
        MoveHorizontal(distance, out float walkDelayInSeconds);
        champion.StartStrafeLeft();
        champion.WaitSomeSeconds(walkDelayInSeconds);
        champion.StopStrafeLeft();
    }
    public static void MoveRight(ChampionThread champion, float distance)
    {
        MoveHorizontal(distance, out float walkDelayInSeconds);
        champion.StartStrafeRight();
        champion.WaitSomeSeconds(walkDelayInSeconds);
        champion.StopStrafeRight();
    }
    public static void Rotate(ChampionThread champion, float angle)
    {
        Rotate(angle, out float rotateDelayInSeconds);
        float absRotate = Math.Abs(rotateDelayInSeconds);
        if (angle > 0)
        {
            champion.StartRotateRight();
            champion.WaitSomeSeconds(absRotate);
            champion.StopRotateRight();
        }
        else if (angle == 0)
        {
            // do nothing
        }
        else
        {
            champion.StartRotateLeft();
            champion.WaitSomeSeconds(absRotate);
            champion.StopRotateLeft();
        }
    }


    public static void TestMovingInSquare(ChampionThread champion, float distanceEdge)
    {
        for (int i = 0; i < 4; i++)
        {
            ChampionMoveAndRotate.Rotate(champion, 90);
            Thread.Sleep(1000);
            ChampionMoveAndRotate.MoveForward(champion, distanceEdge);
            Thread.Sleep(1000);
        }

    }


    public static void TestRotation90And360(ChampionThread champion) {

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Turn " + i);
            Thread.Sleep(2000);
            ChampionMoveAndRotate.Rotate(champion, 90);
        }

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Turn " + i);
            Thread.Sleep(2000);
            ChampionMoveAndRotate.Rotate(champion, 360);
        }

    }

}
