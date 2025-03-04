using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientQA.Toolboxes;

namespace ClientQA.Archive
{
    internal class Archive_2025_03_04_Mardi
    {
        public void Main(string[] args) {
            string macro = " Q 100 q 100 J 500 J 6000";
            string ipv4 = "10.64.22.20";
            ipv4 = "127.0.0.1";
            int port = 7073;
            int playerIndex = 0;
            ChampionThread wow = new ChampionThread(ipv4, port, playerIndex);

            WalkAroundCharacterToolbox.MoveForwardThenRotate(wow, 10, 20);

            wow.TapKey(WowIntegerKeyboard.KeyM);
            wow.PressKey(WowIntegerKeyboard.KeyM);
            wow.ReleaseKey(WowIntegerKeyboard.KeyM);
            while (true)
            {
                Console.WriteLine("Enter a macro:");
                string userMacro = Console.ReadLine().Trim();
                Console.WriteLine("Macro:" + userMacro);
                string[] commands = userMacro.Split(' ');
                Console.WriteLine(commands.Length);


                foreach (string command in commands)
                {
                    Console.WriteLine("Instruction:" + command);
                    if (int.TryParse(command, out int waitTime))
                    {
                        Thread.Sleep(waitTime);
                    }
                    else
                    {
                        switch (command)
                        {
                            case "Pupuce":
                                FlyCharacterToolbox.JumpAndFlap3TimesWingsThenGoDown(wow);
                                break;
                            case "Hover":
                                FlyCharacterToolbox.JumpAndHover(wow);
                                break;
                            case "Q":
                                wow.StartRotateLeft();
                                break;
                            case "q":
                                wow.StopRotateLeft();
                                break;
                            case "J":
                            case "Jump":
                            case "j":
                                wow.TapJump();
                                wow.WaitSomeMilliseconds(200);
                                break;

                            default:

                                Console.WriteLine("Command not recognized");
                                break;
                        }
                    }
                }
            }
        }
    }
}

