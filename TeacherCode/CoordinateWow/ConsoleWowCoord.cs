﻿using ClientQA.UtilityCode;

namespace ClientQA.TeacherCode.CoordinateWow
{
    public class ConsoleWowCoord { 
    
    
        public static void AskForPosition(out WowMapCoord current,string displayMessage)
        {
            try { 
                Console.WriteLine(displayMessage);
                Console.WriteLine("Enter X:");
                float x = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Y:");
                float y = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Angle:");
                float angle = float.Parse(Console.ReadLine());
                current = new WowMapCoord(x, y, angle);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                current = new WowMapCoord();
            }
        }
        public static void AskForDirectionInfo(
            out WowMapCoord origin,
            out WowMapCoord target,
            out float distance,
            out bool isLeftDirection,
            out float angleToRotate,
            out float rotationTime,
            bool debugConsole =true)
        {
        
            AskForPosition(out origin,"Give origin");
            AskForPosition(out target,"Give target");
            WowMapCoord.GetCountClockwiseAngle(
                origin, target,
                out float dirAngle);
            distance = WowMapCoord.GetDistanceBetween(origin, target);
            WowSetToDirectionAngle
                .GetRotationFromTo(origin.Angle, dirAngle,
                out isLeftDirection, out angleToRotate);
            ChampionMoveAndRotate.
                Rotate(angleToRotate, out rotationTime);

            if (debugConsole) { 
                Console.WriteLine("Distance: " + distance);
                Console.WriteLine("Direction Angle: " + dirAngle);
                Console.WriteLine("Is Left Direction: " + isLeftDirection);
                Console.WriteLine("Angle To Rotate: " + angleToRotate);
                Console.WriteLine("Rotation Time: " + rotationTime);
            }
        }


        public static void AskForAngleOnly(out float angle, string displayMessage) {

            try
            {
                Console.WriteLine(displayMessage);
                angle = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                angle = 0;
            }

        }


        public static void FetchAngleInto(
           ref WowMapCoord origin,
           ref  WowMapCoord target
           )
        {
            AskForAngleOnly(out float startAngle, 
                "Give start angle");
            AskForAngleOnly(out float stopAngle,
                "Give stop angle");
            origin.Angle = startAngle;
            target.Angle = stopAngle;
        }

      
    }
}