




using ClientQA.Pickup;

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
        champion.RegisterAction("dance", () => champion.WriteAlphaNumericalCommand("dance"));
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
                    champion.RotationForLeftRightAngle(degree);
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
                    champion.PitchBotToTopAngle(distance);
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
    public static void HideAddCode(ChampionThread champion)
    {
        ChampionThreadMapping.LoadDefaultKeyToAction(champion);
        ChampionThreadMapping.AddInterpreterRMSP(champion);
    }
}