using ClientQA.TeacherCode.CoordinateWow;

namespace ClientQA.LearningExample.Basic
{
    public static class TDD_WowWorldPositionToAngle {

        public static void TestAll() {

            WowWorldPosition to = new WowWorldPosition();
            WowWorldPosition from = new WowWorldPosition();
            to.m_xRightToleft = -97.9;
            to.m_yDownToUp = -9051.1;


            from.m_xRightToleft = -35.60;
            from.m_yDownToUp = -8972.80;
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            WowWorldPositionUtility.ComputeWowAngleFrom(from, to, out float angle);
            Console.WriteLine("Down Right: " + angle);
            Console.WriteLine("\n");


            from.m_xRightToleft = -153.5;
            from.m_yDownToUp = -8992;
            WowWorldPositionUtility.ComputeWowAngleFrom(from, to, out  angle);
            Console.WriteLine("Down Left: " + angle);
            Console.WriteLine("\n");

            from.m_xRightToleft = -180.4;
            from.m_yDownToUp = -9191.4;
            WowWorldPositionUtility.ComputeWowAngleFrom(from, to, out  angle);
            Console.WriteLine("Left Up: " + angle);
            Console.WriteLine("\n");

            from.m_xRightToleft = 16.3;
            from.m_yDownToUp = -9135.4;
            WowWorldPositionUtility.ComputeWowAngleFrom(from, to, out  angle);
            Console.WriteLine("Top Right: " + angle);
            Console.WriteLine("\n");





        }
    }

  
}


