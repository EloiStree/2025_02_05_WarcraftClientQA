namespace XboxClientQA.Example.ToCopy.MovingChampion
{
    public interface I_MoveChampion
    {
        public void PressKey(int key);
        public void ReleaseKey(int key);
        public void TapKey(int key);
        public void RotateLeftRight(float angle);
        public void MoveDistance(float distance);
        public void StrafeDistance(float distance);
        public void WaitSeconds(float timeToWait);
        public void WaitMilliseconds(int timeToWait);
    }
}
