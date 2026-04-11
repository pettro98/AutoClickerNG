using System.Windows.Forms;

namespace AutoClicker
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var mainForm = new MainForm();

            mainForm.HotkeyChanged += MainForm_HotkeyChanged;
            hookManager.HotkeyPressed += Clicker_HotkeyPressed;

            Application.Run(mainForm);

            // TODO save 
        }

        static void Clicker_HotkeyPressed()
        {
            // TODO: get selected options from mainForm and start clicking
        }

        static void MainForm_HotkeyChanged(Keys hotkey)
        {
            hookManager.SetNewHotkey(hotkey);
        }

        static KeyboardHookManager hookManager = new KeyboardHookManager();
    }
}
