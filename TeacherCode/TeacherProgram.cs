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

namespace ClientQA.TeacherCode
{
    public class TeacherProgram
    {
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static void TeacherMain(params string[] args)
        {

            string address = "127.0.0.1";
            int port = 3615;
            port = 7073;
            NinjaThread ninja = new NinjaThread(address, port, 1);

            while (true)
            {
                ninja.TapRestart();
                ninja.WaitOneSeconds();
                ninja.TapShuriken();
                ninja.WaitOneSeconds();
                ninja.TapSword();
                ninja.StartMovingRight();
                ninja.WaitOneSeconds();
                ninja.StopMovingRight();
                ninja.WaitOneSeconds();
                ninja.StartMovingLeft();
                ninja.WaitOneSeconds();
                ninja.StopMovingLeft();
                ninja.WaitOneSeconds();
                ninja.StartJumping();
                ninja.WaitOneSeconds();
                ninja.StopJumping();

                ninja.TapDoubleJumpInMilliseconds(200);

                ninja.WaitOneSeconds();

            }

        }
    }
}
