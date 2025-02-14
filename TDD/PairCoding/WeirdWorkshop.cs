using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using XboxClientQA.Pickup;
using XboxClientQA.TeacherCode.CoordinateWow;
using XboxClientQA.UtilityCode;

namespace XboxClientQA.TDD.PairCoding
{
    public  class WeirdWorkshop
    {

        public static void WeAreHere()
        {
            Console.WriteLine("We are here");
            ChampionThread champion = new ChampionThread("10.64.22.20", 7073, 0);


            //////////DON4T TOUCH PIXEL
            ///

            int xDefaultPlayer1 = 0;
            int yDefaultPlayer1 = 0;
            ScreenPixelColorPicker playerPosition = new ScreenPixelColorPicker(xDefaultPlayer1, yDefaultPlayer1);
            Console.WriteLine("Put mouse on the pick up position");
            Thread.Sleep(3000);

            playerPosition.FetchAndSavePosition();

            Console.WriteLine("Move your mouse");
            Thread.Sleep(3000);
            playerPosition.GetLockedPixelColor(out int r, out int g, out int blue);
            Console.WriteLine("Color: " + r + " " + g + " " + blue);
            STRUCT_WowTransform2D position = new STRUCT_WowTransform2D();
            position.SetFromRGB(r, g, blue);
            Thread.Sleep(3000);
            playerPosition.MoveCursorToLockedPosition();
            ColorPickerRefreshTimer timer = new ColorPickerRefreshTimer(playerPosition, 1000, true);

            ////////////


            float speedmapx = 0.13f;
            float speedmapy = 0.2f;
            float speedAverage = ((speedmapx + speedmapy)/2);

            while (true)
            {

                //champion.StartMovingForward();
                //champion.WaitSomeMilliseconds(5000);
                //champion.StopMovingForward();

                //while (true)
                //{
                //    Thread.Sleep(100);

                //}

                //champion.Ping();
                WowCoord current = new WowCoord();
                WowCoord target = new WowCoord();
                current.X = 57;
                current.Y = 53;
                current.Angle = 267;
                target.X = 57;
                target.Y = 52;
                target.Angle = 10;

                ConsoleWowCoord.AskForDirectionInfo(
                    out current,
                    out target,
                    out _,
                    out _,
                    out _,
                    out _,
                    true
                    );

                //ConsoleWowCoord.FetchAngleInto(
                //    ref current,
                //    ref target
                //    );




                ChampionThread.ComputeDirectionFromTo(current, target
                    , out bool isRotatingRight
                    , out float rotationAngleAbsolute);

                //WowSetToDirectionAngle.GetRotationFromTo(
                //    current.Angle, target.Angle, out bool goLeft, out float angle);
                //rotationAngleAbsolute = angle;
                //isRotatingRight = !goLeft;

                Console.WriteLine("Rotate : " + isRotatingRight);
                Console.WriteLine("Angle : " + rotationAngleAbsolute);
                ///
                int pressKey = WowIntegerKeyboard.ArrowLeft;
                if (isRotatingRight) { pressKey = WowIntegerKeyboard.ArrowRight; }


                champion.PressKey(pressKey);
                float speedRotation = 180;
                Thread.Sleep((int)((rotationAngleAbsolute / speedRotation) * 1000));
                champion.ReleaseKey(pressKey);


                float a = (target.X - current.X);
                float b = (target.Y - current.Y);
                float distance = (float)
                    System.Math.Sqrt
                    (Math.Pow(a, 2)
                    + Math.Pow(b, 2));
                float tempsDeMarche = (distance / speedAverage);

                champion.PressReleaseWithDelayForSeconds
                    (champion.m_moveHorizontalForward, tempsDeMarche, 0);
             
                
                champion.TabTabulation();
                champion.TapPower4();
                champion.TapInteract();
            }
                
              
        }
    }
}
