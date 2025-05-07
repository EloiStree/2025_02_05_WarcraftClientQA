using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ClientQA.Ninja;
using ClientQA.TeacherCode.CoordinateWow;
using ClientQA.UtilityCode;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Eloi.IID;
using System.Security.Cryptography;
using System.Net.Sockets;
using ClientQA.Toolboxes;
using ClientQA.LearningExample.Basic;
using ClientQA.LearningExample.Core;
using Eloi.Example.Cours;
using ClientQA.Pickup;
using XboxClientQA.UWCMirror;
using Eloi.HelloWorld;
using XboxClientQA.UdpListenerToIID;
using XboxClientQA.WssConnection;
using Eloi.Toolbox;



namespace ClientQA.TeacherCode
{

    public partial class TeacherProgram
    {

        

        public static void TeacherMain(string[] args)
        {

            int rest = 10 % 3;
            Console.WriteLine($"10 % 3 = {rest}");

            int exposant = 10 ^ 5;
            Console.WriteLine($"10 ^ 5 = {exposant}");

            bool  andExample = ((true & true) | (true & false));
            Console.WriteLine($"And = {andExample}");



            while (true)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.WriteLine("Hello World!");
            }

            UnityVector2 start = new UnityVector2(5, 0);
            start.X=5;

            UnityVector2 end = 
                new UnityVector2("654.2", "564");

            Console.WriteLine($"start: {start.X}");


            Console.WriteLine($"Distance: {start.GetDistance()}");
            end.GetDistance(out float distanceEnd);
            Console.WriteLine($"Distance: {distanceEnd}");


            UnityVector2 versDroite = UnityVector2.RIGHT;
            Console.WriteLine($"{versDroite}");





            {

                DestructorExampleForFun a = new DestructorExampleForFun();
                a.SayHello();

            }
            ChampionThread champion = null;
            bool useFormationPC = true;
            if (useFormationPC)
            {
                champion = new ChampionThread("10.32.23.200", 7073, 0 );
            }
            else
            {
                champion = new ChampionThread("127.0.0.1", 7073, 0);
            }

            UnityVector2 move10Forward = new UnityVector2(0, 10);
            UnityVector2 move10Backward = new UnityVector2(0, -10);
            UnityVector2 move10Left = new UnityVector2(-10, 0);
            UnityVector2 move10Right = new UnityVector2(10, 0);


            //Console.WriteLine("Go forward 10 units");
            //MoveChampionTools.TranslateInSeconds(
            //    champion, move10Forward
            //    );
            Console.WriteLine("Go right 10 units");
            MoveChampionTools.TranslateInSeconds(
                champion, move10Right
                );

            Thread.Sleep(10000);
            //Console.WriteLine("Go left 10 units");
            //MoveChampionTools.TranslateInSeconds(
            //    champion, move10Left
            //    );

            //Console.WriteLine("Go backward 10 units");
            //MoveChampionTools.TranslateInSeconds(
            //    champion, move10Backward
            //    );

            //float moveSpeedForwardInAir = 225 / 10;
            //Console.WriteLine("Go forward 10 units");
            //MoveChampionTools.TranslateInDistance(
            //    champion, move10Forward, moveSpeedForwardInAir, moveSpeedForwardInAir
            //    );
            //Console.WriteLine("Go right 10 units");
            //MoveChampionTools.TranslateInDistance(
            //    champion, move10Right, moveSpeedForwardInAir, moveSpeedForwardInAir
            //    );
            //Console.WriteLine("Go left 10 units");
            //MoveChampionTools.TranslateInDistance(
            //    champion, move10Left, moveSpeedForwardInAir, moveSpeedForwardInAir
            //    );



            return;
            //HowToUseUnityVector2.Test(champion);


            //CodePourBougerLesPersonnages();
            //HelloQwertyCode.HelloWowAndQwerty(args);


        }



        public static void CodePourBougerLesPersonnages() {



            


            // Use the APInt server
            string listernServerUrl = "wss://apint.ddns.net:4725";
            string pushUdpServerUrl = "apint.ddns.net";
            int pushUdpServerPort = 3615;
            int playerIndex = 0;



            UWCMirrorIntToWarcraftChampionsInfo listenToGameInfo = 
                new UWCMirrorIntToWarcraftChampionsInfo();

            UDPListenerBytesToIID udpListener = new UDPListenerBytesToIID(6999);
            udpListener.AddBytesReceivedHandler(listenToGameInfo.PushInBytesIID); 

            //WssTrustedWebsocketIIDThread listener = new WssTrustedWebsocketIIDThread(listernServerUrl);
            //listener.AddBytesReceivedHandler(listenToGameInfo.PushInBytesIID);

            ChampionThread champion = new ChampionThread(pushUdpServerUrl, pushUdpServerPort, playerIndex);
            string championId = "1402-0AFC1A03";

            while (true)
            {
                listenToGameInfo.TryToFetchPlayerByID(championId, out bool found, out UWCChampionInfo champ);


                Console.WriteLine("Enter command: ");
                string? input = Console.ReadLine();
                if (input == null)
                {
                    continue;
                }


                string[] words = input.Split(" ");
                foreach (string word in words)
                {

                    switch (word)
                    {

                        case "ids":
                            listenToGameInfo.GetChampionsId(out List<string> ids);
                            Console.WriteLine(string.Join(", ", ids));
                            break;
                        case "champions":

                            listenToGameInfo.GetChampions(out List<UWCChampionInfo> champions);
                            foreach (UWCChampionInfo info in champions)
                            {

                                Console.WriteLine(info.GetMultilineDescription());

                            }
                            break;
                        case "r90":
                            champion.RotationForLeftRightAngle(90);
                            break;
                        case "m20":
                            champion.MoveForDistance(20);
                            break;
                        case "ds20":
                            champion.StartMovingDownwardFor(20);
                            break;
                    }
                }

                // Anti busy loop
                Thread.Sleep(10);
            }
        }
    }


    /// <summary>
    /// For the fun a demonstration of the destructor and constructor and when it is called.
    /// </summary>
    public class DestructorExampleForFun
    {
        static DestructorExampleForFun()
        {
            Console.WriteLine("Static constructor called.");
            AppDomain.CurrentDomain.ProcessExit += OnProcessExit;
        }

        public DestructorExampleForFun()
        {
            Console.WriteLine("Constructor called.");
        }


        public void SayHello()
        {
            Console.WriteLine("Hello from DestructorExampleForFun!");
        }

        ~DestructorExampleForFun()
        {
            Console.WriteLine("Destructor called.");
        }

        private static void OnProcessExit(object? sender, EventArgs e)
        {
            Console.WriteLine("Static destructor called on process exit.");
        }
    }

}


