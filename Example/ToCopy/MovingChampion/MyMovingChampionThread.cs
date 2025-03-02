using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientQA.Example.ToCopy.MovingChampion
{

    public class MyMovingChampionThread : I_MoveChampion
    {
        public float m_timeBetweenKey = 10;
        public ChampionThread m_champion;
        public void WaitSeconds(float timeToWait)
        {
            // YOUR CODE
        }

        public void WaitMilliseconds(int timeToWait)
        {
            // YOUR CODE
        }
        public void PressKey(int key)
        {
            // YOUR CODE
            //m_champion.PressKey(key);
        }
        public void ReleaseKey(int key)
        {
            // YOUR CODE
        }
        public void TapKey(int key)
        {
            // YOUR CODE
        }
        public void RotateLeftRight(float angle)
        {

            if (angle < m_timeBetweenKey)
            {
                // YOUR CODE
            }
            else if (angle == m_timeBetweenKey)
            {
                // YOUR CODE
            }
            else
            {
                // YOUR CODE
            }
        }

        public void MoveDistance(float distance)
        {
            if (distance < m_timeBetweenKey)
            {
                // YOUR CODE
            }
            else if (distance == m_timeBetweenKey)
            {
                // YOUR CODE
            }
            else
            {
                // YOUR CODE
            }
        }
        public void StrafeDistance(float distance)
        {
            if (distance < m_timeBetweenKey)
            {
                // YOUR CODE
            }
            else if (distance == m_timeBetweenKey)
            {
                // YOUR CODE
            }
            else
            {
                // YOUR CODE
            }
        }
    }
}
