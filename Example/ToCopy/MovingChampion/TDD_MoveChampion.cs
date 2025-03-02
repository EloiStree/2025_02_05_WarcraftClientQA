namespace ClientQA.Example.ToCopy.MovingChampion
{
    public class TDD_MoveChampion
    {
        public void Fulltest(MyMovingChampionThread myChampion)
        {

            I_MoveChampion totest = myChampion;
            FullTest(totest);
        }
        public void FullTest(I_MoveChampion champion)
        {
            MoveInSquare(champion, 3);
            CheckMoveAndRotate(champion, 3, 90);
        }
        public static void MoveInSquare(I_MoveChampion move, float distance = 3)
        {
            for (int i = 0; i < 4; i++)
            {
                move.MoveDistance(distance);
                move.WaitMilliseconds(1000);
                move.RotateLeftRight(distance);
            }
        }

        public static void CheckMoveAndRotate(I_MoveChampion move, float distance = 7, float angle = 90)
        {

            move.MoveDistance(distance);
            move.WaitMilliseconds(1000);

            move.MoveDistance(-distance);
            move.WaitMilliseconds(1000);

            move.RotateLeftRight(angle);
            move.WaitMilliseconds(1000);

            move.RotateLeftRight(-angle);
            move.WaitMilliseconds(1000);


            move.StrafeDistance(distance);
            move.WaitMilliseconds(1000);

            move.StrafeDistance(-distance);
            move.WaitMilliseconds(1000);

        }
    }
}
