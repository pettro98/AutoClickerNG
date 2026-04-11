using System.ComponentModel;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoClicker
{
    public partial class MainForm : Form
    {
        private const string _EmptyHotkeyValueStatusLabel = "<Not set>";


        // TODO add information to status bar (hotkey, active, mode/replay, click count remaining, ...)
        // TODO need to translate coordinates between screen-space and window-space
        // TODO check if can send event for window parts that are outside screen
        public MainForm()
        {
            InitializeComponent();

            positionTypeChoose.SelectedIndexChanged += positionTypeChoose_SelectedIndexChanged;
            repeatModeChoose.SelectedIndexChanged += repeatModeChoose_SelectedIndexChanged;
            hotkeyButton.Click += hotkeyButton_Click;

            HotkeyChanged += MainForm_HotkeyChanged;

            SetStartingControlValues();
        }


        // event handlers

        private void positionTypeChoose_SelectedIndexChanged(object? o, EventArgs e)
        {
            if (positionTypeChoose.SelectedIndex == 0) // Cursor
            {
                positionLabel.Enabled = false;
                positionXText.Enabled = false;
                positionSeparatorLabel.Enabled = false;
                positionYText.Enabled = false;
                selectPositionLabel.Enabled = false;
                selectPositionButton.Enabled = false;
                selectedWindowLabel.Enabled = false;
                selectedWindowButton.Enabled = false;
            }
            else if (positionTypeChoose.SelectedIndex == 1) // Screen relative
            {
                positionLabel.Enabled = true;
                positionXText.Enabled = true;
                positionSeparatorLabel.Enabled = true;
                positionYText.Enabled = true;
                selectPositionLabel.Enabled = true;
                selectPositionButton.Enabled = true;
                selectedWindowLabel.Enabled = false;
                selectedWindowButton.Enabled = false;
            }
            else if (positionTypeChoose.SelectedIndex == 2) // Window relative
            {
                positionLabel.Enabled = true;
                positionXText.Enabled = true;
                positionSeparatorLabel.Enabled = true;
                positionYText.Enabled = true;
                selectPositionLabel.Enabled = true;
                selectPositionButton.Enabled = true;
                selectedWindowLabel.Enabled = true;
                selectedWindowButton.Enabled = true;
            }
        }

        private void repeatModeChoose_SelectedIndexChanged(object? o, EventArgs e)
        {
            if (repeatModeChoose.SelectedIndex == 0) // Until stopped
            {
                repeatCountLabel.Enabled = false;
                repeatCountUpDown.Enabled = false;
            }
            else if (repeatModeChoose.SelectedIndex == 1) // Fixed count
            {
                repeatCountLabel.Enabled = true;
                repeatCountUpDown.Enabled = true;
            }
        }

        private void hotkeyButton_Click(object? o, EventArgs e)
        {
            var hotkeyDialog = new HotkeyDialog(_currentHotkey);
            hotkeyDialog.ShowDialog(this);
            var newHotkey = hotkeyDialog.GetNewHotkey();
            if (newHotkey != Keys.None && newHotkey != _currentHotkey)
            {
                SetNewHotkey(newHotkey);
            }
        }

        private void MainForm_HotkeyChanged(Keys newHotkey)
        {
            if (newHotkey != Keys.None)
            {
                hotkeyValueStatusLabel.Text = Helpers.ParseHotkey(newHotkey);
            }
            else
            {
                hotkeyValueStatusLabel.Text = _EmptyHotkeyValueStatusLabel;
            }
        }


        // private general methods

        private void SetStartingControlValues()
        {
            SetDefaultControlValues();
            // TODO restore from saved settings
        }

        private void SetDefaultControlValues()
        {
            minutesUpDown.Value = 0;
            secondsUpDown.Value = 0;
            millisecondsUpDown.Value = 0;
            randomOffsetUpDown.Value = 0;

            positionTypeChoose.SelectedIndex = 0;

            mouseButtonChoose.SelectedIndex = 0;
            clickTypeChoose.SelectedIndex = 0;
            repeatModeChoose.SelectedIndex = 0;
            repeatCountUpDown.Value = 0;

            SetNewHotkey(Keys.None);
        }

        private decimal GetSelectedIntervalMsec()
        {
            decimal intervalMsec = 0;
            intervalMsec += minutesUpDown.Value;
            intervalMsec *= 60;
            intervalMsec += secondsUpDown.Value;
            intervalMsec *= 1000;
            intervalMsec += millisecondsUpDown.Value;
            return intervalMsec;
        }

        private void SetNewHotkey(Keys newHotkey)
        {
            _currentHotkey = newHotkey;
            HotkeyChanged?.Invoke(_currentHotkey);
        }

        // data members

        public delegate void HotkeyHandler(Keys newHotkey);
        public event HotkeyHandler? HotkeyChanged;

        private Keys _currentHotkey = Keys.None;
    }

}
