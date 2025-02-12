using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Eloi.IID;
using XboxClientQA.TeacherCode.CoordinateWow;
using XboxClientQA.UtilityCode;

namespace XboxClientQA.TeacherCode
{
    public class TeacherProgram
    {
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static void TeacherMain(params string[] args)
        {

            ChampionThread champion = new ChampionThread("10.64.22.20", 7073, 5);


            WowCoord player = new WowCoord(43, 16, 0);
            WowCoord target = new WowCoord(80, 35, 0);

           bool isRight= player.IsAtRight(target);

            isRight= WowCoord.IsAtRight(
                player, 
                target);

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

        }
    }
}
