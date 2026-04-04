namespace AutoClicker
{
    partial class HotkeyDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label label1;
            tableLayoutPanel1 = new TableLayoutPanel();
            hotkeyLabel = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(207, 57);
            label1.TabIndex = 1;
            label1.Text = "Enter new hotkey\r\n(Enter) to confirm\r\n(Esc) to cancel";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(hotkeyLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.Size = new Size(213, 83);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // hotkeyLabel
            // 
            hotkeyLabel.AutoSize = true;
            hotkeyLabel.BorderStyle = BorderStyle.Fixed3D;
            hotkeyLabel.Dock = DockStyle.Fill;
            hotkeyLabel.Location = new Point(3, 57);
            hotkeyLabel.Name = "hotkeyLabel";
            hotkeyLabel.Size = new Size(207, 26);
            hotkeyLabel.TabIndex = 4;
            hotkeyLabel.Text = "[<modifiers>]+Letter/Digit/Fkey";
            hotkeyLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HotkeyDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(237, 106);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HotkeyDialog";
            Text = "Hotkey";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Label hotkeyLabel;
    }
}