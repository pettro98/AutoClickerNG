using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker
{
    internal class ClickerService : IDisposable
    {
        private const Int32 WH_KEYBOARD_LL = 13;
        private const Int32 WM_KEYDOWN = 0x0100;

        private IntPtr _hookId = IntPtr.Zero;
        private Keys _hotkey = Keys.None;

        public void SetNewHotkey(Keys hotkey)
        {
            _hotkey = hotkey;
            UnsetKeyboardHook();
            SetKeyboardHook();
        }

        public void Dispose()
        {
            UnsetKeyboardHook();
        }

        private void SetKeyboardHook()
        {
            using Process curProcess = Process.GetCurrentProcess();
            using ProcessModule curModule = curProcess.MainModule!;

            Native.LowLevelKeyboardProc keyboardHook = (nCode, wParam, lParam) =>
            {
                if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
                {
                    OnHotkeyPressed(Marshal.ReadInt32(lParam));
                }
                return Native.CallNextHookEx(_hookId, nCode, wParam, lParam);
            };
            var moduleHandle = Native.GetModuleHandle(curModule.ModuleName);
            if (moduleHandle == IntPtr.Zero)
            {
                var hr = Marshal.GetHRForLastWin32Error();
                throw new Exception("GetModuleHandle() failed", Marshal.GetExceptionForHR(hr));
            }

            _hookId = Native.SetWindowsHookEx(WH_KEYBOARD_LL, keyboardHook, moduleHandle, 0);
            if (_hookId == IntPtr.Zero)
            {
                var hr = Marshal.GetHRForLastWin32Error();
                throw new Exception("SetWindowsHookEx() failed", Marshal.GetExceptionForHR(hr));
            }
        }

        private void UnsetKeyboardHook()
        {
            if (_hookId != IntPtr.Zero)
            {
                var success = Native.UnhookWindowsHookEx(_hookId);
                if (!success)
                {
                    var hr = Marshal.GetHRForLastWin32Error();
                    throw new Exception("UnhookWindowsHookEx() failed", Marshal.GetExceptionForHR(hr));
                }
                _hookId = IntPtr.Zero;
            }
        }

        private void OnHotkeyPressed(Int32 keycode)
        {

        }
    }
}
