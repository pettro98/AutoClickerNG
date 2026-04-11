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
            TableLayoutPanel hotkeyRecordTableLayout;
            TableLayoutPanel confirmCancelTableLayout;
            TableLayoutPanel mainTableLayout;
            recordHotkeyButton = new Button();
            hotkeyText = new TextBox();
            confirmButton = new Button();
            cancelButton = new Button();
            hotkeyRecordTableLayout = new TableLayoutPanel();
            confirmCancelTableLayout = new TableLayoutPanel();
            mainTableLayout = new TableLayoutPanel();
            hotkeyRecordTableLayout.SuspendLayout();
            confirmCancelTableLayout.SuspendLayout();
            mainTableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // hotkeyRecordTableLayout
            // 
            hotkeyRecordTableLayout.ColumnCount = 2;
            hotkeyRecordTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            hotkeyRecordTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            hotkeyRecordTableLayout.Controls.Add(recordHotkeyButton, 0, 0);
            hotkeyRecordTableLayout.Controls.Add(hotkeyText, 1, 0);
            hotkeyRecordTableLayout.Dock = DockStyle.Fill;
            hotkeyRecordTableLayout.Location = new Point(0, 0);
            hotkeyRecordTableLayout.Margin = new Padding(0);
            hotkeyRecordTableLayout.Name = "hotkeyRecordTableLayout";
            hotkeyRecordTableLayout.RowCount = 1;
            hotkeyRecordTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            hotkeyRecordTableLayout.Size = new Size(420, 30);
            hotkeyRecordTableLayout.TabIndex = 0;
            // 
            // recordHotkeyButton
            // 
            recordHotkeyButton.Dock = DockStyle.Fill;
            recordHotkeyButton.Location = new Point(3, 3);
            recordHotkeyButton.Name = "recordHotkeyButton";
            recordHotkeyButton.Size = new Size(133, 24);
            recordHotkeyButton.TabIndex = 0;
            recordHotkeyButton.Text = "Record hotkey";
            recordHotkeyButton.UseVisualStyleBackColor = true;
            // 
            // hotkeyText
            // 
            hotkeyText.Dock = DockStyle.Fill;
            hotkeyText.Enabled = false;
            hotkeyText.Location = new Point(142, 3);
            hotkeyText.Name = "hotkeyText";
            hotkeyText.PlaceholderText = "Optional modifiers + Letter/Digit/Numpad/F-key";
            hotkeyText.ReadOnly = true;
            hotkeyText.Size = new Size(275, 23);
            hotkeyText.TabIndex = 1;
            // 
            // confirmCancelTableLayout
            // 
            confirmCancelTableLayout.ColumnCount = 2;
            confirmCancelTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            confirmCancelTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            confirmCancelTableLayout.Controls.Add(confirmButton, 0, 0);
            confirmCancelTableLayout.Controls.Add(cancelButton, 1, 0);
            confirmCancelTableLayout.Dock = DockStyle.Fill;
            confirmCancelTableLayout.Location = new Point(0, 30);
            confirmCancelTableLayout.Margin = new Padding(0);
            confirmCancelTableLayout.Name = "confirmCancelTableLayout";
            confirmCancelTableLayout.RowCount = 1;
            confirmCancelTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            confirmCancelTableLayout.Size = new Size(420, 30);
            confirmCancelTableLayout.TabIndex = 1;
            // 
            // confirmButton
            // 
            confirmButton.Dock = DockStyle.Fill;
            confirmButton.Location = new Point(3, 3);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(204, 24);
            confirmButton.TabIndex = 0;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Dock = DockStyle.Fill;
            cancelButton.Location = new Point(213, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(204, 24);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // mainTableLayout
            // 
            mainTableLayout.ColumnCount = 1;
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainTableLayout.Controls.Add(hotkeyRecordTableLayout, 0, 0);
            mainTableLayout.Controls.Add(confirmCancelTableLayout, 0, 1);
            mainTableLayout.Location = new Point(12, 12);
            mainTableLayout.Name = "mainTableLayout";
            mainTableLayout.RowCount = 2;
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainTableLayout.Size = new Size(420, 60);
            mainTableLayout.TabIndex = 3;
            // 
            // HotkeyDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 83);
            Controls.Add(mainTableLayout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HotkeyDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Change hotkey";
            hotkeyRecordTableLayout.ResumeLayout(false);
            hotkeyRecordTableLayout.PerformLayout();
            confirmCancelTableLayout.ResumeLayout(false);
            mainTableLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button recordHotkeyButton;
        private TextBox hotkeyText;
        private Button confirmButton;
        private Button cancelButton;
    }
}