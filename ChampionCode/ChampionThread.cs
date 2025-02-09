




using XboxClientQA.Pickup;

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
    public int m_frameMilliseconds=50;

    public void WaitFrame()=>Thread.Sleep(m_frameMilliseconds);
    public void WaitOneSeconds() => Thread.Sleep(1000);
    public void WaitSomeSeconds(float seconds) => Thread.Sleep((int)(seconds*1000f));
    public void PressKey(int keyCode) => m_sender.PushInteger(keyCode);
    public void ReleaseKey(int keyCode) => m_sender.PushInteger(keyCode+1000);
    public void PressReleaseWithDelay(int keycode, float delayBetweenInSeconds, float delayAfterInSeconds)
    {
        PressKey(keycode);
        WaitSomeSeconds(delayBetweenInSeconds);
        ReleaseKey(keycode);
        WaitSomeSeconds(delayAfterInSeconds);
    }
    public void PressReleaseWithDelay(int keycode, int delayBetweenInMilliseconds, int delayAfterInMilliseconds)
    {
        PressKey(keycode);
        WaitSomeMilliseconds(delayBetweenInMilliseconds);
        ReleaseKey(keycode);
        WaitSomeMilliseconds(delayAfterInMilliseconds);
    }

    public void TapKey(int keyCode) { 
        PressKey(keyCode);
        WaitFrame();
        ReleaseKey(keyCode);
    }
    public void StartJump() => PressKey(m_jump);
    public void StopJump() => ReleaseKey(m_jump);

    public void StartMovingForward() => PressKey(m_moveHorizontalForward);
    public void StopMovingForward() => ReleaseKey(m_moveHorizontalForward);

    public void StartMovingBackward() => PressKey(m_moveHorizontalBackward);
    public void StopMovingBackward() => ReleaseKey(m_moveHorizontalBackward);

    public void StartStrafeLeft() => PressKey(m_strafeLeftKey);
    public void StopStrafeLeft() => ReleaseKey(m_strafeLeftKey);

    public void StartStrafeRight() => PressKey(m_strafeRightKey);
    public void StopStrafeRight() => ReleaseKey(m_strafeRightKey);

    public void StartRotateLeft() => PressKey(m_rotateLeft);
    public void StopRotateLeft() => ReleaseKey(m_rotateLeft);

    public void StartRotateRight() => PressKey(m_rotateRight);
    public void StopRotateRight() => ReleaseKey(m_rotateRight);

    public void StartEnter()=>PressKey(m_enter);
    public void StopEnter()=>ReleaseKey(m_enter);

    public void StartMovingUpward() => PressKey(m_moveVerticalUp);
    public void StopMovingUpward() => PressKey(m_moveVerticalUp);

    public void StartMovingDownward() => PressKey(m_moveVerticalDown);
    public void StopMovingDownward() => ReleaseKey(m_moveVerticalDown);

    public void StartPitchUp() => PressKey(m_pitchUp);
    public void StopPitchUp() => ReleaseKey(m_pitchUp);

    public void StartPitchDown() => PressKey(m_pitchDown);
    public void StopPitchDown() => ReleaseKey(m_pitchDown);



    public void TapOpenChat() => TapKey(m_openChat);
    public void TapMap() => TapKey(WowIntegerKeyboard.KeyM);

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

    public void WriteAlpahNumericalCommand(string text, bool useSlash=true)
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
        WriteAlpahNumericalCommand(text, false);
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

    public void CmdChatLogout() => WriteAlpahNumericalCommand("logout");


    public void CastChat(string text)
    {
        WriteAlpahNumericalCommand("cast " + text);
    }
    public void RunLUA(string text)
    {
        WriteAlpahNumericalCommand("run " + text);
    }

    public void RunSoundWithLUA(int soundId)
    {
        RunLUA($"PlaySound({soundId})");
    }

    public void TargetChat(string targetName)
    {
        WriteAlpahNumericalCommand("target " + targetName);
    }
    public void ExactTargetChat(string exactTargetName)
    {
        WriteAlpahNumericalCommand("exacttarget " + exactTargetName);
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

    public void SwithPlayerIndex(int playerIndex)
    {
        m_sender.SwithPlayerIndex(playerIndex);
    }

    public float m_speedMoveLeftUpRight = 7f;
    public float m_speedMoveDown = 4f;
    public float m_rotationAngle = 180f;
    public float m_pitchAngle = 180f;
    public void AngleForRotationLeftRightAngle(float degreeToRotateLeftToRight)
    {
        ChampionMoveAndRotate.Rotate(degreeToRotateLeftToRight, m_rotationAngle, out float timeToRotate);
        if (degreeToRotateLeftToRight < 0)
        {
            PressReleaseWithDelay(m_rotateLeft,Math.Abs( timeToRotate),0);
        }
        else if (degreeToRotateLeftToRight > 0)
        {
            PressReleaseWithDelay(m_rotateRight, Math.Abs(timeToRotate), 0);

        }
    }
    public void MoveForDistance(float distance)
    {
        float timeToMove = 0;
        if (distance > 0f)
        {
            ChampionMoveAndRotate.Move(distance, m_speedMoveLeftUpRight, out  timeToMove);
            PressReleaseWithDelay(m_moveHorizontalForward, Math.Abs(timeToMove), 0);
        }
        else if (distance < 0f)
        {
            ChampionMoveAndRotate.Move(distance, m_speedMoveDown, out timeToMove);
            PressReleaseWithDelay(m_moveHorizontalBackward, Math.Abs(timeToMove), 0);
        
        }

    }

    public void PitchBotToTop(float degreeToRotateBotTop) {
        ChampionMoveAndRotate.Rotate(degreeToRotateBotTop, m_rotationAngle, out float timeToRotate);
        if (degreeToRotateBotTop < 0)
        {
            PressReleaseWithDelay(m_pitchDown, Math.Abs(timeToRotate), 0);
        }
        else if (degreeToRotateBotTop > 0)
        {
            PressReleaseWithDelay(m_pitchUp, Math.Abs(timeToRotate), 0);

        }
    }

    public void StrafeMove(float distance)
    {
        float timeToMove = 0;
        if (distance > 0f)
        {
            ChampionMoveAndRotate.Move(distance, m_speedMoveLeftUpRight, out timeToMove);
            PressReleaseWithDelay(m_strafeRightKey, Math.Abs(timeToMove), 0);
        }
        else if (distance < 0f)
        {
            ChampionMoveAndRotate.Move(distance, m_speedMoveLeftUpRight, out timeToMove);
            PressReleaseWithDelay(m_strafeLeftKey, Math.Abs(timeToMove), 0);

        }
    }
}


public class ChampionThreadMapping {
        

    public static void LoadDefaultKeyToAction(ChampionThread champion) {
        champion.RegisterAction("Q", () => champion.StartRotateLeft());
        champion.RegisterAction("q", () => champion.StopRotateLeft());
        champion.RegisterAction("q.", () => champion.TapKey(champion.m_rotateLeft));
        champion.RegisterAction("D", () => champion.StartRotateRight());
        champion.RegisterAction("d", () => champion.StopRotateRight());
        champion.RegisterAction("d.", () => champion.TapKey(champion.m_rotateRight));
        champion.RegisterAction("Z", () => champion.StartMovingForward());
        champion.RegisterAction("z", () => champion.StopMovingForward());
        champion.RegisterAction("z.", () => champion.TapKey(champion.m_moveHorizontalForward));
        champion.RegisterAction("S", () => champion.StartMovingBackward());
        champion.RegisterAction("s", () => champion.StopMovingBackward());
        champion.RegisterAction("s.", () => champion.TapKey(champion.m_moveHorizontalBackward));
        champion.RegisterAction("W", () => champion.StartStrafeLeft());
        champion.RegisterAction("w", () => champion.StopStrafeLeft());
        champion.RegisterAction("w.", () => champion.TapKey(champion.m_strafeLeftKey));
        champion.RegisterAction("X", () => champion.StartStrafeRight());
        champion.RegisterAction("x", () => champion.StopStrafeRight());
        champion.RegisterAction("x.", () => champion.TapKey(champion.m_strafeRightKey));

        champion.RegisterAction("C", () => champion.StartMovingDownward());
        champion.RegisterAction("c", () => champion.StopMovingDownward());
        champion.RegisterAction("c.", () => champion.TapKey(champion.m_moveVerticalDown));


        champion.RegisterAction("F", () => champion.PressKey(champion.m_interactWithTarget));
        champion.RegisterAction("f", () => champion.ReleaseKey(champion.m_interactWithTarget));
        champion.RegisterAction("f.", () => champion.TapKey(champion.m_interactWithTarget));
        champion.RegisterAction("M", () => champion.PressKey(champion.m_map));
        champion.RegisterAction("m", () => champion.ReleaseKey(champion.m_map));
        champion.RegisterAction("m.", () => champion.TapKey(champion.m_map));
        champion.RegisterAction("J", () => champion.StartJump());
        champion.RegisterAction("j", () => champion.StopJump());
        champion.RegisterAction("j.", () => champion.TapJump());
        champion.RegisterAction("p1", () => champion.TapPower1());
        champion.RegisterAction("p2", () => champion.TapPower2());
        champion.RegisterAction("p3", () => champion.TapPower3());
        champion.RegisterAction("p4", () => champion.TapPower4());
        champion.RegisterAction("p5", () => champion.TapPower5());
        champion.RegisterAction("p6", () => champion.TapPower6());
        champion.RegisterAction("p7", () => champion.TapPower7());
        champion.RegisterAction("p8", () => champion.TapPower8());
        champion.RegisterAction("p9", () => champion.TapPower9());
        champion.RegisterAction("p0", () => champion.TapPower0());
        champion.RegisterAction("f1", () => champion.TapF1());
        champion.RegisterAction("f2", () => champion.TapF2());
        champion.RegisterAction("f3", () => champion.TapF3());
        champion.RegisterAction("f4", () => champion.TapF4());
        champion.RegisterAction("f5", () => champion.TapF5());
        champion.RegisterAction("f6", () => champion.TapF6());
        champion.RegisterAction("f7", () => champion.TapF7());
        champion.RegisterAction("f8", () => champion.TapF8());
        champion.RegisterAction("f9", () => champion.TapF9());
        champion.RegisterAction("f10", () => champion.TapF10());
        champion.RegisterAction("f11", () => champion.TapF11());
        champion.RegisterAction("f12", () => champion.TapF12());
        champion.RegisterAction("backspace", () => champion.TapBackSpace());
        champion.RegisterAction("delete", () => champion.TapDelete());
        champion.RegisterAction("home", () => champion.TapKey(WowIntegerKeyboard.Home));
        champion.RegisterAction("end", () => champion.TapKey(WowIntegerKeyboard.End));
        champion.RegisterAction("insert", () => champion.TapKey(WowIntegerKeyboard.Insert));
        champion.RegisterAction("enter", () => champion.TapKey(WowIntegerKeyboard.Enter));
        champion.RegisterAction("space", () => champion.TapKey(WowIntegerKeyboard.Space));
        champion.RegisterAction("tab", () => champion.TapKey(WowIntegerKeyboard.Tab));
        champion.RegisterAction("au", () => champion.TapKey(WowIntegerKeyboard.ArrowUp));
        champion.RegisterAction("ad", () => champion.TapKey(WowIntegerKeyboard.ArrowDown));
        champion.RegisterAction("al", () => champion.TapKey(WowIntegerKeyboard.ArrowLeft));
        champion.RegisterAction("ar", () => champion.TapKey(WowIntegerKeyboard.ArrowRight));
        champion.RegisterAction("pageup", () => champion.TapKey(WowIntegerKeyboard.PageUp));
        champion.RegisterAction("pagedown", () => champion.TapKey(WowIntegerKeyboard.PageDown));
        champion.RegisterAction("oem1", () => champion.TapKey(WowIntegerKeyboard.Oem1));
        champion.RegisterAction("oem102", () => champion.TapKey(WowIntegerKeyboard.Oem102));
        champion.RegisterAction("oem2", () => champion.TapKey(WowIntegerKeyboard.Oem2));
        champion.RegisterAction("oem3", () => champion.TapKey(WowIntegerKeyboard.Oem3));
        champion.RegisterAction("oem4", () => champion.TapKey(WowIntegerKeyboard.Oem4));
        champion.RegisterAction("oem5", () => champion.TapKey(WowIntegerKeyboard.Oem5));
        champion.RegisterAction("oem6", () => champion.TapKey(WowIntegerKeyboard.Oem6));
        champion.RegisterAction("oem7", () => champion.TapKey(WowIntegerKeyboard.Oem7));
        champion.RegisterAction("oem8", () => champion.TapKey(WowIntegerKeyboard.Oem8));
        champion.RegisterAction("oemcomma", () => champion.TapKey(WowIntegerKeyboard.OemComma));
        champion.RegisterAction("oemminus", () => champion.TapKey(WowIntegerKeyboard.OemMinus));
        champion.RegisterAction("oemperiod", () => champion.TapKey(WowIntegerKeyboard.OemPeriod));
        champion.RegisterAction("oemplus", () => champion.TapKey(WowIntegerKeyboard.OemPlus));
        champion.RegisterAction("dance", () => champion.WriteAlpahNumericalCommand("dance"));
        champion.RegisterAction("stop", () => champion.StopReleaseKey());
        champion.RegisterAction("jump", () => champion.TapJump());
        champion.RegisterAction("focus", () => {
            champion.RequestWindowFocus();
        });
    }

    public static void AddInterpreterRMSP(ChampionThread champion)
    {
        champion.AddInterpreter((command) =>
        {
            switch (command)
            {
                case "Hello":
                    Console.WriteLine("Hello World !!!");
                    return;
            }

            if (command.StartsWith("R:"))
            {
                Console.WriteLine("Rotate " + command);
                string[] parts = command.Split(':');
                if (parts.Length == 2 && float.TryParse(parts[1], out float degree))
                {
                    champion.AngleForRotationLeftRightAngle(degree);
                }
            }
            else if (command.StartsWith("M:"))
            {
                Console.WriteLine("Move " + command);
                string[] parts = command.Split(':');
                if (parts.Length == 2 && float.TryParse(parts[1], out float distance))
                {
                    champion.MoveForDistance(distance);
                }
            }
            else if (command.StartsWith("S:"))
            {
                Console.WriteLine("Strafe " + command);
                string[] parts = command.Split(':');
                if (parts.Length == 2 && float.TryParse(parts[1], out float distance))
                {
                    champion.StrafeMove(distance);
                }
            }
            else if (command.StartsWith("P:"))
            {
                Console.WriteLine("Pitch " + command);
                string[] parts = command.Split(':');
                if (parts.Length == 2 && float.TryParse(parts[1], out float distance))
                {
                    champion.PitchBotToTop(distance);
                }
            }
        });

    }

    public static void LoadInColorPickingCommand(ChampionThread champion, ColorPickerRefreshTimer colorPicker)
    {
        champion.RegisterAction("color", () =>
        {
            Console.WriteLine("Set Color Picker Position");
            colorPicker.FetchPositionFromConsole();
        });
        champion.RegisterAction("position", () => {

            colorPicker.DipslayPositionInConsole();
        });
    }

    public static void HideAddCode(ChampionThread champion, ColorPickerRefreshTimer colorPicker)
    {
        ChampionThreadMapping.LoadDefaultKeyToAction(champion);
        ChampionThreadMapping.LoadInColorPickingCommand(champion, colorPicker);
        ChampionThreadMapping.AddInterpreterRMSP(champion);

    }
}