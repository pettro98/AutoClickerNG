using System.ComponentModel;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoClicker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            // TODO add information to status bar (hotkey, active, mode/replay, click count remaining, ...)
            InitializeComponent();

            SetEventHandlers();

            SetStartingControlValues();
        }

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
            var hotkeyDialog = new HotkeyDialog();
            hotkeyDialog.ShowDialog(this);
            if (hotkeyDialog.keys != Keys.None)
            {
                StartStopHotkeyChanged((Keys)hotkeyDialog.keys);
            }
        }

        private void SetEventHandlers()
        {
            // TODO need to translate coordinates between screen-space and window-space
            // TODO check if can send event for window parts that are outside screen
            positionTypeChoose.SelectedIndexChanged += positionTypeChoose_SelectedIndexChanged;
            repeatModeChoose.SelectedIndexChanged += repeatModeChoose_SelectedIndexChanged;
            hotkeyButton.Click += hotkeyButton_Click;
        }


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

        public delegate void HotkeyHandler(Keys newHotkey);
        public event HotkeyHandler StartStopHotkeyChanged;
    }

}
