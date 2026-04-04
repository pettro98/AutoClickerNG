using System.Windows.Forms;

namespace AutoClicker
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var mainForm = new MainForm();

            mainForm.StartStopHotkeyChanged += OnHotkeyChanged;

            Application.Run(mainForm);

            // TODO save 
        }

        static void OnHotkeyChanged(Keys hotkey)
        {
            //var key = hotkey & Keys.KeyCode;

            //var keysText = new List<string> { };

            //if ((hotkey & Keys.Control) != 0)
            //{
            //    keysText.Add("Ctrl");
            //}
            //if ((hotkey & Keys.Shift) != 0)
            //{
            //    keysText.Add("Shift");
            //}
            //if ((hotkey & Keys.Alt) != 0)
            //{
            //    keysText.Add("Alt");
            //}
            //if (key != Keys.None)
            //{
            //    keysText.Add(key.ToString());
            //}

            //MessageBox.Show(string.Join(" + ", keysText));

            StartStopHotkey = hotkey;
        }

        static Keys StartStopHotkey = Keys.None;
    }
}