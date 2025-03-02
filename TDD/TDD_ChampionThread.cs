using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientQA.TDD
{
    public class TDD_ChampionThread
    {
        public static void TestOemKey(ChampionThread target, string name, int keyCode)
        {
            Console.WriteLine($"Testing key,{name}: " + keyCode);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ready ? " + i);
                Thread.Sleep(1000);
                target.TapKey(keyCode);
                target.WaitFrame();
            }
        }

        public static void TestAllCommands(ChampionThread target)
        {
            foreach (string command in target.m_wowCommand)
            {
                Console.WriteLine("Testing command: " + command);
                target.WriteAlpahNumericalCommand(command);
                target.WaitSomeSeconds(2);
                target.WaitSomeMilliseconds(500);
            }
        }
    }
}
