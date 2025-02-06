public partial class Program {


    public static void TestOemKey(Champion target,string name, int keyCode)
    {
        Console.WriteLine($"Testing key,{name}: " + keyCode);
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ready ? " + i);
            Thread.Sleep(1000);
            target.TapKey(keyCode);
            target.WaitFrame();
        }

    }

    public static void TestAllCommands(Champion target)
    {
        foreach (string command in target.m_wowCommand)
        {
            Console.WriteLine("Testing command: " + command);
            target.WriteAlpahNumericalCommand(command);
            target.WaitSomeSeconds(2);
            target.WaitSomeMilliseconds(500);
        }
    }
    public static void Main(string[] args) {
        PushIntegerToGameUDP championUdp = new PushIntegerToGameUDP(
            "127.0.0.1", 7073, 0);

        Champion champion= new Champion(championUdp);
        LambdaActionDictionary lambdaActionDictionary = new LambdaActionDictionary();
        lambdaActionDictionary.AddSimpleAction("Q", () => champion.StartRotateLeft());
        lambdaActionDictionary.AddSimpleAction("q", () => champion.StopRotateLeft());
        lambdaActionDictionary.AddSimpleAction("D", () => champion.StartRotateLeft());
        lambdaActionDictionary.AddSimpleAction("d", () => champion.StopRotateLeft());
        lambdaActionDictionary.AddSimpleAction("Z", () => champion.StartForward());
        lambdaActionDictionary.AddSimpleAction("z", () => champion.StopMovingForward());
        lambdaActionDictionary.AddSimpleAction("S", () => champion.StartMovingBackward());
        lambdaActionDictionary.AddSimpleAction("s", () => champion.StopMovingBackward());
        lambdaActionDictionary.AddSimpleAction("W", () => champion.StartMovingLeft());
        lambdaActionDictionary.AddSimpleAction("w", () => champion.StopMovingLeft());
        lambdaActionDictionary.AddSimpleAction("X", () => champion.StartMovingRight());
        lambdaActionDictionary.AddSimpleAction("x", () => champion.StopMovingRight());
        lambdaActionDictionary.AddSimpleAction("F", () => champion.PressKey(WowIntegerKeyboard.KeyF));
        lambdaActionDictionary.AddSimpleAction("f", () => champion.ReleaseKey(WowIntegerKeyboard.KeyF));
        lambdaActionDictionary.AddSimpleAction("A", () => champion.PressKey(WowIntegerKeyboard.KeyA));
        lambdaActionDictionary.AddSimpleAction("a", () => champion.ReleaseKey(WowIntegerKeyboard.KeyA));
        lambdaActionDictionary.AddSimpleAction("E", () => champion.PressKey(WowIntegerKeyboard.KeyE));
        lambdaActionDictionary.AddSimpleAction("e", () => champion.ReleaseKey(WowIntegerKeyboard.KeyE));
        lambdaActionDictionary.AddSimpleAction("M", () => champion.PressKey(WowIntegerKeyboard.KeyM));
        lambdaActionDictionary.AddSimpleAction("m", () => champion.ReleaseKey(WowIntegerKeyboard.KeyM));

        lambdaActionDictionary.AddSimpleAction("J", () => champion.StartJump());
        lambdaActionDictionary.AddSimpleAction("j", () => champion.StopJump());
        lambdaActionDictionary.AddSimpleAction("p1", () => champion.TapPower1());
        lambdaActionDictionary.AddSimpleAction("p2", () => champion.TapPower2());
        lambdaActionDictionary.AddSimpleAction("p3", () => champion.TapPower3());
        lambdaActionDictionary.AddSimpleAction("p4", () => champion.TapPower4());
        lambdaActionDictionary.AddSimpleAction("p5", () => champion.TapPower5());
        lambdaActionDictionary.AddSimpleAction("p6", () => champion.TapPower6());
        lambdaActionDictionary.AddSimpleAction("p7", () => champion.TapPower7());
        lambdaActionDictionary.AddSimpleAction("p8", () => champion.TapPower8());
        lambdaActionDictionary.AddSimpleAction("p9", () => champion.TapPower9());
        lambdaActionDictionary.AddSimpleAction("p0", () => champion.TapPower0());
        lambdaActionDictionary.AddSimpleAction("f1", () => champion.TapF1());
        lambdaActionDictionary.AddSimpleAction("f2", () => champion.TapF2());
        lambdaActionDictionary.AddSimpleAction("f3", () => champion.TapF3());
        lambdaActionDictionary.AddSimpleAction("f4", () => champion.TapF4());
        lambdaActionDictionary.AddSimpleAction("f5", () => champion.TapF5());
        lambdaActionDictionary.AddSimpleAction("f6", () => champion.TapF6());
        lambdaActionDictionary.AddSimpleAction("f7", () => champion.TapF7());
        lambdaActionDictionary.AddSimpleAction("f8", () => champion.TapF8());
        lambdaActionDictionary.AddSimpleAction("f9", () => champion.TapF9());
        lambdaActionDictionary.AddSimpleAction("f10", () => champion.TapF10());
        lambdaActionDictionary.AddSimpleAction("f11", () => champion.TapF11());
        lambdaActionDictionary.AddSimpleAction("f12", () => champion.TapF12());
        lambdaActionDictionary.AddSimpleAction("backspace", () => champion.TapBackSpace());
        lambdaActionDictionary.AddSimpleAction("delete", () => champion.TapDelete());
        lambdaActionDictionary.AddSimpleAction("home", () => champion.TapKey(WowIntegerKeyboard.Home));
        lambdaActionDictionary.AddSimpleAction("end", () => champion.TapKey(WowIntegerKeyboard.End));
        lambdaActionDictionary.AddSimpleAction("insert", () => champion.TapKey(WowIntegerKeyboard.Insert));
        lambdaActionDictionary.AddSimpleAction("enter", () => champion.TapKey(WowIntegerKeyboard.Enter));
        lambdaActionDictionary.AddSimpleAction("space", () => champion.TapKey(WowIntegerKeyboard.Space));
        lambdaActionDictionary.AddSimpleAction("tab", () => champion.TapKey(WowIntegerKeyboard.Tab));
        lambdaActionDictionary.AddSimpleAction("au", () => champion.TapKey(WowIntegerKeyboard.ArrowUp));
        lambdaActionDictionary.AddSimpleAction("ad", () => champion.TapKey(WowIntegerKeyboard.ArrowDown));
        lambdaActionDictionary.AddSimpleAction("al", () => champion.TapKey(WowIntegerKeyboard.ArrowLeft));
        lambdaActionDictionary.AddSimpleAction("ar", () => champion.TapKey(WowIntegerKeyboard.ArrowRight));
        lambdaActionDictionary.AddSimpleAction("pageup", () => champion.TapKey(WowIntegerKeyboard.PageUp));
        lambdaActionDictionary.AddSimpleAction("pagedown", () => champion.TapKey(WowIntegerKeyboard.PageDown));
        lambdaActionDictionary.AddSimpleAction("oem1", () => champion.TapKey(WowIntegerKeyboard.Oem1));
        lambdaActionDictionary.AddSimpleAction("oem102", () => champion.TapKey(WowIntegerKeyboard.Oem102));
        lambdaActionDictionary.AddSimpleAction("oem2", () => champion.TapKey(WowIntegerKeyboard.Oem2));
        lambdaActionDictionary.AddSimpleAction("oem3", () => champion.TapKey(WowIntegerKeyboard.Oem3));
        lambdaActionDictionary.AddSimpleAction("oem4", () => champion.TapKey(WowIntegerKeyboard.Oem4));
        lambdaActionDictionary.AddSimpleAction("oem5", () => champion.TapKey(WowIntegerKeyboard.Oem5));
        lambdaActionDictionary.AddSimpleAction("oem6", () => champion.TapKey(WowIntegerKeyboard.Oem6));
        lambdaActionDictionary.AddSimpleAction("oem7", () => champion.TapKey(WowIntegerKeyboard.Oem7));
        lambdaActionDictionary.AddSimpleAction("oem8", () => champion.TapKey(WowIntegerKeyboard.Oem8));
        lambdaActionDictionary.AddSimpleAction("oemcomma", () => champion.TapKey(WowIntegerKeyboard.OemComma));
        lambdaActionDictionary.AddSimpleAction("oemminus", () => champion.TapKey(WowIntegerKeyboard.OemMinus));
        lambdaActionDictionary.AddSimpleAction("oemperiod", () => champion.TapKey(WowIntegerKeyboard.OemPeriod));
        lambdaActionDictionary.AddSimpleAction("oemplus", () => champion.TapKey(WowIntegerKeyboard.OemPlus));
        lambdaActionDictionary.AddSimpleAction("dance", () => champion.WriteAlpahNumericalCommand("dance"));
        lambdaActionDictionary.AddSimpleAction("stop", () => champion.StopReleaseKey());
        //tab 1000 p1 1900 p2 1900 p3
        // W 1000 w 1000 X 1000 x



        MessageQueueDelayerTask taskQueue = new MessageQueueDelayerTask();

        taskQueue.AddDequeueListener((command) =>
        {
            Console.WriteLine("Command received"+command);
            lambdaActionDictionary.ExecuteIfExistSimpleAction(command, out bool found);
            if (!found)
            {
                Console.WriteLine("Command not found: " + command);
            }
        });




        Console.WriteLine("Hello, World!");
        while (true) {
            //Thread.Sleep(1000);
            //champion.StartJump();
            //Thread.Sleep(1000);
            //champion.StopJump();
            //Thread.Sleep(1000);


            //ChampionMoveAndRotate.TestMovingInSquare(champion, 3);
            //ChampionMoveAndRotate.TestRotation90And360(champion);


            Console.WriteLine("Next ?");
            string cmd = Console.ReadLine();
            Console.WriteLine("Command received: " + cmd);
            taskQueue.AddMacroAsItemsFromLine(cmd);

            





            //TestOemKey(champions,"Oem1", WowIntegerKeyboard.Oem1);
            //TestOemKey(champions, "Oem102", WowIntegerKeyboard.Oem102);
            //TestOemKey(champions, "Oem2", WowIntegerKeyboard.Oem2);
            //TestOemKey(champions, "Oem3", WowIntegerKeyboard.Oem3);
            //TestOemKey(champions, "Oem4", WowIntegerKeyboard.Oem4);
            //TestOemKey(champions, "Oem5", WowIntegerKeyboard.Oem5);
            //TestOemKey(champions, "Oem6", WowIntegerKeyboard.Oem6);
            //TestOemKey(champions, "Oem7", WowIntegerKeyboard.Oem7);
            //TestOemKey(champions, "Oem8", WowIntegerKeyboard.Oem8);
            //TestOemKey(champions, "OemComma", WowIntegerKeyboard.OemComma);
            //TestOemKey(champions, "OemMinus", WowIntegerKeyboard.OemMinus);
            //TestOemKey(champions, "OemPeriod", WowIntegerKeyboard.OemPeriod);
            //TestOemKey(champions, "OemPlus", WowIntegerKeyboard.OemPlus);







            //champions.WriteAlpahNumericalText("dance");
            //champions.StartJump();
            //Thread.Sleep(1000);
            //champions.StopJump();
            //Thread.Sleep(10000);

            Thread.Sleep(1);
        }

    }
}
