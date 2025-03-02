using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Timers;

namespace ClientQA.Pickup
{
    public class ActionCallbackTimer
    {

        private readonly System.Timers.Timer _timer;
        private readonly Action _action;

        public ActionCallbackTimer(Action action, int interval = 500)
        {
            _action = action ?? throw new ArgumentNullException(nameof(action));
            _timer = new System.Timers.Timer(interval);
            _timer.Elapsed += (sender, e) => _action?.Invoke();
            _timer.AutoReset = true; 
            _timer.Start();
        }

        public void Invoke() { _action.Invoke(); }
    }

    public class ColorPickerRefreshTimer {

        public STRUCT_WowTransform2D m_position;
        public ActionCallbackTimer m_timerCallBack;
        public ScreenPixelColorPicker m_colorPicker;

        public ColorPickerRefreshTimer(int x, int y, int interval = 250, bool consoleDebug = true): this(
            new ScreenPixelColorPicker(x, y), interval, consoleDebug)
        {}
        public ColorPickerRefreshTimer( ScreenPixelColorPicker colorPicker,int interval=250, bool consoleDebug=true) {
            m_timerCallBack =  new ActionCallbackTimer(() =>
            {
                colorPicker.GetLockedPixelColorAsPosition(out m_position);
                if (consoleDebug)
                    Console.WriteLine($"X:{m_position.m_xLeftRightPercentRaw}  Y:{m_position.m_yTopDownPercentRaw} A:{m_position.m_angleDegreeInverseClockWiseRaw}");
            }, interval);
            m_colorPicker = colorPicker;
            m_timerCallBack.Invoke();
        }

        public void GetPosition(out float xLeftRightPercent01, out float yTopDownPercent01, out float angleCounterClock360)
        {
            m_position.GetLeftRightPercent(out xLeftRightPercent01);
            m_position.GetTopDownPercent(out yTopDownPercent01);
            m_position.GetAngleInverseClockWise(out angleCounterClock360);
        }

        public void AskToMoveMouseWithConsoleToColor() {

            m_colorPicker.GetFromConsolePixelPosition(
                out int x, out int y, true);
            m_colorPicker.SetPosition(x, y);
        }
        public void FetchPositionFromConsole()
        {
            m_colorPicker.GetFromConsolePixelPosition(out int x, out int y, true);
            m_colorPicker.SetPosition(x, y);

        }

        public void DipslayPositionInConsole()
        {
            Console.WriteLine(m_position);
        }
    }

}
