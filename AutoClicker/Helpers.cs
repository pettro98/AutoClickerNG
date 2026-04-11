using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker
{
    internal static class Helpers
    {
        public static Keys NormalizeHotkey(Keys hotkey)
        {
            // only ctrl, shift, alt and main key are allowed
            Keys keyCode = hotkey & Keys.KeyCode;
            Keys modifiers = hotkey & (Keys.Control | Keys.Shift | Keys.Alt);

            if (!((keyCode >= Keys.A && keyCode <= Keys.Z) ||
                (keyCode >= Keys.D0 && keyCode <= Keys.D9) ||
                (keyCode >= Keys.F1 && keyCode <= Keys.F24) ||
                (keyCode >= Keys.NumPad0 && keyCode <= Keys.NumPad9)))
            {
                keyCode = Keys.None;
            }
            return keyCode | modifiers;
        }

        public static string ParseHotkey(Keys hotkey)
        {
            string text = "";

            hotkey = NormalizeHotkey(hotkey);

            if ((hotkey & Keys.Control) == Keys.Control)
            {
                text += "Ctrl + ";
            }
            if ((hotkey & Keys.Shift) == Keys.Shift)
            {
                text += "Shift + ";
            }
            if ((hotkey & Keys.Alt) == Keys.Alt)
            {
                text += "Alt + ";
            }

            Keys keyCode = hotkey & Keys.KeyCode;

            if (keyCode != Keys.None)
            {
                text += keyCode;
            }

            return text;
        }
    }

    internal class SChangeNotify<T> where T : struct
    {
        private SChangeNotify(T value)
        {
            _value = value;
        }

        public static explicit operator SChangeNotify<T>(T value)
        {
            return new SChangeNotify<T>(value);
        }

        public static implicit operator T(SChangeNotify<T> wrapper)
        {
            return wrapper._value;
        }

        public T Value
        {
            get { return _value; }
            set
            {
                var oldvalue = _value;
                _value = value;
                Changed?.Invoke(oldvalue, value);
            }
        }

        public delegate void ChangeEventHandler(T oldvalue, T newvalue);

        public event ChangeEventHandler? Changed;

        private T _value;
    }

    internal class CChangeNotify<T> where T : class
    {
        public static implicit operator T?(CChangeNotify<T> wrapper)
        {
            return wrapper._value;
        }

        public T? Value
        {
            get
            {
                return _value;
            }
            set
            {
                var oldvalue = _value;
                _value = value;
                Changed?.Invoke(oldvalue, value);
            }
        }

        public delegate void ChangeEventHandler(T? oldvalue, T? newvalue);

        public event ChangeEventHandler? Changed;

        private T? _value;
    }
}
