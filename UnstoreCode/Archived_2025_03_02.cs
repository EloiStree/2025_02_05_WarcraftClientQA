using ClientQA.LearningExample.Basic;
using System.Numerics;
using ClientQA.Pickup;
using ClientQA.TeacherCode.CoordinateWow;
using ClientQA.TeacherCode;
using Eloi.Example.Cours;


public class Archived_2025_05_01
{
    public void Save() {

    //     /// <summary>
    //     /// Cela cible tout les champions sur la mahcine local via ScratchToWarcraft:
    //     /// https://github.com/EloiStree/2024_08_29_ScratchToWarcraft
    //     /// 
    //     /// </summary>
    //    public static ChampionThread allChampions = new ChampionThread("127.0.0.1", 7073, 0);

    //// Change the index with your champion index
    //public static ChampionThread yourChampion = new ChampionThread("127.0.0.1", 7073, 1);

    //// Change the index with the correct index
    //public static ChampionThread healer = new ChampionThread("127.0.0.1", 7073, 1);
    //public static ChampionThread tank = new ChampionThread("127.0.0.1", 7073, 2);
    //public static ChampionThread hunter = new ChampionThread("127.0.0.1", 7073, 3);
    //public static ChampionThread mage = new ChampionThread("127.0.0.1", 7073, 4);
    //public static ChampionThread demonist = new ChampionThread("127.0.0.1", 7073, 5);

    //public static void TeacherMain(params string[] args)
    //{


    //    //ChampionThread monChampion = new ChampionThread("127.0.0.1", 7073, 0);




    //    //while(true)
    //    //{
    //    //    var exercice = new ExerciceSolution_AskPlayerWhereToGo();
    //    //    exercice.Run(monChampion);
    //    //    Thread.Sleep(1000);

    //    //    Thread.Sleep(100);
    //    //}


    //    TDD_WowWorldPositionToAngle.TestAll();
    //    ChampionThread champion = new ChampionThread("127.0.0.1", 7073, 0);

    //    bool checkColorPosition = false;
    //    if (checkColorPosition)
    //    {
    //        for (int i = 0; i < 4; i++)
    //        {
    //            Console.WriteLine("Move Mouse to position " + i);
    //            Thread.Sleep(4000);
    //            ScreenPixelColorPicker.GetCursorPosition(out int x, out int y);
    //            Console.WriteLine($"Mouse X {x} Y {y}");
    //        }
    //    }




    //    Vector2 colorAngle = new Vector2(1913, 219);
    //    Vector2 colorX = new Vector2(1913, 338);
    //    Vector2 colorY = new Vector2(1913, 594);
    //    Vector2 colorLifeXp = new Vector2(1913, 860);

    //    while (true)
    //    {

    //        Console.WriteLine("Macro:");
    //        string text = Console.ReadLine();

    //        ScreenPixelColorPicker.GetLockedPixelColor((int)colorAngle.X, (int)colorAngle.Y, out int ra, out int ga, out int ba);
    //        ScreenPixelColorPicker.GetLockedPixelColor((int)colorX.X, (int)colorX.Y, out int rx, out int gx, out int bx);
    //        ScreenPixelColorPicker.GetLockedPixelColor((int)colorY.X, (int)colorY.Y, out int ry, out int gy, out int by);
    //        ScreenPixelColorPicker.GetLockedPixelColor((int)colorLifeXp.X, (int)colorLifeXp.Y, out int rl, out int gl, out int bl);


    //        Console.WriteLine($"Rx{ra} Gx{ga} Bx{ba}");
    //        Console.WriteLine($"Rx{rx} Gx{gx} Bx{bx}");
    //        Console.WriteLine($"Ry{ry} Gy{gy} By{by}");
    //        Console.WriteLine($"Ry{rl} Gy{gl} By{bl}");
    //        PixelColor32 x32 = new PixelColor32(rx, gx, bx);
    //        PixelColor32 y32 = new PixelColor32(ry, gy, by);
    //        PixelColor32 a32 = new PixelColor32(ra, ga, ba);
    //        PixelColor32 l32 = new PixelColor32(rl, gl, bl);


    //        ConvertPixelToDataUtility.ConvertPixelToIntValue(x32, out int worldPositionX);
    //        ConvertPixelToDataUtility.ConvertPixelToIntValue(y32, out int worldPositionY);
    //        ConvertPixelToDataUtility.ConvertPixelToMap2D(a32, out float mapx, out float mapy, out float angle);
    //        ConvertPixelToDataUtility.ConvertPixelToLifeXpLevel(l32, out float percentLife, out float percentXp, out int playerLevel);



    //        Console.WriteLine($"X{worldPositionX} Y{worldPositionY}");
    //        Console.WriteLine($"MX{mapx} MY{mapy} Angle{angle}");



    //        WowWorldPosition position = new WowWorldPosition(worldPositionX, worldPositionY);
    //        WowWorldPosition whereToGo = null;

    //        // Fire at start
    //        whereToGo = new WowWorldPosition(-115, -8769);
    //        // Gate
    //        whereToGo = new WowWorldPosition(-97.9, -9051.1);
    //        // rock
    //        whereToGo = new WowWorldPosition(-2555, -377);

    //        WowWorldPositionUtility.ComputeWowAngleFrom(position, whereToGo, out float angleDirection);
    //        WowWorldPositionUtility.ComputeDistance(position, whereToGo, out double distanceInWorldPosition);

    //        Console.WriteLine($"Player Angle {angle} Direction {angleDirection}");

    //        if (text == "r")
    //        {
    //            champion.RotateToAngle(angle, angleDirection);
    //            champion.MoveForDistance((float)distanceInWorldPosition);
    //        }

    //        else if (text == "goto")
    //        {
    //            ConsoleWowCoord.MoveBetweenTwoWorldPoints(champion);

    //        }
    //        //CA MARCHE :)
    //        Console.Write($"Player xp {percentXp}  life {percentLife}  level {playerLevel}");


    //    }







    //    System.Environment.Exit(1);

    //    new ExChamp_Topic_MethodEtParametre().Run(allChampions);
    //    // C'est quoi une variable primitive ?
    //    new ExChamp_Keyword_VariablePrimitive().Run(allChampions);

    //    // C'est quoi un tableau d'entier ?
    //    new ExChamp_Topic_IntegerArrayAndloop().Run(allChampions);

    //    // Si l'on peut faire de macro avec des tableau entier ?
    //    // On peut faire des tableaus avec des textes via des chars ?
    //    new ExChamp_Topic_MacroOfCharsWithSwitchAndIf().Run(allChampions);

    //    // StartWith et IndexOf sont très utile pour les macros
    //    new ExChamp_Topic_StringStartWithAndIndexOf().Run(allChampions);



    //    // C'est quoi un variable ?
    //    // - [ ] C'est quoi des variables primitives ?

    //    // - [ ] Entier: bit, bytes, short, ushort, int, uint, long, ulong ?
    //    // - [ ] Ajouter une valeur à un variable ?
    //    // - [ ] Retirer une valeur à une variable ?
    //    // - [ ] C'est quoi ça '++' ?
    //    // - [ ] C'est quoi ça '--' ?
    //    // - [ ] C'est quoi ça '-=' ?
    //    // - [ ] C'est quoi ça '+=' ?
    //    // - [ ] Comment on multiplie une valeur ?
    //    // - [ ] Comment on divise une valeur ?
    //    // - [ ] C'est quoi ça '*=' ?
    //    // - [ ] C'est quoi ça '/=' ?
    //    // - [ ] C'est quoil a priorité des opérateurse et les ( () + () ) ?

    //    // - [ ] C'est quoi un casting implicite long a = 42 ?
    //    // - [ ] C'est quoi un casting explicite (int) variable ?


    //    // - [ ] Nombre à virgule: float, double ?
    //    // - [ ] C'est quoi un booléan ?  
    //    // - [ ] C'est quoi ça '==' ?  
    //    // - [ ] C'est quoi ça '&&' ?  
    //    // - [ ] C'est quoi ça '||' ?

    //    // C'est quoi un méthode
    //    // - [ ] Une méthode sans argument et sans retour ?
    //    // - [ ] Une méthode avec des arguments sans retour ?
    //    // - [ ] Une méthode avec des arguments qui retourne une valeur ?
    //    // - [ ] C'est quoi un paramètre par défault?
    //    // - [ ] C'est quoi le mot clé params ?
    //    // - [ ] C'est quoi c'est quoi un/des out ?


    //    // - C'est quoi un char et un string ?
    //    // - C'est quoi un string ?
    //    // - C'est quoi un tableau de char ?
    //    // - C'est quoi un char: ASCII, UNICODE ?

    //    // c'est quoi un réference ?
    //    new ExChamp_Keyword_ref().Run(allChampions);

    //}
    }
}

public class Archived_2025_03_02 {


    public void Save() {



        //// V 1.2.45j5

        //string address = "127.0.0.1";
        //address = "apint.ddns.net";
        //int port = 3615;
        //address = "192.168.1.25";
        //port = 7073;

        ////address = "10.64.22.20";
        //ChampionThread champion = new ChampionThread(address, port, 0);


        //ChampionThreadMapping.HideAddCode(champion);

        //Console.WriteLine("Let's code:");
        //while (true)
        //{
        //    Console.WriteLine("Next ?");
        //    string cmd = Console.ReadLine();
        //    Console.WriteLine("Command received: " + cmd);
        //    champion.PushItemsMacroToDelayer(cmd);
        //    Thread.Sleep(1);
        //}

        // Console.WriteLine("I am here");
        //// champion.Ping();

        // while (true) {

        //     Console.WriteLine("Next ?");
        //     string command = Console.ReadLine();
        //     string[] items = command.Split(" ");
        //     foreach (string item in items) { 

        //         Console.WriteLine("Process: "+item);

        //         // IF ELSE IF
        //         if (item == "ping")
        //         {
        //             champion.Ping();
        //         }
        //         // SWITCH
        //         switch (item)
        //         {
        //             case "attack":
        //             case "a":
        //                 champion.TapPower1();
        //                 break;
        //             case "interagir":
        //             case "f":
        //                 champion.TapInteract();
        //                 break;
        //             case "jump":
        //             case "j":
        //                 champion.TapJump();
        //                 break;

        //             case "bonjour":
        //                 champion.WriteAlpahNumericalTextChat("Bonjour");
        //                 break;
        //         }
        //         // DICTIONNAIRE

        //     }
        // }

        //////////////: DICTIONNAIRE
        //Dictionary<string, string> studentRegion 
        //    = new Dictionary<string, string>();

        //studentRegion.Add("Eloi", "Liège");
        //studentRegion.Add("Remy", "Tournai");
        //studentRegion.Add("Guillaume", "Ghlin");
        //studentRegion.Add("Youri", "Jurbise");

        //Dictionary<string, int> studentRegionCodePostal
        //    = new Dictionary<string, int>();
        //studentRegionCodePostal.Add("Eloi", 4190);

        //Dictionary<string, WowCoord> dico_townNameToCoord
        //    = new Dictionary<string, WowCoord>();
        //dico_townNameToCoord.Add("Storwind", new WowCoord(20, 45, 0));
        //dico_townNameToCoord.Add("Elywn", new WowCoord(3, 5, 0));
        //dico_townNameToCoord.Add("Lac Bleu", new WowCoord(10, 15, 0));
        //dico_townNameToCoord.Add("Mine Rouge", new WowCoord(20, 45, 0));

        //if (! dico_townNameToCoord.ContainsKey("Storwind"))
        //    dico_townNameToCoord.Add("Storwind", new WowCoord(20, 45, 0));
        //else dico_townNameToCoord["Storwind"] = new WowCoord(20, 45, 0);


        //WowCoord mapPosition = dico_townNameToCoord["blabla"];
        //Console.WriteLine("Map Position:"+mapPosition);


        //List < string > townsInDico = dico_townNameToCoord.Keys.ToList();
        //foreach (string key in townsInDico) {

        //    //if (dico_townNameToCoord.ContainsKey(key)) 
        //    { 
        //        Console.WriteLine(key + ":" + dico_townNameToCoord[key]);
        //    }
        //}

        //////////////////////// ACTION
        ///

        //Action sauter = () =>
        //{
        //    Console.WriteLine("Saute");
        //};
        //sauter.Invoke();
        //sauter.Invoke();
        //sauter.Invoke();

        ////LAMBDA 
        //Action demo = () => { };
        //Action<int> demoAvecInt = (unEntier) =>
        //{
        //    Console.WriteLine(unEntier);
        //};
        //demoAvecInt.Invoke(3);
        //demoAvecInt.Invoke(5);
        //demoAvecInt = champion.WaitSomeMilliseconds;
        //demoAvecInt.Invoke(4000);

        //Action sauterLeChampion =
        //    () =>
        //    {
        //        champion.PressReleaseWithDelayForSeconds(WowIntegerKeyboard.Space, 0, 0);
        //    };
        //sauterLeChampion.Invoke();

        //sauterLeChampion = champion.TapJump;
        //sauterLeChampion.Invoke();
        //sauterLeChampion.Invoke();
        //champion.TapJump();


        //Action attaquePowerToUse = null;

        ///// Aggro the premier mob
        //attaquePowerToUse = champion.TapPower1;

        ///// Conter the next speel
        //attaquePowerToUse = champion.TapPower5;

        ///// Final death kill
        //attaquePowerToUse = champion.TapPower9;

        //Action jump = champion.TapJump;

        //Dictionary<string, Action> keyMapping = new Dictionary<string, Action>();
        //keyMapping.Add("JUMP", jump);
        //keyMapping.Add("MAP", champion.TapMap);
        //keyMapping.Add("LEFT", champion.StartRotateLeft);
        //keyMapping.Add("left", champion.StopRotateLeft);




        //if (keyMapping.ContainsKey("JUMP")) {
        //    keyMapping["JUMP"].Invoke();
        //}









        // float xLeftRightRatioOfMap = 4f / 50f;//percent meter
        // float yTopBottomRatioOfMap = 4.2f / 50f;//percent meter

        //WowCoord center = new WowCoord(50, 50, 0);
        //WowCoord top = new WowCoord(50, 0, 0);
        //WowCoord topLeft = new WowCoord(0, 0, 0);
        //WowCoord left = new WowCoord(0, 50, 0);
        //WowCoord bottomLeft = new WowCoord(0, 100, 0);
        //WowCoord bottom = new WowCoord(50, 100, 0);
        //WowCoord bottomRight = new WowCoord(100, 100, 0);
        //WowCoord right = new WowCoord(100, 50, 0);
        //WowCoord topRight = new WowCoord(100, 0, 0);


        //center.GetCountClockwiseAngle(top, out float angleCenter);
        //WowCoord.GetCountClockwiseAngle(center, top, out float angleTop);
        //WowCoord.GetCountClockwiseAngle(center, topLeft, out float angleTopLeft);
        //WowCoord.GetCountClockwiseAngle(center, left, out float angleLeft);
        //WowCoord.GetCountClockwiseAngle(center, bottomLeft, out float angleBottomLeft);
        //WowCoord.GetCountClockwiseAngle(center, bottom, out float angleBottom);
        //WowCoord.GetCountClockwiseAngle(center, bottomRight, out float angleBottomRight);
        //WowCoord.GetCountClockwiseAngle(center, right, out float angleRight);
        //WowCoord.GetCountClockwiseAngle(center, topRight, out float angleTopRight);



        //Print("Angle Top: " + angleTop);
        //Print("Angle Top Left: " + angleTopLeft);
        //Print("Angle Left: " + angleLeft);
        //Print("Angle Bottom Left: " + angleBottomLeft);
        //Print("Angle Bottom: " + angleBottom);
        //Print("Angle Bottom Right: " + angleBottomRight);
        //Print("Angle Right: " + angleRight);
        //Print("Angle Top Right: " + angleTopRight);


        //// champion.MoveForDistance(50);

        // while (true) { 
        //     ConsoleWowCoord.AskForDirectionInfo(
        //     out WowCoord origin,
        //     out WowCoord target,
        //     out float distance,
        //     out bool isLeftDirection,
        //     out float angleToRotate,
        //     out float rotationTime);

        //     if (isLeftDirection) 
        //         champion.RotationToLeftAngle(angleToRotate);
        //     else
        //         champion.RotationToRightAngle(angleToRotate);

        //     bool useFly = false;
        //     if (useFly)
        //     {
        //         Thread.Sleep(100);
        //         champion.TapMS(WowIntegerKeyboard.Alpha0, 1000);
        //         Thread.Sleep(100);
        //     }
        //     else {

        //         champion.MoveForDistance( distance/ (4f/50f) );
        //     }

        // }





        // WowCoord player = new WowCoord(43, 16, 0);
        // WowCoord target = new WowCoord(80, 35, 0);

        //bool isRight= player.IsAtRight(target);

        // isRight= WowCoord.IsAtRight(
        //     player, 
        //     target);

        //float currentAngle = 320;
        //float targetAngle = 150;

        //WowSetToDirectionAngle.GetTimeToRotateFromTo(currentAngle, targetAngle, out bool goLeft, out float angleToRotate);


        //Console.WriteLine("Go left: " + goLeft + " Angle to rotate: " + angleToRotate);
        //if (goLeft)
        //    angleToRotate = -angleToRotate;
        //champion.RotationForLeftRightAngle(angleToRotate);

        //WowCoord d = new WowCoord(69,43,60);


        //d.GetAngleCounterClockwise360(out float angle);
        //Print("Angle: " + angle);

        //Print("Test"+ d.GetAngleCounterClockwise360());

        //d.Angle = 60;
        //Print("Get a la c# " + d.Angle);


        //bool isRight = d.IsAngleBetween
        //    (d.Angle, 300, 200);
        //Print("Is right: " + isRight);







        ////champion.TapKey(WowIntegerKeyboard.Tab);
        ////champion.TapKey(WowIntegerKeyboard.KeyF);


        //Console.WriteLine("Hello World");
        //while (true)
        //{
        //    Console.WriteLine("Enter a command:");
        //    string command = Console.ReadLine();
        //    Console.WriteLine("You entered: " + command);
        //    string[] items =command.Split(' ');
        //    for (int i = 0; i < items.Length; i=i+1) {

        //        Console.WriteLine("Item " + i + " is " + items[i]);
        //        if (int.TryParse(items[i], out int value))
        //        {

        //            Console.WriteLine("This is a \n \r number");
        //            Thread.Sleep(value);
        //        }
        //        else if (items[i] == "ping") {
        //            for (int j = 0; j < 10; j++)
        //            {
        //                champion.TapKey(WowIntegerKeyboard.Jump);
        //                champion.WaitSomeMilliseconds(500);
        //            }

        //        }
        //        else if (items[i] == "L")
        //        {
        //            champion.StartRotateLeft();
        //            Console.WriteLine("Press Left");
        //        }
        //        else if (items[i] == "l")
        //        {
        //            champion.StopRotateLeft();
        //            Console.WriteLine("Release Left");
        //        }
        //        else if (items[i] == "J")
        //        {
        //            champion.StartJump();
        //            Console.WriteLine("Press Jump");
        //        }
        //        else if (items[i] == "j")
        //        {
        //            champion.StopJump();
        //            Console.WriteLine("Release jump");
        //        }
        //    }
        //    Thread.Sleep(1000);

        //}



        //////////////////////////////////////////



        //// Ciblé l'ordinateur
        //string address = "127.0.0.1";
        //// Ciblé le port ouvert de Scratch2Warcraft
        //int port = 7073;
        //// Ciblé l'index de la fenêtre de jeu
        //int playerIndex = 0;
        //ChampionThread champion = new ChampionThread(address, port, playerIndex);

        //float percentMapXPerSeconds = 0.2f;
        //float percentMapYPerSeconds = 0.1f;
        //float averageSpeedPerSeconds = (percentMapXPerSeconds + percentMapYPerSeconds) / 2f;


        ////champion.StartMovingForwardFor(5.0f);
        ////while (true) { 

        ////}

        //ColorPickerRefreshTimer position = new ColorPickerRefreshTimer(0, 0, 200, false);
        //position.AskToMoveMouseWithConsoleToColor();






        //champion.TapJump();
        //champion.WaitTwoSeconds();


        //while (true)
        //{

        //    for (int i = 0; i < 4; i = i + 1)
        //    {
        //        position.GetPosition(out float x, out float y, out float angle);
        //        Console.WriteLine($"From X:{x} , Y:{y} , A:{angle}");

        //        float wantedAngle = 0;
        //        if (i == 0)
        //            wantedAngle = 0;
        //        else if (i == 1)
        //            wantedAngle = 90;
        //        else if (i == 2)
        //            wantedAngle = 180;
        //        else if (i == 3)
        //            wantedAngle = 270;
        //        //else wantedAngle = 45;


        //        champion.RotateToAngle(angle, wantedAngle);
        //        champion.StartMovingForwardFor(1.5f);



        //        position.GetPosition(out x, out y, out angle);
        //        Console.WriteLine($"To X:{x} , Y:{y} , A:{angle}");
        //        champion.WaitTwoSeconds();

        //        //// IF ELSE IF
        //        //if (item == "ping")
        //        //{
        //        //    champion.Ping();
        //        //}
        //        //// SWITCH
        //        //switch (item)
        //        //{
        //        //    case "attack":
        //        //    case "a":
        //        //        champion.TapPower1();
        //        //        break;
        //        //    case "interagir":
        //        //    case "f":
        //        //        champion.TapInteract();
        //        //        break;
        //        //    case "jump":
        //        //    case "j":
        //        //        champion.TapJump();
        //        //        break;

        //        //    case "bonjour":
        //        //        champion.WriteAlpahNumericalTextChat("Bonjour");
        //        //        break;
        //        //}

        //    }
        //    Thread.Sleep(1);
        //}







        // // V 1.2.45j5

        // string address = "127.0.0.1";
        // address = "apint.ddns.net";

        // //address = "10.64.22.20";
        // ChampionThread champion = new ChampionThread(address, 3615, 0);

        // Console.WriteLine("I am here");
        //// champion.Ping();

        // while (true) {

        //     Console.WriteLine("Next ?");
        //     string command = Console.ReadLine();
        //     string[] items = command.Split(" ");
        //     foreach (string item in items) { 

        //         Console.WriteLine("Process: "+item);

        //         // IF ELSE IF
        //         if (item == "ping")
        //         {
        //             champion.Ping();
        //         }
        //         // SWITCH
        //         switch (item) {
        //             case "attack": 
        //             case "a":
        //                 champion.TapPower1();
        //                 break;
        //         }
        //         // DICTIONNAIRE

        //     }
        // }

        // //////////////: DICTIONNAIRE
        // //Dictionary<string, string> studentRegion 
        // //    = new Dictionary<string, string>();

        // //studentRegion.Add("Eloi", "Liège");
        // //studentRegion.Add("Remy", "Tournai");
        // //studentRegion.Add("Guillaume", "Ghlin");
        // //studentRegion.Add("Youri", "Jurbise");

        // //Dictionary<string, int> studentRegionCodePostal
        // //    = new Dictionary<string, int>();
        // //studentRegionCodePostal.Add("Eloi", 4190);

        // //Dictionary<string, WowCoord> dico_townNameToCoord
        // //    = new Dictionary<string, WowCoord>();
        // //dico_townNameToCoord.Add("Storwind", new WowCoord(20, 45, 0));
        // //dico_townNameToCoord.Add("Elywn", new WowCoord(3, 5, 0));
        // //dico_townNameToCoord.Add("Lac Bleu", new WowCoord(10, 15, 0));
        // //dico_townNameToCoord.Add("Mine Rouge", new WowCoord(20, 45, 0));

        // //if (! dico_townNameToCoord.ContainsKey("Storwind"))
        // //    dico_townNameToCoord.Add("Storwind", new WowCoord(20, 45, 0));
        // //else dico_townNameToCoord["Storwind"] = new WowCoord(20, 45, 0);


        // //WowCoord mapPosition = dico_townNameToCoord["blabla"];
        // //Console.WriteLine("Map Position:"+mapPosition);


        // //List < string > townsInDico = dico_townNameToCoord.Keys.ToList();
        // //foreach (string key in townsInDico) {

        // //    //if (dico_townNameToCoord.ContainsKey(key)) 
        // //    { 
        // //        Console.WriteLine(key + ":" + dico_townNameToCoord[key]);
        // //    }
        // //}

        // //////////////////////// ACTION
        // ///

        // Action sauter = () =>
        // {
        //     Console.WriteLine("Saute");
        // };
        // sauter.Invoke();
        // sauter.Invoke();
        // sauter.Invoke();

        // //LAMBDA 
        // Action demo = () => { };
        // Action<int> demoAvecInt = (unEntier) =>
        // {
        //     Console.WriteLine(unEntier);
        // };
        // demoAvecInt.Invoke(3);
        // demoAvecInt.Invoke(5);
        // demoAvecInt = champion.WaitSomeMilliseconds;
        // demoAvecInt.Invoke(4000);

        // Action sauterLeChampion =
        //     () =>
        //     {
        //         champion.PressReleaseWithDelayForSeconds(WowIntegerKeyboard.Space, 0, 0);
        //     };
        // sauterLeChampion.Invoke();

        // sauterLeChampion = champion.TapJump;
        // sauterLeChampion.Invoke();
        // sauterLeChampion.Invoke();
        // champion.TapJump();


        // Action attaquePowerToUse = null;

        // /// Aggro the premier mob
        // attaquePowerToUse = champion.TapPower1;

        // /// Conter the next speel
        // attaquePowerToUse = champion.TapPower5;

        // /// Final death kill
        // attaquePowerToUse = champion.TapPower9;

        // Action jump = champion.TapJump;

        // Dictionary<string, Action> keyMapping = new Dictionary<string, Action>();
        // keyMapping.Add("JUMP", jump);
        // keyMapping.Add("MAP", champion.TapMap);
        // keyMapping.Add("LEFT", champion.StartRotateLeft);
        // keyMapping.Add("left", champion.StopRotateLeft);




        // if (keyMapping.ContainsKey("JUMP")) {
        //     keyMapping["JUMP"].Invoke();
        // }









        // // float xLeftRightRatioOfMap = 4f / 50f;//percent meter
        // // float yTopBottomRatioOfMap = 4.2f / 50f;//percent meter

        // //WowCoord center = new WowCoord(50, 50, 0);
        // //WowCoord top = new WowCoord(50, 0, 0);
        // //WowCoord topLeft = new WowCoord(0, 0, 0);
        // //WowCoord left = new WowCoord(0, 50, 0);
        // //WowCoord bottomLeft = new WowCoord(0, 100, 0);
        // //WowCoord bottom = new WowCoord(50, 100, 0);
        // //WowCoord bottomRight = new WowCoord(100, 100, 0);
        // //WowCoord right = new WowCoord(100, 50, 0);
        // //WowCoord topRight = new WowCoord(100, 0, 0);


        // //center.GetCountClockwiseAngle(top, out float angleCenter);
        // //WowCoord.GetCountClockwiseAngle(center, top, out float angleTop);
        // //WowCoord.GetCountClockwiseAngle(center, topLeft, out float angleTopLeft);
        // //WowCoord.GetCountClockwiseAngle(center, left, out float angleLeft);
        // //WowCoord.GetCountClockwiseAngle(center, bottomLeft, out float angleBottomLeft);
        // //WowCoord.GetCountClockwiseAngle(center, bottom, out float angleBottom);
        // //WowCoord.GetCountClockwiseAngle(center, bottomRight, out float angleBottomRight);
        // //WowCoord.GetCountClockwiseAngle(center, right, out float angleRight);
        // //WowCoord.GetCountClockwiseAngle(center, topRight, out float angleTopRight);



        // //Print("Angle Top: " + angleTop);
        // //Print("Angle Top Left: " + angleTopLeft);
        // //Print("Angle Left: " + angleLeft);
        // //Print("Angle Bottom Left: " + angleBottomLeft);
        // //Print("Angle Bottom: " + angleBottom);
        // //Print("Angle Bottom Right: " + angleBottomRight);
        // //Print("Angle Right: " + angleRight);
        // //Print("Angle Top Right: " + angleTopRight);


        // //// champion.MoveForDistance(50);

        // // while (true) { 
        // //     ConsoleWowCoord.AskForDirectionInfo(
        // //     out WowCoord origin,
        // //     out WowCoord target,
        // //     out float distance,
        // //     out bool isLeftDirection,
        // //     out float angleToRotate,
        // //     out float rotationTime);

        // //     if (isLeftDirection) 
        // //         champion.RotationToLeftAngle(angleToRotate);
        // //     else
        // //         champion.RotationToRightAngle(angleToRotate);

        // //     bool useFly = false;
        // //     if (useFly)
        // //     {
        // //         Thread.Sleep(100);
        // //         champion.TapMS(WowIntegerKeyboard.Alpha0, 1000);
        // //         Thread.Sleep(100);
        // //     }
        // //     else {

        // //         champion.MoveForDistance( distance/ (4f/50f) );
        // //     }

        // // }





        // // WowCoord player = new WowCoord(43, 16, 0);
        // // WowCoord target = new WowCoord(80, 35, 0);

        // //bool isRight= player.IsAtRight(target);

        // // isRight= WowCoord.IsAtRight(
        // //     player, 
        // //     target);

        // //float currentAngle = 320;
        // //float targetAngle = 150;

        // //WowSetToDirectionAngle.GetTimeToRotateFromTo(currentAngle, targetAngle, out bool goLeft, out float angleToRotate);


        // //Console.WriteLine("Go left: " + goLeft + " Angle to rotate: " + angleToRotate);
        // //if (goLeft)
        // //    angleToRotate = -angleToRotate;
        // //champion.RotationForLeftRightAngle(angleToRotate);

        // //WowCoord d = new WowCoord(69,43,60);


        // //d.GetAngleCounterClockwise360(out float angle);
        // //Print("Angle: " + angle);

        // //Print("Test"+ d.GetAngleCounterClockwise360());

        // //d.Angle = 60;
        // //Print("Get a la c# " + d.Angle);


        // //bool isRight = d.IsAngleBetween
        // //    (d.Angle, 300, 200);
        // //Print("Is right: " + isRight);







        // ////champion.TapKey(WowIntegerKeyboard.Tab);
        // ////champion.TapKey(WowIntegerKeyboard.KeyF);


        // //Console.WriteLine("Hello World");
        // //while (true)
        // //{
        // //    Console.WriteLine("Enter a command:");
        // //    string command = Console.ReadLine();
        // //    Console.WriteLine("You entered: " + command);
        // //    string[] items =command.Split(' ');
        // //    for (int i = 0; i < items.Length; i=i+1) {

        // //        Console.WriteLine("Item " + i + " is " + items[i]);
        // //        if (int.TryParse(items[i], out int value))
        // //        {

        // //            Console.WriteLine("This is a \n \r number");
        // //            Thread.Sleep(value);
        // //        }
        // //        else if (items[i] == "ping") {
        // //            for (int j = 0; j < 10; j++)
        // //            {
        // //                champion.TapKey(WowIntegerKeyboard.Jump);
        // //                champion.WaitSomeMilliseconds(500);
        // //            }

        // //        }
        // //        else if (items[i] == "L")
        // //        {
        // //            champion.StartRotateLeft();
        // //            Console.WriteLine("Press Left");
        // //        }
        // //        else if (items[i] == "l")
        // //        {
        // //            champion.StopRotateLeft();
        // //            Console.WriteLine("Release Left");
        // //        }
        // //        else if (items[i] == "J")
        // //        {
        // //            champion.StartJump();
        // //            Console.WriteLine("Press Jump");
        // //        }
        // //        else if (items[i] == "j")
        // //        {
        // //            champion.StopJump();
        // //            Console.WriteLine("Release jump");
        // //        }
        // //    }
        // //    Thread.Sleep(1000);

        // //}



    }


}
