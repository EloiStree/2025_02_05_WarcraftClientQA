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
using ClientQA.LearningExample.Basic;
using ClientQA.Pickup;

namespace ClientQA.TeacherCode
{
    public partial class TeacherProgram
    {

        /// <summary>
        /// Cela cible tout les champions sur la mahcine local via ScratchToWarcraft:
        /// https://github.com/EloiStree/2024_08_29_ScratchToWarcraft
        /// 
        /// </summary>
        public static ChampionThread allChampions =new ChampionThread("127.0.0.1", 7073, 0);

        // Change the index with your champion index
        public static ChampionThread yourChampion = new ChampionThread("127.0.0.1", 7073, 1);

        // Change the index with the correct index
        public static ChampionThread healer = new ChampionThread("127.0.0.1", 7073, 1);
        public static ChampionThread tank = new ChampionThread("127.0.0.1", 7073, 2);
        public static ChampionThread hunter = new ChampionThread("127.0.0.1", 7073, 3);
        public static ChampionThread mage = new ChampionThread("127.0.0.1", 7073, 4);
        public static ChampionThread demonist = new ChampionThread("127.0.0.1", 7073, 5);

        public static void TeacherMain(params string[] args)
        {


            TDD_WowWorldPositionToAngle.TestAll();
            ChampionThread champion = new ChampionThread("127.0.0.1", 7073, 0);
          
            bool checkColorPosition = false;
            if (checkColorPosition) { 
                for(int i=0; i < 4; i++)
                {
                    Console.WriteLine("Move Mouse to position "+ i);
                    Thread.Sleep(4000);
                    ScreenPixelColorPicker.GetCursorPosition(out int x, out int y);
                    Console.WriteLine($"Mouse X {x} Y {y}");
                }
            }

            


            Vector2 colorAngle = new Vector2(1908, 120);
            Vector2 colorX = new Vector2(1908, 220);
            Vector2 colorY = new Vector2(1908, 374);
            Vector2 colorLifeXp = new Vector2(1908, 525);

            while (true) {

                Console.WriteLine("Macro:");
                string text = Console.ReadLine();

                ScreenPixelColorPicker.GetLockedPixelColor((int)colorAngle.X, (int)colorAngle.Y, out int ra, out int ga, out int ba);
                ScreenPixelColorPicker.GetLockedPixelColor((int)colorX.X, (int)colorX.Y, out int rx, out int gx, out int bx);
                ScreenPixelColorPicker.GetLockedPixelColor((int)colorY.X, (int)colorY.Y, out int ry, out int gy, out int by);
                ScreenPixelColorPicker.GetLockedPixelColor((int)colorLifeXp.X, (int)colorLifeXp.Y, out int rl, out int gl, out int bl);


                Console.WriteLine($"Rx{ra} Gx{ga} Bx{ba}");
                Console.WriteLine($"Rx{rx} Gx{gx} Bx{bx}");
                Console.WriteLine($"Ry{ry} Gy{gy} By{by}");
                Console.WriteLine($"Ry{rl} Gy{gl} By{bl}");
                PixelColor32 x32 = new PixelColor32(rx, gx, bx);
                PixelColor32 y32 = new PixelColor32(ry, gy, by);
                PixelColor32 a32 = new PixelColor32(ra, ga, ba);
                PixelColor32 l32 = new PixelColor32(rl, gl, bl);


                ConvertPixelToDataUtility.ConvertPixelToIntValue(x32, out int worldPositionX);
                ConvertPixelToDataUtility.ConvertPixelToIntValue(y32, out int worldPositionY);
                ConvertPixelToDataUtility.ConvertPixelToMap2D(a32, out float mapx, out float mapy, out float angle);
                ConvertPixelToDataUtility.ConvertPixelToLifeXpLevel(l32, out float percentLife, out float percentXp, out int playerLevel);



                Console.WriteLine($"X{worldPositionX} Y{worldPositionY}");
                Console.WriteLine($"MX{mapx} MY{mapy} Angle{angle}");



                WowWorldPosition position = new WowWorldPosition(worldPositionX, worldPositionY);
                WowWorldPosition whereToGo = null;

                // Fire at start
                whereToGo = new WowWorldPosition(-115,-8769);
                // Gate
                whereToGo = new WowWorldPosition(-97.9, -9051.1);

                WowWorldPositionUtility.ComputeWowAngleFrom(position, whereToGo, out float angleDirection);
                WowWorldPositionUtility.ComputeDistance(position, whereToGo, out double distanceInWorldPosition);

                Console.WriteLine($"Player Angle {angle} Direction {angleDirection}");

                if (text == "r")
                {
                    champion.RotateToAngle(angle, angleDirection);
                    champion.MoveForDistance((float)distanceInWorldPosition);
                }

                else if (text == "goto") {
                    ConsoleWowCoord.MoveBetweenTwoWorldPoints(champion);

                }
                //CA MARCHE :)
                Console.Write($"Player xp {percentXp}  life {percentLife}  level {playerLevel}");


            }







            System.Environment.Exit(1);

            new ExChamp_Topic_MethodEtParametre().Run(allChampions);
            // C'est quoi une variable primitive ?
            new ExChamp_Keyword_VariablePrimitive().Run(allChampions);

            // C'est quoi un tableau d'entier ?
            new ExChamp_Topic_IntegerArrayAndloop().Run(allChampions);

            // Si l'on peut faire de macro avec des tableau entier ?
            // On peut faire des tableaus avec des textes via des chars ?
            new ExChamp_Topic_MacroOfCharsWithSwitchAndIf().Run(allChampions);

            // StartWith et IndexOf sont très utile pour les macros
            new ExChamp_Topic_StringStartWithAndIndexOf().Run(allChampions);



            // C'est quoi un variable ?
            // - [ ] C'est quoi des variables primitives ?

            // - [ ] Entier: bit, bytes, short, ushort, int, uint, long, ulong ?
            // - [ ] Ajouter une valeur à un variable ?
            // - [ ] Retirer une valeur à une variable ?
            // - [ ] C'est quoi ça '++' ?
            // - [ ] C'est quoi ça '--' ?
            // - [ ] C'est quoi ça '-=' ?
            // - [ ] C'est quoi ça '+=' ?
            // - [ ] Comment on multiplie une valeur ?
            // - [ ] Comment on divise une valeur ?
            // - [ ] C'est quoi ça '*=' ?
            // - [ ] C'est quoi ça '/=' ?
            // - [ ] C'est quoil a priorité des opérateurse et les ( () + () ) ?

            // - [ ] C'est quoi un casting implicite long a = 42 ?
            // - [ ] C'est quoi un casting explicite (int) variable ?


            // - [ ] Nombre à virgule: float, double ?
            // - [ ] C'est quoi un booléan ?  
            // - [ ] C'est quoi ça '==' ?  
            // - [ ] C'est quoi ça '&&' ?  
            // - [ ] C'est quoi ça '||' ?

            // C'est quoi un méthode
            // - [ ] Une méthode sans argument et sans retour ?
            // - [ ] Une méthode avec des arguments sans retour ?
            // - [ ] Une méthode avec des arguments qui retourne une valeur ?
            // - [ ] C'est quoi un paramètre par défault?
            // - [ ] C'est quoi le mot clé params ?
            // - [ ] C'est quoi c'est quoi un/des out ?


            // - C'est quoi un char et un string ?
            // - C'est quoi un string ?
            // - C'est quoi un tableau de char ?
            // - C'est quoi un char: ASCII, UNICODE ?

            // c'est quoi un réference ?
            new ExChamp_Keyword_ref().Run(allChampions);

        }
    }
}
