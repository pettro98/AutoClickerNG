using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoClicker
{
    public partial class HotkeyDialog : Form
    {
        private const string _RecordButtonTextActive = "Cancel recording";
        private const string _RecordButtonTextInactive = "Record hotkey";

        private bool _isRecordingHotkey = false;
        private Keys _recordedHotkey = Keys.None; // to store incomplete hotkey when recording
        private Keys _savedHotkey = Keys.None; // to store committed hotkey

        public HotkeyDialog(Keys currentHotkey)
        {
            InitializeComponent();

            CancelButton = cancelButton;

            KeyDown += HotkeyDialog_KeyDown;

            recordHotkeyButton.Click += RecordHotkeyButton_Click;
            cancelButton.Click += CancelButton_Click;
            confirmButton.Click += ConfirmButton_Click;

            // HotkeyDialog.KeyPreview must be enabled so
            // the dialog itself can see all keyboard events

            _savedHotkey = currentHotkey;

            UpdateHotkeyTextAndButtons();
        }


        // event handlers

        private void HotkeyDialog_KeyDown(object? sender, KeyEventArgs e)
        {
            if (!_isRecordingHotkey)
            {
                return;
            }

            e.SuppressKeyPress = true;

            _recordedHotkey = Helpers.NormalizeHotkey(e.KeyData);
            UpdateHotkeyTextAndButtons();
            if ((_recordedHotkey & Keys.KeyCode) != Keys.None)
            {
                SetRecordingActive(false);
            }
        }

        private void RecordHotkeyButton_Click(object? sender, EventArgs e)
        {
            SetRecordingActive(!_isRecordingHotkey);
        }

        private void CancelButton_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void ConfirmButton_Click(object? sender, EventArgs e)
        {
            SaveHotkey();
            Close();
        }


        // private general methods

        private void UpdateHotkeyTextAndButtons()
        {
            cancelButton.Enabled = !_isRecordingHotkey;

            if (_isRecordingHotkey)
            {
                recordHotkeyButton.Text = _RecordButtonTextActive;
                confirmButton.Enabled = false;
            }
            else
            {
                recordHotkeyButton.Text = _RecordButtonTextInactive;
                confirmButton.Enabled = (_recordedHotkey != Keys.None);
            }

            if (_recordedHotkey != Keys.None)
            {
                hotkeyText.Text = Helpers.ParseHotkey(_recordedHotkey);
            }
            else if (_isRecordingHotkey)
            {
                hotkeyText.Text = null;
            }
            else
            {
                hotkeyText.Text = Helpers.ParseHotkey(_savedHotkey);
            }
        }

        private void SaveHotkey()
        {
            _savedHotkey = _recordedHotkey;
        }

        private void SetRecordingActive(bool active)
        {
            if (_isRecordingHotkey == active)
            {
                return;
            }

            _isRecordingHotkey = active;

            if (_isRecordingHotkey)
            {
                _recordedHotkey = Keys.None;
            }
            else if ((_recordedHotkey & Keys.KeyCode) == Keys.None)
            {
                _recordedHotkey = Keys.None; // reset the value if hotkey wasnt properly recorded
            }

            UpdateHotkeyTextAndButtons();
        }


        // public methods

        public Keys GetNewHotkey() => _savedHotkey;

    }
}
