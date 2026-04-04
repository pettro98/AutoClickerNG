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

            SetInputValidationEventHandlers();
            SetUIChangeEventHandlers();
            SetDataEventHandlers();

            SetStartingControlValues();
        }

        private void SetInputValidationEventHandlers()
        {
            CancelEventHandler validateUpDownMinMax = (sender, eventArgs) =>
            {
                var upDown = (NumericUpDown)sender!;

                if (upDown.Value > upDown.Maximum || upDown.Value < upDown.Minimum)
                {
                    eventArgs.Cancel = true;
                    //errorProvider.SetError(upDown, "Value out of bounds");
                }
                else
                {
                    //errorProvider.SetError(upDown, null);
                }
            };

            minutesUpDown.Validating += validateUpDownMinMax;
            secondsUpDown.Validating += validateUpDownMinMax;
            millisecondsUpDown.Validating += validateUpDownMinMax;
            randomOffsetUpDown.Validating += validateUpDownMinMax;

            repeatCountUpDown.Validating += validateUpDownMinMax;
        }

        private void SetUIChangeEventHandlers()
        {
            // TODO need to translate coordinates between screen-space and window-space
            // TODO check if can send event for window parts that are outside screen
            positionTypeChoose.SelectedIndexChanged += (sender, eventArgs) =>
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
            };

            repeatModeChoose.SelectedIndexChanged += (sender, eventArgs) =>
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
            };
        }

        private void SetDataEventHandlers()
        {
            hotkeyButton.Click += (sender, e) =>
            {
                var hotkeyDialog = new HotkeyDialog();
                hotkeyDialog.ShowDialog(this);
                if (hotkeyDialog.keys != Keys.None)
                {
                    StartStopHotkeyChanged((Keys)hotkeyDialog.keys);
                }
            };
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
