using System.Globalization;
using System.Net;
using XboxClientQA.Pickup;
using XboxClientQA.StudentCode;
using XboxClientQA.TDD;

public class Program {
    public static void Main(string[] args)
    {
        StudentProgram.StudentMain(args);

        // Ciblé l'ordinateur
        string address = "127.0.0.1";
        // Ciblé le port ouvert de Scratch2Warcraft
        int port = 7073;
        // Ciblé l'index de la fenêtre de jeu
        int playerIndex = 0;
        ChampionThread champion = new ChampionThread(address, port, playerIndex);

        // AJOUTER VOTRE COE ICI

    }



    public static void TestBasicMove() {

        string address = "127.0.0.1";
        int port = 7073;
        int playerIndex = 0;
        ChampionThread champion = new ChampionThread(address, port, playerIndex);

        //Verify basic code
        champion.TapJump();

        if (false)
        {
            for (int i = 0; i < 10; i++)
            {
                champion.TapPower(i);
                champion.WaitSomeMilliseconds(500);
            }
            for (int i = 1; i <= 5; i++)
            {
                champion.TapF1To12(i);
                champion.WaitSomeMilliseconds(500);
            }
        }

        int timeBetween = 1000;
        int pressTime = 3000;
        if (false)
        {
            champion.StartMovingForwardFor(pressTime);
            champion.WaitSomeMilliseconds(timeBetween);
            champion.StartMovingBackwardFor(pressTime);
            champion.WaitSomeMilliseconds(timeBetween);
            champion.StartStrafeLeftFor(pressTime);
            champion.WaitSomeMilliseconds(timeBetween);
            champion.StartStrafeRightFor(pressTime);
            champion.WaitSomeMilliseconds(timeBetween);
            champion.StartRotateLeftFor(pressTime);
            champion.WaitSomeMilliseconds(timeBetween);
            champion.StartRotateRightFor(pressTime);
            champion.WaitSomeMilliseconds(timeBetween);
        }

        if (true)
        {
            champion.WaitSomeMilliseconds(pressTime);
            champion.MoveForDistance(5);
            champion.WaitSomeMilliseconds(pressTime);
            champion.MoveForDistance(-5);
            champion.WaitSomeMilliseconds(pressTime);
            champion.StrafeMove(5);
            champion.WaitSomeMilliseconds(pressTime);
            champion.StrafeMove(-5);
            champion.WaitSomeMilliseconds(pressTime);
            champion.RotationForLeftRightAngle(90);
            champion.WaitSomeMilliseconds(pressTime);
            champion.RotationForLeftRightAngle(-90);
            champion.WaitSomeMilliseconds(pressTime);
            champion.PitchBotToTopAngle(90);
            champion.WaitSomeMilliseconds(pressTime);
            champion.PitchBotToTopAngle(-90);

        }


    }


    public static void FullExample() {

        string address = "127.0.0.1";
        int port = 7073;
        bool useRelay = false;
        if (useRelay)
        {
            address = "apint.ddns.net";
            port = 3615;
        }
        ColorPickerRefreshTimer colorPicker = new ColorPickerRefreshTimer(1765, 581, 250, false);
        colorPicker.DipslayPositionInConsole();
        ChampionThread champion = new ChampionThread(address, port, 0);
        ChampionThreadMapping.HideAddCode(champion, colorPicker);
        Console.WriteLine("Let's code:");
        while (true)
        {
            Console.WriteLine("Next ?");
            string cmd = Console.ReadLine();
            Console.WriteLine("Command received: " + cmd);
            champion.PushItemsMacroToDelayer(cmd);
            Thread.Sleep(1);
        }
    }





    /// <summary>
    /// Static constructor to initialize the program.   
    /// </summary>
    static Program()
    {
        Console.WriteLine("Hello, World of Warcraft !");
        // To avoid bug due to French ponctuation.
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;
        AppDomain.CurrentDomain.ProcessExit +=
            StaticDestructorKindOf;
    }
   

    static void StaticDestructorKindOf(object sender, EventArgs e)
    {
        Console.WriteLine("Goodbye, World of Warcraft !");
    }
}
