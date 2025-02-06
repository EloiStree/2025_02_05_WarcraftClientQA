





public class ChampionMoveAndRotate {
    public static float m_speedHorizontalPerSecond = 7;
    public static float m_speedVerticalForwardPerSecond = 7;
    public static float m_speedVerticalBackwarPerSecond = 4;
    public static float m_rotationAngleSpeedPerSecond = 180;//360;

    public static void MoveForward(float distance, out float walkDelayInSeconds)
    {
        walkDelayInSeconds = distance / m_speedVerticalForwardPerSecond;
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

    public static void MoveForward(Champion champion, float distance)
    {
        MoveForward(distance, out float walkDelayInSeconds);
        champion.StartForward();
        champion.WaitSomeSeconds(walkDelayInSeconds);
        champion.StopMovingForward();

    }

    public static void MoveBackward(Champion champion, float distance)
    {
        MoveBackward(distance, out float walkDelayInSeconds);
        champion.StartMovingBackward();
        champion.WaitSomeSeconds(walkDelayInSeconds);
        champion.StopMovingBackward();
    }
    public static void MoveLeft(Champion champion, float distance)
    {
        MoveHorizontal(distance, out float walkDelayInSeconds);
        champion.StartMovingLeft();
        champion.WaitSomeSeconds(walkDelayInSeconds);
        champion.StopMovingLeft();
    }
    public static void MoveRight(Champion champion, float distance)
    {
        MoveHorizontal(distance, out float walkDelayInSeconds);
        champion.StartMovingRight();
        champion.WaitSomeSeconds(walkDelayInSeconds);
        champion.StopMovingRight();
    }
    public static void Rotate(Champion champion, float angle)
    {
        Rotate(angle, out float rotateDelayInSeconds);
        champion.StartRotateLeft();
        champion.WaitSomeSeconds(rotateDelayInSeconds);
        champion.StopRotateLeft();
    }


    public static void TestMovingInSquare(Champion champion, float distanceEdge)
    {
        for (int i = 0; i < 4; i++)
        {
            ChampionMoveAndRotate.Rotate(champion, 90);
            Thread.Sleep(1000);
            ChampionMoveAndRotate.MoveForward(champion, distanceEdge);
            Thread.Sleep(1000);
        }

    }


    public static void TestRotation90And360(Champion champion) {

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
