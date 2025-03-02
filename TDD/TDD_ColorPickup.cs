using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientQA.Pickup;

namespace ClientQA.TDD
{
    public class TDD_ColorPickup
    {

        public static void TestColorPickupLoopFromConsole() {

            int xDefaultPlayer1 = 0;
            int yDefaultPlayer1 = 0;
            ScreenPixelColorPicker playerPosition = new ScreenPixelColorPicker(xDefaultPlayer1, yDefaultPlayer1);
            Console.WriteLine("Put mouse on the pick up position");
            Thread.Sleep(3000);

            playerPosition.FetchAndSavePosition();

            Console.WriteLine("Move your mouse");
            Thread.Sleep(3000);
            playerPosition.GetLockedPixelColor(out int r, out int g, out int b);
            Console.WriteLine("Color: " + r + " " + g + " " + b);
            STRUCT_WowTransform2D position = new STRUCT_WowTransform2D();
            position.SetFromRGB(r, g, b);
            Thread.Sleep(3000);
            playerPosition.MoveCursorToLockedPosition();
            ColorPickerRefreshTimer timer = new ColorPickerRefreshTimer(playerPosition, 1000, true);

            while (true)
            {
                Thread.Sleep(1000);
            }
        }
    }
}
