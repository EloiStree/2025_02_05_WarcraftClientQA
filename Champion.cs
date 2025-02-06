




public class Champion {

    public PushIntegerToGameUDP m_sender;
    public Champion(PushIntegerToGameUDP push) { 
        m_sender = push;
    }

    public int m_openChat = WowIntegerKeyboard.NumpadDecimal;
    public int m_pitchUp = WowIntegerKeyboard.Insert;
    public int m_pitchDown= WowIntegerKeyboard.Delete;
    public int m_moveDown = WowIntegerKeyboard.KeyX;

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
    public void TapKey(int keyCode) { 
        PressKey(keyCode);
        WaitFrame();
        ReleaseKey(keyCode);
    }
    public void StartJump() => PressKey(WowIntegerKeyboard.Space);
    public void StopJump() => ReleaseKey(WowIntegerKeyboard.Space);

    public void StartForward() => PressKey(WowIntegerKeyboard.ArrowUp);
    public void StopMovingForward() => ReleaseKey(WowIntegerKeyboard.ArrowUp);

    public void StartMovingBackward() => PressKey(WowIntegerKeyboard.ArrowDown);
    public void StopMovingBackward() => ReleaseKey(WowIntegerKeyboard.ArrowDown);

    public void StartMovingLeft() => PressKey(WowIntegerKeyboard.KeyQ);
    public void StopMovingLeft() => ReleaseKey(WowIntegerKeyboard.KeyQ);
    public void StartMovingRight() => PressKey(WowIntegerKeyboard.KeyE);
    public void StopMovingRight() => ReleaseKey(WowIntegerKeyboard.KeyE);

    public void StartRotateLeft() => PressKey(WowIntegerKeyboard.ArrowLeft);
    public void StopRotateLeft() => ReleaseKey(WowIntegerKeyboard.ArrowLeft);

    public void StartRotateRight() => PressKey(WowIntegerKeyboard.ArrowRight);
    public void StopRotateRight() => ReleaseKey(WowIntegerKeyboard.ArrowRight);

    public void StartEnter()=>PressKey(WowIntegerKeyboard.Enter);
    public void StopEnter()=>ReleaseKey(WowIntegerKeyboard.Enter);


    public void StartMovingDown() => PressKey(WowIntegerKeyboard.KeyX);
    public void StopMovingDown() => PressKey(WowIntegerKeyboard.KeyX);

    public void StartMovingUp() => PressKey(WowIntegerKeyboard.Space);
    public void StopMovingUp() => ReleaseKey(WowIntegerKeyboard.Space);

    public void StartPitchUp() => PressKey(WowIntegerKeyboard.Insert);
    public void StopPitchUp() => ReleaseKey(WowIntegerKeyboard.Insert);

    public void StartPitchDown() => PressKey(WowIntegerKeyboard.Delete);
    public void StopPitchDown() => ReleaseKey(WowIntegerKeyboard.Delete);



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
        StopMovingLeft();
        StopMovingRight();
        StopMovingForward();
        StopRotateLeft();
        StopRotateRight();


    }
}
