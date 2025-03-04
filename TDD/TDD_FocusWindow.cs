using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientQA.TDD
{
    public class TDD_FocusWindow
    {
        public static void TestWindowFocus(ChampionThread champion, int from =0, int to=4)
        {
            for (int i = from; i < to; i++)
            {
                Console.WriteLine("Focus on player index: " + i);
                champion.SetPlayerIndex(i);
                champion.RequestWindowFocus();
            }
        }
    }
}
