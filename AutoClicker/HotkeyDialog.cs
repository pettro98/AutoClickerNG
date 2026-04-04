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

        public HotkeyDialog()
        {
            InitializeComponent();

            KeyDown += (_, args) =>
            {
                if (args.KeyData == Keys.Enter && keys != Keys.None)
                {
                    Close();
                    return;
                }
                else if (args.KeyData == Keys.Escape)
                {
                    keys = Keys.None;
                    Close();
                    return;
                }

                var key = args.KeyData & Keys.KeyCode;
                var keysText = new List<string> { };

                if (args.Control)
                {
                    keysText.Add("Ctrl");
                }
                if (args.Shift)
                {
                    keysText.Add("Shift");
                }
                if (args.Alt)
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
                    keys = args.KeyData;
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
            };
        }
    }
}
