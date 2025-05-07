
using System.Numerics;
using ClientQA.LearningExample.Basic;
using ClientQA.TeacherCode.CoordinateWow;
using ClientQA.UtilityCode;

//public class WowCalculator {

//    public static float m_defaultSpeedMove = 6.5f;
//    public bool m_isScience = false;
//    public float m_speedMove = 7f;

//    public float  MoveForSeconds(float distance) {
//        return distance / m_speedMove;
//        //throw new NotImplementedException("Sorry");

//    }
//    public float[] MoveForSeconds(float distance, float acceleration)
//    {
//       // throw new NotImplementedException("No idea what I am doing");
//        return new float[2];

//    }
//    public void Multiply(Vector2 point,float value, 
//        out float x, out float y)
//    {
//        x = point.X*value;
//        y = point.Y*value;
//    }
//}

public partial class ChampionThread {

    public PushIntegerToGameUDP m_sender;
    public ChampionThread(PushIntegerToGameUDP push)
    {
        m_sender = push;
    }
    public ChampionThread(string ipv4, int port, int playerIndex)
    {
        m_sender = new PushIntegerToGameUDP(ipv4, port, playerIndex);

        m_messageQueue.AddDequeueListener((string command) =>
        {
            m_registeredAction.ExecuteIfExistSimpleAction(command, out bool found);
            if (found)
                Console.WriteLine("E:" + command);
        });



    }



    public int m_strafeLeftKey = WowIntegerKeyboard.KeyQ;
    public int m_strafeRightKey = WowIntegerKeyboard.KeyE;
    public int m_moveHorizontalForward = WowIntegerKeyboard.ArrowUp;
    public int m_moveHorizontalBackward = WowIntegerKeyboard.ArrowDown;
    public int m_rotateLeft = WowIntegerKeyboard.ArrowLeft;
    public int m_rotateRight = WowIntegerKeyboard.ArrowRight;

    public int m_jump = WowIntegerKeyboard.Space;
    public int m_follow = WowIntegerKeyboard.Numpad0;

    public int m_openChat = WowIntegerKeyboard.NumpadDecimal;
    public int m_pitchUp = WowIntegerKeyboard.Insert;
    public int m_pitchDown= WowIntegerKeyboard.Delete;
    public int m_moveVerticalDown = WowIntegerKeyboard.KeyX;
    public int m_moveVerticalUp = WowIntegerKeyboard.Space;
    public int m_enter = WowIntegerKeyboard.Enter;

    public int m_menuCharacter = WowIntegerKeyboard.KeyC;
    public int m_menuBagAll = WowIntegerKeyboard.KeyB;
    public int m_menuReputation = WowIntegerKeyboard.KeyU;
    public int m_menuSpellBook = WowIntegerKeyboard.KeyP;
    public int m_menuProfessionBool = WowIntegerKeyboard.KeyK;
    public int m_talentPanel= WowIntegerKeyboard.KeyN;
    public int m_achivementPanel = WowIntegerKeyboard.KeyY;
    public int m_questLog = WowIntegerKeyboard.KeyL;
    public int m_map = WowIntegerKeyboard.KeyM;
    public int m_menuGuild = WowIntegerKeyboard.KeyI;
    public int m_menuFriends = WowIntegerKeyboard.KeyO;
    public int m_chatPanel = WowIntegerKeyboard.KeyT;
    public int m_groupFinding = WowIntegerKeyboard.KeyI;
    public int m_menuPVP = WowIntegerKeyboard.KeyH;
    public int m_targetNearestEnemy = WowIntegerKeyboard.Tab;
    public int m_targetSelf = WowIntegerKeyboard.F1;
    public int m_targetParty1 = WowIntegerKeyboard.F2;
    public int m_targetParty2 = WowIntegerKeyboard.F3;
    public int m_targetParty3 = WowIntegerKeyboard.F4;
    public int m_targetParty4 = WowIntegerKeyboard.F5;
    public int m_interactWithTarget = WowIntegerKeyboard.KeyF;
    public int m_ping = WowIntegerKeyboard.KeyG;
    // 
    public int m_frameMilliseconds=50;
    public void WaitOneFrame()=>Thread.Sleep(m_frameMilliseconds);
    public void WaitOneSeconds() { Thread.Sleep(1000); }
    public void WaitTwoSeconds() { Thread.Sleep(2000); }
    public void WaitSomeSeconds(float seconds) => Thread.Sleep((int)(seconds*1000f));
    public void PressKey(int keyCode) => m_sender.PushInteger(keyCode);
    public void ReleaseKey(int keyCode) => m_sender.PushInteger(keyCode+1000);


    public void Ping() {
        for (int i = 0; i < 10; i++)
        {
            TapJump();
            WaitSomeMilliseconds(500);
        }
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

    public void TapKey(int keyCode) { 
        PressKey(keyCode);
        WaitOneFrame();
        ReleaseKey(keyCode);
    }
    public void StartJumpFor(float delayInSeconds)=> PressReleaseWithDelayForSeconds(m_jump, delayInSeconds, 0);
    public void StartJumpFor(int delayInMilliseconds) => PressReleaseWithDelayForMilliseconds(m_jump, delayInMilliseconds, 0);
    public void StartJump() => PressKey(m_jump);
    public void StopJump() => ReleaseKey(m_jump);

    public void StartMovingForwardFor(float delayInSeconds) => PressReleaseWithDelayForSeconds(m_moveHorizontalForward, delayInSeconds, 0);
    public void StartMovingForwardFor(int delayInMilliseconds) => PressReleaseWithDelayForMilliseconds(m_moveHorizontalForward, delayInMilliseconds, 0);
    public void StartMovingForward() => PressKey(m_moveHorizontalForward);
    public void StopMovingForward() => ReleaseKey(m_moveHorizontalForward);

    public void StartMovingBackwardFor(float delayInSeconds) => PressReleaseWithDelayForSeconds(m_moveHorizontalBackward, delayInSeconds, 0);
    public void StartMovingBackwardFor(int delayInMilliseconds) => PressReleaseWithDelayForMilliseconds(m_moveHorizontalBackward, delayInMilliseconds, 0);
    public void StartMovingBackward() => PressKey(m_moveHorizontalBackward);
    public void StopMovingBackward() => ReleaseKey(m_moveHorizontalBackward);

    public void StartStrafeLeftFor(float delayInSeconds) => PressReleaseWithDelayForSeconds(m_strafeLeftKey, delayInSeconds, 0);
    public void StartStrafeLeftFor(int delayInMilliseconds) => PressReleaseWithDelayForMilliseconds(m_strafeLeftKey, delayInMilliseconds, 0);
    public void StartStrafeLeft() => PressKey(m_strafeLeftKey);
    public void StopStrafeLeft() => ReleaseKey(m_strafeLeftKey);

    public void StartStrafeRightFor(float delayInSeconds) => PressReleaseWithDelayForSeconds(m_strafeRightKey, delayInSeconds, 0);
    public void StartStrafeRightFor(int delayInMilliseconds) => PressReleaseWithDelayForMilliseconds(m_strafeRightKey, delayInMilliseconds, 0);
    public void StartStrafeRight() => PressKey(m_strafeRightKey);
    public void StopStrafeRight() => ReleaseKey(m_strafeRightKey);

    public void StartRotateLeftFor(float delayInSeconds) => PressReleaseWithDelayForSeconds(m_rotateLeft, delayInSeconds, 0);
    public void StartRotateLeftFor(int delayInMilliseconds) => PressReleaseWithDelayForMilliseconds(m_rotateLeft, delayInMilliseconds, 0);

    /// <summary>
    /// This method will rotate the character to the left until we stop it (press the key in game with udp)
    /// </summary>
    public void StartRotateLeft() => PressKey(m_rotateLeft);

    /// <summary>
    /// This method will stop the rotation to the left (release the key in game with udp)
    /// </summary>
    public void StopRotateLeft() => ReleaseKey(m_rotateLeft);

    public void StartRotateRightFor(float delayInSeconds) => PressReleaseWithDelayForSeconds(m_rotateRight, delayInSeconds, 0);
    public void StartRotateRightFor(int delayInMilliseconds) => PressReleaseWithDelayForMilliseconds(m_rotateRight, delayInMilliseconds, 0);
    public void StartRotateRight() => PressKey(m_rotateRight);
    public void StopRotateRight() => ReleaseKey(m_rotateRight);


    public void SartMovingUpwardFor(float delayInSeconds) => PressReleaseWithDelayForSeconds(m_moveVerticalUp, delayInSeconds, 0);
    public void StartMovingUpwardFor(int delayInMilliseconds) => PressReleaseWithDelayForMilliseconds(m_moveVerticalUp, delayInMilliseconds, 0);
    public void StartMovingUpward() => PressKey(m_moveVerticalUp);
    public void StopMovingUpward() => PressKey(m_moveVerticalUp);

    public void StartMovingDownwardFor(float delayInSeconds) => PressReleaseWithDelayForSeconds(m_moveVerticalDown, delayInSeconds, 0);
    public void StartMovingDownwardFor(int delayInMilliseconds) => PressReleaseWithDelayForMilliseconds(m_moveVerticalDown, delayInMilliseconds, 0);
    public void StartMovingDownward() => PressKey(m_moveVerticalDown);
    public void StopMovingDownward() => ReleaseKey(m_moveVerticalDown);

    public void StartPitchUpFor(float delayInSeconds) => PressReleaseWithDelayForSeconds(m_pitchUp, delayInSeconds, 0);
    public void StartPitchUpFor(int delayInMilliseconds) => PressReleaseWithDelayForMilliseconds(m_pitchUp, delayInMilliseconds, 0);
    public void StartPitchUp() => PressKey(m_pitchUp);
    public void StopPitchUp() => ReleaseKey(m_pitchUp);

    public void StartPitchDownFor(float delayInSeconds) => PressReleaseWithDelayForSeconds(m_pitchDown, delayInSeconds, 0);
    public void StartPitchDownFor(int delayInMilliseconds) => PressReleaseWithDelayForMilliseconds(m_pitchDown, delayInMilliseconds, 0);
    public void StartPitchDown() => PressKey(m_pitchDown);
    public void StopPitchDown() => ReleaseKey(m_pitchDown);




    public void StartEnter()=>PressKey(m_enter);
    public void StopEnter()=>ReleaseKey(m_enter);

    public void TapTabulation()
    {
        PressKey(WowIntegerKeyboard.Tab);
        WaitOneFrame();
        ReleaseKey(WowIntegerKeyboard.Tab);
    }

    public void TapOpenChat() => TapKey(m_openChat);
    public void TapMap() => TapKey(WowIntegerKeyboard.KeyM);
    public void TapInteract() => TapKey(WowIntegerKeyboard.KeyF);
    public void TapPower1() => TapKey(WowIntegerKeyboard.Alpha1);
    public void TapPower2() => TapKey(WowIntegerKeyboard.Alpha2);
    public void TapPower3() => TapKey(WowIntegerKeyboard.Alpha3);
    public void TapPower4() => TapKey(WowIntegerKeyboard.Alpha4);
    public void TapPower5() => TapKey(WowIntegerKeyboard.Alpha5);
    public void TapPower6() => TapKey(WowIntegerKeyboard.Alpha6);
    public void TapPower7() => TapKey(WowIntegerKeyboard.Alpha7);
    public void TapPower8() => TapKey(WowIntegerKeyboard.Alpha8);
    public void TapPower9() => TapKey(WowIntegerKeyboard.Alpha9);
    public void TapPower0() => TapKey(WowIntegerKeyboard.Alpha0);
    public void TapF1() => TapKey(WowIntegerKeyboard.F1);
    public void TapF2() => TapKey(WowIntegerKeyboard.F2);
    public void TapF3() => TapKey(WowIntegerKeyboard.F3);
    public void TapF4() => TapKey(WowIntegerKeyboard.F4);
    public void TapF5() => TapKey(WowIntegerKeyboard.F5);
    public void TapF6() => TapKey(WowIntegerKeyboard.F6);
    public void TapF7() => TapKey(WowIntegerKeyboard.F7);
    public void TapF8() => TapKey(WowIntegerKeyboard.F8);
    public void TapF9() => TapKey(WowIntegerKeyboard.F9);
    public void TapF10() => TapKey(WowIntegerKeyboard.F10);
    public void TapF11() => TapKey(WowIntegerKeyboard.F11);
    public void TapF12() => TapKey(WowIntegerKeyboard.F12);


    public string[] m_wowCommand= @"agree,amaze,angry,apologize,applaud,applause,attacktarget,bark
,bashful,beckon,beg,belch,bite,bleed,blood,
blink,blow,blush,boggle,bonk,bored,bounce,
bow,bravo,brandish,brb,burp,bye,cackle,calm
,cat,catty,charge,cheer,chew,chicken,
chuckle,clap,cold,comfort,commend,
confused,congrats,cong,
congratulate,cough,cower,crack,cringe,cry,
cuddle,curious,curtsey,dance,ding,
disappointed,disappointment,doh,doom,
drink,drool,duck,eat,excited,eye,
facepalm,farewell,fart,fear,
feast,fidget,flap,flee,flex
,flirt,flop,followme,food,frown,
gasp,gaze,giggle,glad,glare,gloat,
golfclap,goodbye,greet,greetings,
grin,groan,grovel,growl,guffaw,hail,happy,
healme,hello,helpme,hi,highfive,hug,hungry,
impatient,incoming,insult,introduce,jk,kiss,
kneel,knuckles,laugh,lavish,lay,
laydown,lick,lie,liedown,listen,
lol,lost,love,mad,massage,moan,mock,
moo,moon,mountspecial,mourn,no,nod,nosepick,oom,
openfire,panic,party,pat,peer,peon,pest,
pick,pity,pizza,plead,point,poke,
ponder,pounce,praise,pray,purr,puzzled,
question,raise,rasp,rdy,ready,read,rear,regret,roar,
rofl,rolleyes,rude,sad,salute,scared,scratch
,sexy,shake,shimmy,shindig,shiver,shoo,shrug,shy,
sigh,silly,slap,sleep,smell,smile,smirk,snarl,sneeze,
snicker,sniff,snub,sob,soothe,sorry,spit".Replace("\n", "").Replace("\r", "").Replace(" ", "").Split(",");



    public void WriteAlphaNumericalCommand(string text, bool useSlash=true)
    {
        int customPressTime = 100;
        PressKey(m_openChat);
        Thread.Sleep(customPressTime);
        ReleaseKey(m_openChat);
        Thread.Sleep(200);


        Thread.Sleep(customPressTime);
        PressKey(WowIntegerKeyboard.Backspace);
        Thread.Sleep(customPressTime);
        ReleaseKey(WowIntegerKeyboard.Backspace); if (!useSlash)
        {
            Thread.Sleep(customPressTime);
            PressKey(WowIntegerKeyboard.Backspace);
            Thread.Sleep(customPressTime);
            ReleaseKey(WowIntegerKeyboard.Backspace);
        }
        foreach (char c in text)
        {
            GetKey(c, out bool found, out int keyCode);
            if (found)
            {
                PressKey(keyCode);
                Thread.Sleep(customPressTime);
                ReleaseKey(keyCode);
                Thread.Sleep(customPressTime);
                PressKey(WowIntegerKeyboard.Backspace);
                Thread.Sleep(customPressTime);
                ReleaseKey(WowIntegerKeyboard.Backspace);
            }
        }
        Thread.Sleep(200);
        PressKey(WowIntegerKeyboard.Enter);
        Thread.Sleep(customPressTime);
        ReleaseKey(WowIntegerKeyboard.Enter);
    }
    public void WriteAlpahNumericalTextChat(string text)
    {
        WriteAlphaNumericalCommand(text, false);
    }

    public void TapDelete() => TapKey(WowIntegerKeyboard.Delete);
    public void TapEnter()=> TapKey(WowIntegerKeyboard.Enter);
    public void TapBackSpace() => TapKey(WowIntegerKeyboard.Backspace);
    public void TapPrintScreen() => TapKey(WowIntegerKeyboard.PrintScreen);
    public void TapNumpadMultiply() => TapKey(WowIntegerKeyboard.NumpadMultiply);
    public void TapNumpadAdd() => TapKey(WowIntegerKeyboard.NumpadAdd);
    public void TapNumpadSubtract() => TapKey(WowIntegerKeyboard.NumpadSubtract);
    public void TapNumpadDivide() => TapKey(WowIntegerKeyboard.NumpadDivide);


    public void RequestWindowFocus() => TapKey(WowIntegerFocus.FocusWindow);


    private void GetKey(char c, out bool found, out int keyCode)
    {
        found = false;
        keyCode = 0;
        switch (c) {
            case ('a'): case ('A'): found = true; keyCode = WowIntegerKeyboard.KeyA; return;
            case ('b'): case ('B'): found = true; keyCode = WowIntegerKeyboard.KeyB; return;
            case ('c'): case ('C'): found = true; keyCode = WowIntegerKeyboard.KeyC; return;
            case ('d'): case ('D'): found = true; keyCode = WowIntegerKeyboard.KeyD; return;
            case ('e'): case ('E'): found = true; keyCode = WowIntegerKeyboard.KeyE; return;
            case ('f'): case ('F'): found = true; keyCode = WowIntegerKeyboard.KeyF; return;
            case ('g'): case ('G'): found = true; keyCode = WowIntegerKeyboard.KeyG; return;
            case ('h'): case ('H'): found = true; keyCode = WowIntegerKeyboard.KeyH; return;
            case ('i'): case ('I'): found = true; keyCode = WowIntegerKeyboard.KeyI; return;
            case ('j'): case ('J'): found = true; keyCode = WowIntegerKeyboard.KeyJ; return;
            case ('k'): case ('K'): found = true; keyCode = WowIntegerKeyboard.KeyK; return;
            case ('l'): case ('L'): found = true; keyCode = WowIntegerKeyboard.KeyL; return;
            case ('m'): case ('M'): found = true; keyCode = WowIntegerKeyboard.KeyM; return;
            case ('n'): case ('N'): found = true; keyCode = WowIntegerKeyboard.KeyN; return;
            case ('o'): case ('O'): found = true; keyCode = WowIntegerKeyboard.KeyO; return;
            case ('p'): case ('P'): found = true; keyCode = WowIntegerKeyboard.KeyP; return;
            case ('q'): case ('Q'): found = true; keyCode = WowIntegerKeyboard.KeyQ; return;
            case ('r'): case ('R'): found = true; keyCode = WowIntegerKeyboard.KeyR; return;
            case ('s'): case ('S'): found = true; keyCode = WowIntegerKeyboard.KeyS; return;
            case ('t'): case ('T'): found = true; keyCode = WowIntegerKeyboard.KeyT; return;
            case ('u'): case ('U'): found = true; keyCode = WowIntegerKeyboard.KeyU; return;
            case ('v'): case ('V'): found = true; keyCode = WowIntegerKeyboard.KeyV; return;
            case ('w'): case ('W'): found = true; keyCode = WowIntegerKeyboard.KeyW; return;
            case ('x'): case ('X'): found = true; keyCode = WowIntegerKeyboard.KeyX; return;
            case ('y'): case ('Y'): found = true; keyCode = WowIntegerKeyboard.KeyY; return;
            case ('z'): case ('Z'): found = true; keyCode = WowIntegerKeyboard.KeyZ; return;
            case ('0'): found = true; keyCode = WowIntegerKeyboard.Numpad0; return;
            case ('1'): found = true; keyCode = WowIntegerKeyboard.Numpad1; return;
            case ('2'): found = true; keyCode = WowIntegerKeyboard.Numpad2; return;
            case ('3'): found = true; keyCode = WowIntegerKeyboard.Numpad3; return;
            case ('4'): found = true; keyCode = WowIntegerKeyboard.Numpad4; return;
            case ('5'): found = true; keyCode = WowIntegerKeyboard.Numpad5; return;
            case ('6'): found = true; keyCode = WowIntegerKeyboard.Numpad6; return;
            case ('7'): found = true; keyCode = WowIntegerKeyboard.Numpad7; return;
            case ('8'): found = true; keyCode = WowIntegerKeyboard.Numpad8; return;
            case ('9'): found = true; keyCode = WowIntegerKeyboard.Numpad9; return;
            case (' '): found = true; keyCode = WowIntegerKeyboard.Space; return;
            case ('.'): found = true; keyCode = WowIntegerKeyboard.NumpadDecimal; return;
        
        }
    }
    public void StartNumLock() => PressKey(WowIntegerKeyboard.NumLock);
    public void StopNumLock() => ReleaseKey(WowIntegerKeyboard.NumLock);
    public void TapNumLock() => TapKey(WowIntegerKeyboard.NumLock);

    public void TapJump()
    {
        TapKey(WowIntegerKeyboard.Space);
    }

    public void TapEscape() => TapKey(WowIntegerKeyboard.Escape);

    public void CmdChatLogout() => WriteAlphaNumericalCommand("logout");


    public void CastChat(string text)
    {
        WriteAlphaNumericalCommand("cast " + text);
    }
    public void RunLUA(string text)
    {
        WriteAlphaNumericalCommand("run " + text);
    }

    public void RunSoundWithLUA(int soundId)
    {
        RunLUA($"PlaySound({soundId})");
    }

    public void TargetChat(string targetName)
    {
        WriteAlphaNumericalCommand("target " + targetName);
    }
    public void ExactTargetChat(string exactTargetName)
    {
        WriteAlphaNumericalCommand("exacttarget " + exactTargetName);
    }

   




    public void WaitSomeMilliseconds(int milliseconds)
    {
        Thread.Sleep(milliseconds);
    }

    public void StopReleaseKey()
    {
        StopMovingBackward();
        StopStrafeLeft();
        StopStrafeRight();
        StopMovingForward();
        StopRotateLeft();
        StopRotateRight();


    }


    public LambdaActionDictionary m_registeredAction = new LambdaActionDictionary();
    public MessageQueueDelayerTask m_messageQueue = new MessageQueueDelayerTask(true);

    public void RegisterAction(string exactLabel, Action action)
    {
        m_registeredAction.AddSimpleAction(exactLabel, action);
    }
    public void RegisterAction(string exactLabel, Action<ChampionThread, object> action)
    {
        m_registeredAction.AddChampionWithInfoAction(exactLabel, action);
    }
    /// <summary>
    /// This methode add your code that will turne string without space to action.
    /// </summary>
    /// <param name="exactLabel"></param>
    /// <param name="action"></param>
    public void AddInterpreter(Action<string> action)
    {
        m_messageQueue.AddDequeueListener(action);
    }
    public void RemoveInterpreter(Action<string> action)
    {
        m_messageQueue.RemoveDequeueListener(action);
    }

    public void AddInterpreter(Action<ChampionThread, object> action)
    {
        m_messageQueue.AddChampionInfoListener(action);
    }
    public void RemoveInterpreter(Action<ChampionThread, object> action)
    {
        m_messageQueue.RemoveChampionInfoListener(action);
    }

    /// <summary>
    /// Methode that will split text in items then delay it. 1000 UP 500 up 100 LEFT 200 left
    /// </summary>
    /// <param name="lineToSplitInItemsCommand"></param>

    public void PushItemsMacroToDelayer(string lineToSplitInItemsCommand)
    {
        m_messageQueue.AddMacroAsItemsFromLine(lineToSplitInItemsCommand);
    }


    //public float m_speedMoveLeftUpRight = 7f;
    public float m_speedMoveForward = 7f;
    public float m_speedMoveBackward = 4f;
    public float m_speedMoveLeft = 7f;
    public float m_speedMoveRight = 7f;

    public float m_rotationAngle = 180f;
    public float m_pitchAngle = 180f;


    public void RotationOfLeftAngle(float degreeToRotateLeft)
    {
        RotationForLeftRightAngle(-degreeToRotateLeft);
    }
    public void RotationOfRightAngle(float degreeToRotateRight)
    {
        RotationForLeftRightAngle(degreeToRotateRight);
    }
    public void RotationForLeftRightAngle(float degreeToRotateLeftToRight)
    {
        ChampionMoveAndRotate.Rotate(degreeToRotateLeftToRight, m_rotationAngle, out float timeToRotate);
        if (degreeToRotateLeftToRight < 0)
        {
            PressReleaseWithDelayForSeconds(m_rotateLeft,Math.Abs( timeToRotate),0);
        }
        else if (degreeToRotateLeftToRight > 0)
        {
            PressReleaseWithDelayForSeconds(m_rotateRight, Math.Abs(timeToRotate), 0);

        }
    }
    public void MoveForDistance(float distance)
    {
        float timeToMove = 0;
        if (distance > 0f)
        {
            ChampionMoveAndRotate.Move(distance, m_speedMoveForward, out  timeToMove);
            PressReleaseWithDelayForSeconds(m_moveHorizontalForward, Math.Abs(timeToMove), 0);
        }
        else if (distance < 0f)
        {
            ChampionMoveAndRotate.Move(distance, m_speedMoveBackward, out timeToMove);
            PressReleaseWithDelayForSeconds(m_moveHorizontalBackward, Math.Abs(timeToMove), 0);
        
        }

    }

    public void PitchBotToTopAngle(float degreeToRotateBotTop) {
        ChampionMoveAndRotate.Rotate(degreeToRotateBotTop, m_rotationAngle, out float timeToRotate);
        if (degreeToRotateBotTop < 0)
        {
            PressReleaseWithDelayForSeconds(m_pitchDown, Math.Abs(timeToRotate), 0);
        }
        else if (degreeToRotateBotTop > 0)
        {
            PressReleaseWithDelayForSeconds(m_pitchUp, Math.Abs(timeToRotate), 0);

        }
    }

    public void StrafeMove(float distance)
    {
        float timeToMove = 0;
        if (distance > 0f)
        {
            ChampionMoveAndRotate.Move(distance, m_speedMoveLeft, out timeToMove);
            PressReleaseWithDelayForSeconds(m_strafeRightKey, Math.Abs(timeToMove), 0);
        }
        else if (distance < 0f)
        {
            ChampionMoveAndRotate.Move(distance, m_speedMoveRight, out timeToMove);
            PressReleaseWithDelayForSeconds(m_strafeLeftKey, Math.Abs(timeToMove), 0);

        }
    }

    public void TapPower(int indexOfPower0To9)
    {
        switch (indexOfPower0To9)
        {
            case 1: TapPower1(); break;
            case 2: TapPower2(); break;
            case 3: TapPower3(); break;
            case 4: TapPower4(); break;
            case 5: TapPower5(); break;
            case 6: TapPower6(); break;
            case 7: TapPower7(); break;
            case 8: TapPower8(); break;
            case 9: TapPower9(); break;
            case 0: TapPower0(); break;
            default:
                break;
        }
    }

    public void TapF1To12(int indexFunction1To12)
    {
        switch (indexFunction1To12)
        {
            case 1: TapF1(); break;
            case 2: TapF2(); break;
            case 3: TapF3(); break;
            case 4: TapF4(); break;
            case 5: TapF5(); break;
            case 6: TapF6(); break;
            case 7: TapF7(); break;
            case 8: TapF8(); break;
            case 9: TapF9(); break;
            case 10: TapF10(); break;
            case 11: TapF11(); break;
            case 12: TapF12(); break;
            default:
                break;
        }
    }




    public void RotateToAngle(float currentAngle, float targetAngle)
    {
        WowSetToDirectionAngle.ComputeDirectionFromTo(
            currentAngle, targetAngle,
            out bool isRight, out float angleToRotate);
        if (isRight)
            RotationOfRightAngle(angleToRotate);
        else
            RotationOfLeftAngle(angleToRotate);

    }

    public void TapMS(int keycode, int milliseconds)
    {
        this.PressReleaseWithDelayForMilliseconds(keycode, milliseconds, 0);
    }
    public static void ComputeDirectionFromTo(WowMapCoord from, WowMapCoord to, 
        out bool isRotatingRight,
        out float rotationAngleAbsolute)
    {
        WowSetToDirectionAngle. ComputeDirectionFromTo(from.Angle, to.Angle, 
            out isRotatingRight, 
            out rotationAngleAbsolute);
    }
    

    public  void SetTargetIpv4(string currentComputerIp)
    {
        m_sender.SetTargetIpv4(currentComputerIp);
    }

    public void SetTargetPort(int defaultPort)
    {
        m_sender.SetTargetPort( defaultPort);
    }

    public void SetPlayerIndex(int playerIndex)
    {
        m_sender.SetPlayerIndex(playerIndex);
    }

    public void StrafeForDistanceLeftRight(int distance)
    {
        //Not tested

        bool isGoingLeft = distance < 0;
        float timeToMove = distance /(isGoingLeft? m_speedMoveLeft:m_speedMoveRight);
        if (isGoingLeft)
        {
            PressReleaseWithDelayForSeconds(m_strafeLeftKey, Math.Abs(timeToMove), 0);
        }
        else
        {
            PressReleaseWithDelayForSeconds(m_strafeRightKey, Math.Abs(timeToMove), 0);
        }
    }

    internal void GetWalkSpeedByDefault(out float leftFrontRightSpeed, out float backwardSpeed)
    {
        leftFrontRightSpeed = m_speedMoveForward;
        backwardSpeed = m_speedMoveBackward;
    }

    public float m_speedMoveForwardSteadyFly = 225f / 10f;
    public float m_speedMoveBackSteady = 4f;

    public void GetSteadyFlySpeedByDefault(out float leftFrontRightSpeed, out float backwardSpeed)
    {
        leftFrontRightSpeed = m_speedMoveForwardSteadyFly;
        backwardSpeed = m_speedMoveBackSteady;
    }

    public void PushIntegerToTarget(int index, int value)
    {
        m_sender.PushInteger(index, value);
    }

    public void MoveFromTo(
        float currentAngle,
        WowWorldPosition origin,
        WowWorldPosition destination,
        float moveForwardSpeed,
        float rotateAnglePerSeconds)
    {
        WowWorldPositionUtility.ComputeWowAngleFrom(origin, destination, out float angleDestination);
        WowSetToDirectionAngle.ComputeDirectionFromTo(
        currentAngle, angleDestination,
        out bool isRight, out float angleToRotate);

        RotationDirection rotationDirection = isRight ? RotationDirection.Right : RotationDirection.Left;
        int millisecondsToRotate = (int)((angleToRotate / rotateAnglePerSeconds) * 1000);
        if (rotationDirection == RotationDirection.Left)
        {
            StartRotateLeft();
            WaitSomeMilliseconds(millisecondsToRotate);
            StopRotateLeft();
        }
        else
        {
           StartRotateRight();
           WaitSomeMilliseconds(millisecondsToRotate);
           StopRotateRight();
        }
        WowWorldPositionUtility.ComputeDistance(origin, destination, out double distances);
        int millisecondsMoveForward =(int)(( distances / (double)moveForwardSpeed) * 1000f);

        StartMovingForward();
        WaitSomeMilliseconds(millisecondsMoveForward);
        StopMovingForward();
    }

    public void MoveFromToWalk(float angle, WowWorldPosition origin, WowWorldPosition destination)
    {
        MoveFromTo(angle, origin, destination, this.m_speedMoveForward, m_rotationAngle);

    }
    public void MoveFromToSteadyFly(float angle, WowWorldPosition origin, WowWorldPosition destination)
    {
        MoveFromTo(angle, origin, destination, this.m_speedMoveForwardSteadyFly, m_rotationAngle);

    }

}







