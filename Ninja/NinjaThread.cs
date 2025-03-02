using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientQA.Ninja
{
    public class NinjaThread
    {

        public PushIntegerToGameUDP m_sender;
        public MessageQueueDelayerTask m_messageQueue = new MessageQueueDelayerTask(true);
        public LambdaActionDictionary m_registeredAction = new LambdaActionDictionary();

        public NinjaThread(PushIntegerToGameUDP push)
        {
            m_sender = push;
        }
        public NinjaThread(string ipv4, int port, int playerIndex)
        {
            m_sender = new PushIntegerToGameUDP(ipv4, port, playerIndex);

            m_messageQueue.AddDequeueListener((string command) =>
            {
                m_registeredAction.ExecuteIfExistSimpleAction(command, out bool found);
                if (found)
                    Console.WriteLine("E:" + command);
            });
        }


        public int m_frameMilliseconds = 50;
        public void WaitFrame() => Thread.Sleep(m_frameMilliseconds);
        public void WaitOneSeconds() { Thread.Sleep(1000); }
        public void WaitTwoSeconds() { Thread.Sleep(2000); }
        public void WaitSomeSeconds(float seconds) => Thread.Sleep((int)(seconds * 1000f));
        public void PressKey(int keyCode) => m_sender.PushInteger(keyCode);
        public void ReleaseKey(int keyCode) => m_sender.PushInteger(keyCode + 1000);
        public void WaitSomeMilliseconds(int milliseconds)
        {
            Thread.Sleep(milliseconds);
        }
        public void TapKey(int keyCode)
        {
            PressKey(keyCode);
            WaitFrame();
            ReleaseKey(keyCode);
        }
        public void PressReleaseWithDelayForSeconds(int keycode, float delayBetweenInSeconds, float delayAfterInSeconds)
        {
            PressKey(keycode);
            WaitSomeSeconds(delayBetweenInSeconds);
            ReleaseKey(keycode);
            WaitSomeSeconds(delayAfterInSeconds);
        }
        public void PressReleaseWithDelayForMilliseconds(int keycode, int delayBetweenInMilliseconds, int delayAfterInMilliseconds)
        {
            PressKey(keycode);
            WaitSomeMilliseconds(delayBetweenInMilliseconds);
            ReleaseKey(keycode);
            WaitSomeMilliseconds(delayAfterInMilliseconds);
        }



        public int m_moveLeftKey = WowIntegerKeyboard.ArrowLeft;
        public int m_moveRightKey = WowIntegerKeyboard.ArrowRight;
        public int m_jumpKey = WowIntegerKeyboard.ArrowUp;
        public int m_swordKey = WowIntegerKeyboard.KeyX;
        public int m_shurikenKey = WowIntegerKeyboard.KeyZ;
        public int m_restartkey = WowIntegerKeyboard.KeyR;
        public int m_continuekey = WowIntegerKeyboard.KeyC;
        public int m_escapeKey = WowIntegerKeyboard.Escape;
        public int m_enterKey = WowIntegerKeyboard.Enter;   

        public void SetFrameMilliseconds(int milliseconds) => m_frameMilliseconds = milliseconds;
        public void TapEnter() => TapKey(m_enterKey);
        public void TapEscape() => TapKey(m_escapeKey);
        public void TapContinue() => TapKey(m_continuekey);
        public void TapRestart() => TapKey(m_restartkey);
        public void TapSword() => TapKey(m_swordKey);
        public void TapShuriken() => TapKey(m_shurikenKey);
        public void TapJump() => TapKey(m_jumpKey);

        public void StartMovingLeft() => PressKey(m_moveLeftKey);
        public void StopMovingLeft() => ReleaseKey(m_moveLeftKey);

        public void StartMovingRight() => PressKey(m_moveRightKey);
        public void StopMovingRight() => ReleaseKey(m_moveRightKey);

        public void StartJumping() => PressKey(m_jumpKey);
        public void StopJumping() => ReleaseKey(m_jumpKey);

        public void PressShurikenKey() => PressKey(m_shurikenKey);
        public void ReleaseShurikenKey() => ReleaseKey(m_shurikenKey);

        public void PressSwordKey() => PressKey(m_swordKey);
        public void ReleaseSwordKey() => ReleaseKey(m_swordKey);

        public void TapDoubleJumpInMilliseconds(int millisecondBetweenJump)
        {

            TapJump();
            WaitSomeMilliseconds(millisecondBetweenJump);
            TapJump();
        }
    }
}


