using System.Globalization;
using XboxClientQA.Pickup;
using XboxClientQA.TDD;

public class Program {



    public static void Main(string[] args) {
        

        
        string address = "127.0.0.1";
        int port = 7073;
        bool useRelay=false;
        if (useRelay) { 
            address= "apint.ddns.net";
            port = 3615;
        }
        ColorPickerRefreshTimer colorPicker = new ColorPickerRefreshTimer(1765, 581, 250, false);
        colorPicker.DipslayPositionInConsole();
        ChampionThread champion = new ChampionThread(address, port, 0);
        ChampionThreadMapping.HideAddCode(champion, colorPicker);
        Console.WriteLine("Let's code:");
        while (true) {
            Console.WriteLine("Next ?");
            string cmd = Console.ReadLine();
            Console.WriteLine("Command received: " + cmd);
            champion.PushItemsMacroToDelayer(cmd);
            Thread.Sleep(1);
        }
    }




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
