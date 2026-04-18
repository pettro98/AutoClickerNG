using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker
{
    internal class MainFormEvents
    {
        public enum PositioningType
        {
            Cursor = 0,
            ScreenRelative,
            WindowRelative
        }
        new Binding

        public delegate void IntervalChangedHandler(uint newInterval);
        public event IntervalChangedHandler? IntervalChangedMin;
        public event IntervalChangedHandler? IntervalChangedSec;
        public event IntervalChangedHandler? IntervalChangedMsec;
        public event IntervalChangedHandler? IntervalChangedOffsetMsec;

        public delegate void PositioningTypeChangedHandler(PositioningType newPositioningType);
        public event PositioningTypeChangedHandler? PositioningTypeChanged;

        public delegate void PositionChangedHandler(uint newCoordinate);
        public event PositionChangedHandler? PositionXChanged;
        public event PositionChangedHandler? PositionYChanged;

        public delegate void IntervalChangedHandler(uint intervalMsec, uint offsetMsec);
        public event IntervalChangedHandler? IntervalChanged;

        public delegate void IntervalChangedHandler(uint intervalMsec, uint offsetMsec);
        public event IntervalChangedHandler? IntervalChanged;

        public delegate void IntervalChangedHandler(uint intervalMsec, uint offsetMsec);
        public event IntervalChangedHandler? IntervalChanged;


    }
}
