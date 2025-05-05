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


namespace ClientQA.TeacherCode
{

    public partial class TeacherProgram
    {

        

        public static void TeacherMain(string[] args)
        {

            CodePourBougerLesPersonnages();
            //HelloQwertyCode.HelloWowAndQwerty(args);


        }



        public static void CodePourBougerLesPersonnages() {





            // Use the APInt server
            string listernServerUrl = "wss://apint.ddns.net:4725";
            string pushUdpServerUrl = "apint.ddns.net";
            int pushUdpServerPort = 3615;
            int playerIndex = 0;



            UWCMirrorIntToWarcraftChampionsInfo listenToGameInfo = new UWCMirrorIntToWarcraftChampionsInfo();

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
}
