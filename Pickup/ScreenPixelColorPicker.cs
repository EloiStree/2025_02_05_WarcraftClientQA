using System;
using System.Drawing;
using System.Runtime.InteropServices;
using ClientQA.Pickup;

public class ScreenPixelColorPicker
{
    // Importing necessary functions from user32.dll and gdi32.dll
    [DllImport("user32.dll")]
    private static extern IntPtr GetDC(IntPtr hwnd);

    [DllImport("user32.dll")]
    private static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

    [DllImport("gdi32.dll")]
    private static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool GetCursorPos(out POINT lpPoint);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool SetCursorPos(int X, int Y);

    // Struct for cursor position
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int X;
        public int Y;
    }

    private int lockedX;
    private int lockedY;


    public ScreenPixelColorPicker()
    {
        FetchAndSavePosition();
    }
    public ScreenPixelColorPicker(int x, int y)
    {
        SetPosition(x, y);
    }

    // Method to lock the current cursor position
    public void FetchAndSavePosition()
    {
        POINT cursorPos;
        if (GetCursorPos(out cursorPos))
        {
            lockedX = cursorPos.X;
            lockedY = cursorPos.Y;
            Console.WriteLine($"Position locked at ({lockedX}, {lockedY}).");
        }
        else
        {
            throw new Exception("Unable to get cursor position.");
        }
    }

    // Method to manually lock a specified screen position
    public void SetPosition(int x, int y)
    {
        lockedX = x;
        lockedY = y;
        Console.WriteLine($"Position locked at ({lockedX}, {lockedY}).");
    }

    // Method to move the cursor to the locked position
    public void MoveCursorToLockedPosition()
    {
        if (!SetCursorPos(lockedX, lockedY))
            throw new Exception("Failed to move the cursor.");

        Console.WriteLine($"Cursor moved to ({lockedX}, {lockedY}).");
    }

    


    // Method to get the current cursor position without locking
    public POINT GetCurrentCursorPosition()
    {
        POINT cursorPos;
        if (GetCursorPos(out cursorPos))
        {
            return cursorPos;
        }
        else
        {
            throw new Exception("Unable to get cursor position.");
        }
    }

    public void GetCurrentCursorPosition(out int x, out int y) { 
    
        POINT cursorPos;
        if (GetCursorPos(out cursorPos))
        {
            Console.WriteLine($"Current cursor position: ({cursorPos.X}, {cursorPos.Y}).");
            x = cursorPos.X;
            y = cursorPos.Y;
        }
        else
        {
            throw new Exception("Unable to get cursor position.");
        }
    }

    public void GetLockedPixelColor(out int r, out int g, out int b)
    {
        IntPtr hdc = GetDC(IntPtr.Zero); // Get device context for the entire screen
        uint pixel = GetPixel(hdc, lockedX, lockedY);
        ReleaseDC(IntPtr.Zero, hdc);
        // Extract RGB values from the pixel
        r = (int)(pixel & 0x000000FF);
        g = (int)((pixel & 0x0000FF00) >> 8);
        b = (int)((pixel & 0x00FF0000) >> 16);
    }

    public void GetLockedPixelColorAsPosition(out STRUCT_WowTransform2D wowPosition)
    {
        GetLockedPixelColor(out int r, out int g, out int b);
        wowPosition = new STRUCT_WowTransform2D();
        wowPosition.SetFromRGB(r, g, b);
    }

    public void GetFromConsolePixelPosition(out int x , out int y, bool useDebug = true)
    {
        Console.WriteLine("Move Mouse to the desired position with in 3 seconds");
        System.Threading.Thread.Sleep(3000);
        GetCurrentCursorPosition( out x, out y);
        if (useDebug)
            Console.WriteLine($"Position locked at ({lockedX}, {lockedY}).");
    }
    public void SetFromConsolePixelPosition(bool useDebug=true)
    {
        Console.WriteLine("Move Mouse to the desired position with in 3 seconds");
        System.Threading.Thread.Sleep(3000);
        GetCurrentCursorPosition(out int x, out int y);
        SetPosition(x, y);
        if (useDebug)
            Console.WriteLine($"Position locked at ({lockedX}, {lockedY}).");

    }

}
