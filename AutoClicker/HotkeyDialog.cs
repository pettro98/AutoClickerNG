using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoClicker
{
    public partial class HotkeyDialog : Form
    {
        public Keys keys = Keys.None;

        private const string _RecordButtonTextActive = "Cancel recording";
        private const string _RecordButtonTextInactive = "Record hotkey";

        private bool _listenKeys = false;
        private Keys _currentHotkey = Keys.None;
        private Keys _newHotkey = Keys.None;

        public HotkeyDialog(Keys currentHotkey)
        {
            InitializeComponent();

            // HotkeyDialog.KeyPreview must be enabled so
            // the dialog itself can see all keyboard events
            // KeyDown += OnKeyDown; // enble after start record

            _currentHotkey = currentHotkey;
            recordHotheyButton.Click += RecordHotkeyButton_Click;

            var (currentHotkeyText, currentHotkeyValid) = ParseValidateHotkey(currentHotkey);
            hotkeyText.Text = currentHotkeyText;
        }

        private static string ParseHotkey(Keys hotkey)
        {
            string text = "";

            if ((hotkey & Keys.Control) != Keys.None)
            {
                text += "Ctrl + ";
            }
            if ((hotkey & Keys.Shift) != Keys.None)
            {
                text += "Shift + ";
            }
            if ((hotkey & Keys.Alt) != Keys.None)
            {
                text += "Alt + ";
            }

            Keys keyCode = hotkey & Keys.KeyCode;

            if (IsValidHotkey(keyCode))
            {
                text += keyCode;
            }

            return text;
        }

        private static bool IsValidHotkey(Keys hotkey)
        {
            Keys keyCode = hotkey & Keys.KeyCode;

            return (keyCode >= Keys.A && keyCode <= Keys.Z) ||
                (keyCode >= Keys.D0 && keyCode <= Keys.D9) ||
                (keyCode >= Keys.F1 && keyCode <= Keys.F24) ||
                (keyCode >= Keys.NumPad0 && keyCode <= Keys.NumPad9);
        }

        private void RecordHotkeyButton_Click(object? sender, EventArgs e)
        {
            ListenKeysSetEnabled(!_listenKeys);
            if (_listenKeys)
            {
                recordHotheyButton
            }
            else
            {
                KeyDown += HotkeyDialog_KeyDown;
                _listenKeys = true;
            }

        }

        private void ListenKeysSetEnabled(bool enable)
        {
            if (enable == _listenKeys)
            {
                return;
            }
            if (enable)
            {
                KeyDown += HotkeyDialog_KeyDown;
                _listenKeys = true;
            }
            else
            {
                KeyDown -= HotkeyDialog_KeyDown;
                _listenKeys = false;
            }

        }

        private void HotkeyDialog_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && keys != Keys.None)
            {
                Close();
                return;
            }
            else if (e.KeyData == Keys.Escape)
            {
                keys = Keys.None;
                Close();
                return;
            }

            var key = e.KeyData & Keys.KeyCode;
            var keysText = new List<string> { };

            if (e.Control)
            {
                keysText.Add("Ctrl");
            }
            if (e.Shift)
            {
                keysText.Add("Shift");
            }
            if (e.Alt)
            {
                keysText.Add("Alt");
            }
            if (key != Keys.None && (
                (key >= Keys.A && key <= Keys.Z) ||
                (key >= Keys.D0 && key <= Keys.D9) ||
                (key >= Keys.F1 && key <= Keys.F24) ||
                (key >= Keys.NumPad0 && key <= Keys.NumPad9)
            ))
            {
                keys = e.KeyData;
                keysText.Add(key.ToString());
            }
            else
            {
                keys = Keys.None;
            }

            if (keysText.Count > 0)
            {
                hotkeyLabel.Text = string.Join(" + ", keysText);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
