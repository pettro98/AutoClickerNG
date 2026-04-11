using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker
{
    internal class KeyboardHookManager
    {
        private const Int32 WH_KEYBOARD_LL = 13;
        private const Int32 WM_KEYDOWN = 0x0100;
        private const Int32 WM_SYSKEYDOWN = 0x0104;
        private const Int32 VK_CONTROL = 0x11;
        private const Int32 VK_SHIFT = 0x10;
        private const Int32 VK_MENU = 0x12;

        ~KeyboardHookManager()
        {
            UnsetKeyboardHook();
        }

        public void SetNewHotkey(Keys hotkey)
        {
            _hotkey = hotkey;
            UnsetKeyboardHook();
            SetKeyboardHook();
        }

        private void SetKeyboardHook()
        {
            using Process curProcess = Process.GetCurrentProcess();
            using ProcessModule curModule = curProcess.MainModule!;

            Native.LowLevelKeyboardProc keyboardHook = (nCode, wParam, lParam) =>
            {
                if (nCode >= 0 && (wParam == (IntPtr)WM_KEYDOWN || wParam == (IntPtr)WM_SYSKEYDOWN))
                {
                    if (IsConfiguredHotkeyPressed(Marshal.ReadInt32(lParam)))
                    {
                        HotkeyPressed?.Invoke();
                    }
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

        private bool IsConfiguredHotkeyPressed(Int32 pressedKeyCode)
        {
            var configuredKeyCode = _hotkey & Keys.KeyCode;
            if (configuredKeyCode == Keys.None || (Int32)configuredKeyCode != pressedKeyCode)
            {
                return false;
            }

            var requiredModifiers = _hotkey & (Keys.Control | Keys.Shift | Keys.Alt);
            var pressedModifiers = GetPressedModifiers();

            return requiredModifiers == pressedModifiers;
        }

        private static Keys GetPressedModifiers()
        {
            Keys modifiers = Keys.None;

            if (IsKeyPressed(VK_CONTROL))
            {
                modifiers |= Keys.Control;
            }
            if (IsKeyPressed(VK_SHIFT))
            {
                modifiers |= Keys.Shift;
            }
            if (IsKeyPressed(VK_MENU))
            {
                modifiers |= Keys.Alt;
            }

            return modifiers;
        }

        private static bool IsKeyPressed(Int32 virtualKey)
        {
            return (Native.GetAsyncKeyState(virtualKey) & 0x8000) != 0;
        }

        public event Action? HotkeyPressed;

        private IntPtr _hookId = IntPtr.Zero;
        private Keys _hotkey = Keys.None;
    }
}
