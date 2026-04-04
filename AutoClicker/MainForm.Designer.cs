namespace AutoClicker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TableLayoutPanel clickIntervalTimeTableLayout;
            GroupBox clickIntervalGroup;
            TableLayoutPanel clickIntervalTableLayout;
            TableLayoutPanel clickIntervalOffsetTableLayout;
            GroupBox clickOptionsGroup;
            TableLayoutPanel clickOptionsTableLayout;
            TableLayoutPanel clickPositionTableLayout;
            TableLayoutPanel positionTableLayout;
            GroupBox clickPositionGroup;
            TableLayoutPanel viewOptionsTableLayout;
            GroupBox miscOptionsGroup;
            minutesUpDown = new NumericUpDown();
            secondsUpDownLabel = new Label();
            millisecondsUpDown = new NumericUpDown();
            secondsUpDown = new NumericUpDown();
            millisecondsUpDownLabel = new Label();
            minutesUpDownLabel = new Label();
            randomOffsetLabel = new Label();
            randomOffsetUpDown = new NumericUpDown();
            mouseButtonChooseLabel = new Label();
            clickTypeChooseLabel = new Label();
            mouseButtonChoose = new ComboBox();
            clickTypeChoose = new ComboBox();
            repeatModeLabel = new Label();
            repeatCountLabel = new Label();
            repeatModeChoose = new ComboBox();
            repeatCountUpDown = new NumericUpDown();
            positionTypeChooseLabel = new Label();
            positionTypeChoose = new ComboBox();
            positionLabel = new Label();
            selectPositionLabel = new Label();
            selectedWindowLabel = new Label();
            selectedWindowButton = new Button();
            positionXText = new TextBox();
            positionYText = new TextBox();
            positionSeparatorLabel = new Label();
            selectPositionButton = new Button();
            clickViewModeLabel = new Label();
            clickViewModeChoose = new ComboBox();
            hotkeyLabel = new Label();
            hotkeyButton = new Button();
            recordControlLabel = new Label();
            statusBar = new StatusStrip();
            errorProvider = new ErrorProvider(components);
            clickIntervalTimeTableLayout = new TableLayoutPanel();
            clickIntervalGroup = new GroupBox();
            clickIntervalTableLayout = new TableLayoutPanel();
            clickIntervalOffsetTableLayout = new TableLayoutPanel();
            clickOptionsGroup = new GroupBox();
            clickOptionsTableLayout = new TableLayoutPanel();
            clickPositionTableLayout = new TableLayoutPanel();
            positionTableLayout = new TableLayoutPanel();
            clickPositionGroup = new GroupBox();
            viewOptionsTableLayout = new TableLayoutPanel();
            miscOptionsGroup = new GroupBox();
            clickIntervalTimeTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minutesUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)millisecondsUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secondsUpDown).BeginInit();
            clickIntervalGroup.SuspendLayout();
            clickIntervalTableLayout.SuspendLayout();
            clickIntervalOffsetTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)randomOffsetUpDown).BeginInit();
            clickOptionsGroup.SuspendLayout();
            clickOptionsTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)repeatCountUpDown).BeginInit();
            clickPositionTableLayout.SuspendLayout();
            positionTableLayout.SuspendLayout();
            clickPositionGroup.SuspendLayout();
            viewOptionsTableLayout.SuspendLayout();
            miscOptionsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // clickIntervalTimeTableLayout
            // 
            clickIntervalTimeTableLayout.AutoSize = true;
            clickIntervalTimeTableLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            clickIntervalTimeTableLayout.CausesValidation = false;
            clickIntervalTimeTableLayout.ColumnCount = 3;
            clickIntervalTimeTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            clickIntervalTimeTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            clickIntervalTimeTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            clickIntervalTimeTableLayout.Controls.Add(minutesUpDown, 0, 1);
            clickIntervalTimeTableLayout.Controls.Add(secondsUpDownLabel, 1, 0);
            clickIntervalTimeTableLayout.Controls.Add(millisecondsUpDown, 2, 1);
            clickIntervalTimeTableLayout.Controls.Add(secondsUpDown, 1, 1);
            clickIntervalTimeTableLayout.Controls.Add(millisecondsUpDownLabel, 2, 0);
            clickIntervalTimeTableLayout.Controls.Add(minutesUpDownLabel, 0, 0);
            clickIntervalTimeTableLayout.Dock = DockStyle.Fill;
            clickIntervalTimeTableLayout.Location = new Point(0, 0);
            clickIntervalTimeTableLayout.Margin = new Padding(0);
            clickIntervalTimeTableLayout.Name = "clickIntervalTimeTableLayout";
            clickIntervalTimeTableLayout.RowCount = 2;
            clickIntervalTimeTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            clickIntervalTimeTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            clickIntervalTimeTableLayout.Size = new Size(230, 56);
            clickIntervalTimeTableLayout.TabIndex = 3;
            // 
            // minutesUpDown
            // 
            minutesUpDown.Dock = DockStyle.Fill;
            minutesUpDown.Location = new Point(3, 31);
            minutesUpDown.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            minutesUpDown.Name = "minutesUpDown";
            minutesUpDown.Size = new Size(70, 23);
            minutesUpDown.TabIndex = 0;
            minutesUpDown.TextAlign = HorizontalAlignment.Right;
            // 
            // secondsUpDownLabel
            // 
            secondsUpDownLabel.AutoSize = true;
            secondsUpDownLabel.Dock = DockStyle.Fill;
            secondsUpDownLabel.Location = new Point(79, 0);
            secondsUpDownLabel.Name = "secondsUpDownLabel";
            secondsUpDownLabel.Size = new Size(70, 28);
            secondsUpDownLabel.TabIndex = 2;
            secondsUpDownLabel.Text = "Sec";
            secondsUpDownLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // millisecondsUpDown
            // 
            millisecondsUpDown.Dock = DockStyle.Fill;
            millisecondsUpDown.Location = new Point(155, 31);
            millisecondsUpDown.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            millisecondsUpDown.Name = "millisecondsUpDown";
            millisecondsUpDown.Size = new Size(72, 23);
            millisecondsUpDown.TabIndex = 0;
            millisecondsUpDown.TextAlign = HorizontalAlignment.Right;
            // 
            // secondsUpDown
            // 
            secondsUpDown.Dock = DockStyle.Fill;
            secondsUpDown.Location = new Point(79, 31);
            secondsUpDown.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            secondsUpDown.Name = "secondsUpDown";
            secondsUpDown.Size = new Size(70, 23);
            secondsUpDown.TabIndex = 0;
            secondsUpDown.TextAlign = HorizontalAlignment.Right;
            // 
            // millisecondsUpDownLabel
            // 
            millisecondsUpDownLabel.AutoSize = true;
            millisecondsUpDownLabel.Dock = DockStyle.Fill;
            millisecondsUpDownLabel.Location = new Point(155, 0);
            millisecondsUpDownLabel.Name = "millisecondsUpDownLabel";
            millisecondsUpDownLabel.Size = new Size(72, 28);
            millisecondsUpDownLabel.TabIndex = 3;
            millisecondsUpDownLabel.Text = "MSec";
            millisecondsUpDownLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minutesUpDownLabel
            // 
            minutesUpDownLabel.AutoSize = true;
            minutesUpDownLabel.Dock = DockStyle.Fill;
            minutesUpDownLabel.Location = new Point(3, 0);
            minutesUpDownLabel.Name = "minutesUpDownLabel";
            minutesUpDownLabel.Size = new Size(70, 28);
            minutesUpDownLabel.TabIndex = 1;
            minutesUpDownLabel.Text = "Min";
            minutesUpDownLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clickIntervalGroup
            // 
            clickIntervalGroup.Controls.Add(clickIntervalTableLayout);
            clickIntervalGroup.Location = new Point(12, 12);
            clickIntervalGroup.Name = "clickIntervalGroup";
            clickIntervalGroup.Size = new Size(236, 106);
            clickIntervalGroup.TabIndex = 1;
            clickIntervalGroup.TabStop = false;
            clickIntervalGroup.Text = "Click interval";
            // 
            // clickIntervalTableLayout
            // 
            clickIntervalTableLayout.ColumnCount = 1;
            clickIntervalTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            clickIntervalTableLayout.Controls.Add(clickIntervalTimeTableLayout, 0, 0);
            clickIntervalTableLayout.Controls.Add(clickIntervalOffsetTableLayout, 0, 1);
            clickIntervalTableLayout.Dock = DockStyle.Fill;
            clickIntervalTableLayout.Location = new Point(3, 19);
            clickIntervalTableLayout.Margin = new Padding(0);
            clickIntervalTableLayout.Name = "clickIntervalTableLayout";
            clickIntervalTableLayout.RowCount = 2;
            clickIntervalTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            clickIntervalTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            clickIntervalTableLayout.Size = new Size(230, 84);
            clickIntervalTableLayout.TabIndex = 5;
            // 
            // clickIntervalOffsetTableLayout
            // 
            clickIntervalOffsetTableLayout.ColumnCount = 2;
            clickIntervalOffsetTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            clickIntervalOffsetTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            clickIntervalOffsetTableLayout.Controls.Add(randomOffsetLabel, 0, 0);
            clickIntervalOffsetTableLayout.Controls.Add(randomOffsetUpDown, 1, 0);
            clickIntervalOffsetTableLayout.Dock = DockStyle.Fill;
            clickIntervalOffsetTableLayout.Location = new Point(0, 56);
            clickIntervalOffsetTableLayout.Margin = new Padding(0);
            clickIntervalOffsetTableLayout.Name = "clickIntervalOffsetTableLayout";
            clickIntervalOffsetTableLayout.RowCount = 1;
            clickIntervalOffsetTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            clickIntervalOffsetTableLayout.Size = new Size(230, 28);
            clickIntervalOffsetTableLayout.TabIndex = 4;
            // 
            // randomOffsetLabel
            // 
            randomOffsetLabel.AutoSize = true;
            randomOffsetLabel.Dock = DockStyle.Fill;
            randomOffsetLabel.Location = new Point(3, 0);
            randomOffsetLabel.Name = "randomOffsetLabel";
            randomOffsetLabel.Size = new Size(147, 28);
            randomOffsetLabel.TabIndex = 0;
            randomOffsetLabel.Text = "Random offset (±msec)";
            randomOffsetLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // randomOffsetUpDown
            // 
            randomOffsetUpDown.Dock = DockStyle.Fill;
            randomOffsetUpDown.Location = new Point(156, 3);
            randomOffsetUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            randomOffsetUpDown.Name = "randomOffsetUpDown";
            randomOffsetUpDown.Size = new Size(71, 23);
            randomOffsetUpDown.TabIndex = 1;
            randomOffsetUpDown.TextAlign = HorizontalAlignment.Right;
            // 
            // clickOptionsGroup
            // 
            clickOptionsGroup.Controls.Add(clickOptionsTableLayout);
            clickOptionsGroup.Location = new Point(254, 124);
            clickOptionsGroup.Name = "clickOptionsGroup";
            clickOptionsGroup.Size = new Size(236, 134);
            clickOptionsGroup.TabIndex = 2;
            clickOptionsGroup.TabStop = false;
            clickOptionsGroup.Text = "Click options";
            // 
            // clickOptionsTableLayout
            // 
            clickOptionsTableLayout.ColumnCount = 2;
            clickOptionsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            clickOptionsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            clickOptionsTableLayout.Controls.Add(mouseButtonChooseLabel, 0, 0);
            clickOptionsTableLayout.Controls.Add(clickTypeChooseLabel, 0, 1);
            clickOptionsTableLayout.Controls.Add(mouseButtonChoose, 1, 0);
            clickOptionsTableLayout.Controls.Add(clickTypeChoose, 1, 1);
            clickOptionsTableLayout.Controls.Add(repeatModeLabel, 0, 2);
            clickOptionsTableLayout.Controls.Add(repeatCountLabel, 0, 3);
            clickOptionsTableLayout.Controls.Add(repeatModeChoose, 1, 2);
            clickOptionsTableLayout.Controls.Add(repeatCountUpDown, 1, 3);
            clickOptionsTableLayout.Dock = DockStyle.Fill;
            clickOptionsTableLayout.Location = new Point(3, 19);
            clickOptionsTableLayout.Name = "clickOptionsTableLayout";
            clickOptionsTableLayout.RowCount = 4;
            clickOptionsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            clickOptionsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            clickOptionsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            clickOptionsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            clickOptionsTableLayout.Size = new Size(230, 112);
            clickOptionsTableLayout.TabIndex = 0;
            // 
            // mouseButtonChooseLabel
            // 
            mouseButtonChooseLabel.AutoSize = true;
            mouseButtonChooseLabel.Dock = DockStyle.Fill;
            mouseButtonChooseLabel.Location = new Point(3, 0);
            mouseButtonChooseLabel.Name = "mouseButtonChooseLabel";
            mouseButtonChooseLabel.Size = new Size(109, 28);
            mouseButtonChooseLabel.TabIndex = 0;
            mouseButtonChooseLabel.Text = "Mouse button";
            mouseButtonChooseLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // clickTypeChooseLabel
            // 
            clickTypeChooseLabel.AutoSize = true;
            clickTypeChooseLabel.Dock = DockStyle.Fill;
            clickTypeChooseLabel.Location = new Point(3, 28);
            clickTypeChooseLabel.Name = "clickTypeChooseLabel";
            clickTypeChooseLabel.Size = new Size(109, 28);
            clickTypeChooseLabel.TabIndex = 1;
            clickTypeChooseLabel.Text = "Click type";
            clickTypeChooseLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mouseButtonChoose
            // 
            mouseButtonChoose.Dock = DockStyle.Fill;
            mouseButtonChoose.DropDownStyle = ComboBoxStyle.DropDownList;
            mouseButtonChoose.FormattingEnabled = true;
            mouseButtonChoose.Items.AddRange(new object[] { "Left", "Right", "Middle" });
            mouseButtonChoose.Location = new Point(118, 3);
            mouseButtonChoose.MaxDropDownItems = 3;
            mouseButtonChoose.Name = "mouseButtonChoose";
            mouseButtonChoose.Size = new Size(109, 23);
            mouseButtonChoose.TabIndex = 2;
            // 
            // clickTypeChoose
            // 
            clickTypeChoose.Dock = DockStyle.Fill;
            clickTypeChoose.DropDownStyle = ComboBoxStyle.DropDownList;
            clickTypeChoose.FormattingEnabled = true;
            clickTypeChoose.Items.AddRange(new object[] { "Single", "Double" });
            clickTypeChoose.Location = new Point(118, 31);
            clickTypeChoose.Name = "clickTypeChoose";
            clickTypeChoose.Size = new Size(109, 23);
            clickTypeChoose.TabIndex = 3;
            // 
            // repeatModeLabel
            // 
            repeatModeLabel.AutoSize = true;
            repeatModeLabel.Dock = DockStyle.Fill;
            repeatModeLabel.Location = new Point(3, 56);
            repeatModeLabel.Name = "repeatModeLabel";
            repeatModeLabel.Size = new Size(109, 28);
            repeatModeLabel.TabIndex = 4;
            repeatModeLabel.Text = "Repeat mode";
            repeatModeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // repeatCountLabel
            // 
            repeatCountLabel.AutoSize = true;
            repeatCountLabel.Dock = DockStyle.Fill;
            repeatCountLabel.Location = new Point(3, 84);
            repeatCountLabel.Name = "repeatCountLabel";
            repeatCountLabel.Size = new Size(109, 28);
            repeatCountLabel.TabIndex = 5;
            repeatCountLabel.Text = "Repeat count";
            repeatCountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // repeatModeChoose
            // 
            repeatModeChoose.Dock = DockStyle.Fill;
            repeatModeChoose.DropDownStyle = ComboBoxStyle.DropDownList;
            repeatModeChoose.FormattingEnabled = true;
            repeatModeChoose.Items.AddRange(new object[] { "Until stopped", "Fixed count" });
            repeatModeChoose.Location = new Point(118, 59);
            repeatModeChoose.Name = "repeatModeChoose";
            repeatModeChoose.Size = new Size(109, 23);
            repeatModeChoose.TabIndex = 6;
            // 
            // repeatCountUpDown
            // 
            repeatCountUpDown.Dock = DockStyle.Fill;
            repeatCountUpDown.Location = new Point(118, 87);
            repeatCountUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            repeatCountUpDown.Name = "repeatCountUpDown";
            repeatCountUpDown.Size = new Size(109, 23);
            repeatCountUpDown.TabIndex = 7;
            repeatCountUpDown.TextAlign = HorizontalAlignment.Right;
            // 
            // clickPositionTableLayout
            // 
            clickPositionTableLayout.ColumnCount = 2;
            clickPositionTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            clickPositionTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            clickPositionTableLayout.Controls.Add(positionTypeChooseLabel, 0, 0);
            clickPositionTableLayout.Controls.Add(positionTypeChoose, 1, 0);
            clickPositionTableLayout.Controls.Add(positionLabel, 0, 1);
            clickPositionTableLayout.Controls.Add(selectPositionLabel, 0, 2);
            clickPositionTableLayout.Controls.Add(selectedWindowLabel, 0, 3);
            clickPositionTableLayout.Controls.Add(selectedWindowButton, 1, 3);
            clickPositionTableLayout.Controls.Add(positionTableLayout, 1, 1);
            clickPositionTableLayout.Controls.Add(selectPositionButton, 1, 2);
            clickPositionTableLayout.Dock = DockStyle.Fill;
            clickPositionTableLayout.Location = new Point(3, 19);
            clickPositionTableLayout.Name = "clickPositionTableLayout";
            clickPositionTableLayout.RowCount = 4;
            clickPositionTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            clickPositionTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            clickPositionTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            clickPositionTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            clickPositionTableLayout.Size = new Size(230, 112);
            clickPositionTableLayout.TabIndex = 0;
            // 
            // positionTypeChooseLabel
            // 
            positionTypeChooseLabel.AutoSize = true;
            positionTypeChooseLabel.Dock = DockStyle.Fill;
            positionTypeChooseLabel.Location = new Point(3, 0);
            positionTypeChooseLabel.Name = "positionTypeChooseLabel";
            positionTypeChooseLabel.Size = new Size(109, 28);
            positionTypeChooseLabel.TabIndex = 0;
            positionTypeChooseLabel.Text = "Position type";
            positionTypeChooseLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // positionTypeChoose
            // 
            positionTypeChoose.Dock = DockStyle.Fill;
            positionTypeChoose.DropDownStyle = ComboBoxStyle.DropDownList;
            positionTypeChoose.FormattingEnabled = true;
            positionTypeChoose.Items.AddRange(new object[] { "Cursor", "Screen relative", "Window relative" });
            positionTypeChoose.Location = new Point(118, 3);
            positionTypeChoose.Name = "positionTypeChoose";
            positionTypeChoose.Size = new Size(109, 23);
            positionTypeChoose.TabIndex = 1;
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Dock = DockStyle.Fill;
            positionLabel.Location = new Point(3, 28);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(109, 28);
            positionLabel.TabIndex = 2;
            positionLabel.Text = "Position";
            positionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // selectPositionLabel
            // 
            selectPositionLabel.AutoSize = true;
            selectPositionLabel.Dock = DockStyle.Fill;
            selectPositionLabel.Location = new Point(3, 56);
            selectPositionLabel.Name = "selectPositionLabel";
            selectPositionLabel.Size = new Size(109, 28);
            selectPositionLabel.TabIndex = 5;
            selectPositionLabel.Text = "Select position";
            selectPositionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // selectedWindowLabel
            // 
            selectedWindowLabel.AutoSize = true;
            selectedWindowLabel.Dock = DockStyle.Fill;
            selectedWindowLabel.Location = new Point(3, 84);
            selectedWindowLabel.Name = "selectedWindowLabel";
            selectedWindowLabel.Size = new Size(109, 28);
            selectedWindowLabel.TabIndex = 7;
            selectedWindowLabel.Text = "Selected window";
            selectedWindowLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // selectedWindowButton
            // 
            selectedWindowButton.Dock = DockStyle.Fill;
            selectedWindowButton.Location = new Point(116, 85);
            selectedWindowButton.Margin = new Padding(1);
            selectedWindowButton.Name = "selectedWindowButton";
            selectedWindowButton.Size = new Size(113, 26);
            selectedWindowButton.TabIndex = 8;
            selectedWindowButton.Text = "Select...";
            selectedWindowButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            selectedWindowButton.UseVisualStyleBackColor = true;
            // 
            // positionTableLayout
            // 
            positionTableLayout.ColumnCount = 3;
            positionTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            positionTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 14F));
            positionTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            positionTableLayout.Controls.Add(positionXText, 0, 0);
            positionTableLayout.Controls.Add(positionYText, 2, 0);
            positionTableLayout.Controls.Add(positionSeparatorLabel, 1, 0);
            positionTableLayout.Location = new Point(115, 28);
            positionTableLayout.Margin = new Padding(0);
            positionTableLayout.Name = "positionTableLayout";
            positionTableLayout.RowCount = 1;
            positionTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            positionTableLayout.Size = new Size(115, 28);
            positionTableLayout.TabIndex = 9;
            // 
            // positionXText
            // 
            positionXText.Dock = DockStyle.Fill;
            positionXText.Location = new Point(3, 3);
            positionXText.Name = "positionXText";
            positionXText.Size = new Size(44, 23);
            positionXText.TabIndex = 4;
            positionXText.TextAlign = HorizontalAlignment.Center;
            // 
            // positionYText
            // 
            positionYText.Dock = DockStyle.Fill;
            positionYText.Location = new Point(67, 3);
            positionYText.Name = "positionYText";
            positionYText.Size = new Size(45, 23);
            positionYText.TabIndex = 6;
            positionYText.TextAlign = HorizontalAlignment.Center;
            // 
            // positionSeparatorLabel
            // 
            positionSeparatorLabel.AutoSize = true;
            positionSeparatorLabel.Dock = DockStyle.Fill;
            positionSeparatorLabel.Location = new Point(53, 0);
            positionSeparatorLabel.Name = "positionSeparatorLabel";
            positionSeparatorLabel.Size = new Size(8, 28);
            positionSeparatorLabel.TabIndex = 7;
            positionSeparatorLabel.Text = "X";
            positionSeparatorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // selectPositionButton
            // 
            selectPositionButton.Dock = DockStyle.Fill;
            selectPositionButton.Location = new Point(116, 57);
            selectPositionButton.Margin = new Padding(1);
            selectPositionButton.Name = "selectPositionButton";
            selectPositionButton.Size = new Size(113, 26);
            selectPositionButton.TabIndex = 10;
            selectPositionButton.Text = "Point...";
            selectPositionButton.UseVisualStyleBackColor = true;
            // 
            // clickPositionGroup
            // 
            clickPositionGroup.Controls.Add(clickPositionTableLayout);
            clickPositionGroup.Location = new Point(12, 124);
            clickPositionGroup.Name = "clickPositionGroup";
            clickPositionGroup.Size = new Size(236, 134);
            clickPositionGroup.TabIndex = 3;
            clickPositionGroup.TabStop = false;
            clickPositionGroup.Text = "Click position";
            // 
            // viewOptionsTableLayout
            // 
            viewOptionsTableLayout.ColumnCount = 2;
            viewOptionsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            viewOptionsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            viewOptionsTableLayout.Controls.Add(clickViewModeLabel, 0, 0);
            viewOptionsTableLayout.Controls.Add(clickViewModeChoose, 1, 0);
            viewOptionsTableLayout.Controls.Add(hotkeyLabel, 0, 1);
            viewOptionsTableLayout.Controls.Add(hotkeyButton, 1, 1);
            viewOptionsTableLayout.Controls.Add(recordControlLabel, 0, 2);
            viewOptionsTableLayout.Dock = DockStyle.Fill;
            viewOptionsTableLayout.Location = new Point(3, 19);
            viewOptionsTableLayout.Name = "viewOptionsTableLayout";
            viewOptionsTableLayout.RowCount = 3;
            viewOptionsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            viewOptionsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            viewOptionsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            viewOptionsTableLayout.Size = new Size(230, 84);
            viewOptionsTableLayout.TabIndex = 0;
            // 
            // clickViewModeLabel
            // 
            clickViewModeLabel.AutoSize = true;
            clickViewModeLabel.Dock = DockStyle.Fill;
            clickViewModeLabel.Enabled = false;
            clickViewModeLabel.Location = new Point(3, 0);
            clickViewModeLabel.Name = "clickViewModeLabel";
            clickViewModeLabel.Size = new Size(109, 28);
            clickViewModeLabel.TabIndex = 0;
            clickViewModeLabel.Text = "Click view mode";
            clickViewModeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // clickViewModeChoose
            // 
            clickViewModeChoose.Dock = DockStyle.Fill;
            clickViewModeChoose.DropDownStyle = ComboBoxStyle.DropDownList;
            clickViewModeChoose.Enabled = false;
            clickViewModeChoose.FormattingEnabled = true;
            clickViewModeChoose.Location = new Point(118, 3);
            clickViewModeChoose.Name = "clickViewModeChoose";
            clickViewModeChoose.Size = new Size(109, 23);
            clickViewModeChoose.TabIndex = 1;
            // 
            // hotkeyLabel
            // 
            hotkeyLabel.AutoSize = true;
            hotkeyLabel.Dock = DockStyle.Fill;
            hotkeyLabel.Location = new Point(3, 28);
            hotkeyLabel.Name = "hotkeyLabel";
            hotkeyLabel.Size = new Size(109, 28);
            hotkeyLabel.TabIndex = 2;
            hotkeyLabel.Text = "Start/stop hotkey";
            hotkeyLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // hotkeyButton
            // 
            hotkeyButton.Dock = DockStyle.Fill;
            hotkeyButton.Location = new Point(116, 29);
            hotkeyButton.Margin = new Padding(1);
            hotkeyButton.Name = "hotkeyButton";
            hotkeyButton.Size = new Size(113, 26);
            hotkeyButton.TabIndex = 3;
            hotkeyButton.Text = "Select...";
            hotkeyButton.UseVisualStyleBackColor = true;
            // 
            // recordControlLabel
            // 
            recordControlLabel.AutoSize = true;
            recordControlLabel.Dock = DockStyle.Fill;
            recordControlLabel.Enabled = false;
            recordControlLabel.Location = new Point(3, 56);
            recordControlLabel.Name = "recordControlLabel";
            recordControlLabel.Size = new Size(109, 28);
            recordControlLabel.TabIndex = 4;
            recordControlLabel.Text = "Record and replay";
            recordControlLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // miscOptionsGroup
            // 
            miscOptionsGroup.Controls.Add(viewOptionsTableLayout);
            miscOptionsGroup.Location = new Point(254, 12);
            miscOptionsGroup.Name = "miscOptionsGroup";
            miscOptionsGroup.Size = new Size(236, 106);
            miscOptionsGroup.TabIndex = 4;
            miscOptionsGroup.TabStop = false;
            miscOptionsGroup.Text = "Misc";
            // 
            // statusBar
            // 
            statusBar.Location = new Point(0, 269);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(500, 22);
            statusBar.SizingGrip = false;
            statusBar.TabIndex = 5;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 291);
            Controls.Add(statusBar);
            Controls.Add(miscOptionsGroup);
            Controls.Add(clickPositionGroup);
            Controls.Add(clickOptionsGroup);
            Controls.Add(clickIntervalGroup);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "AutoClickerNG";
            clickIntervalTimeTableLayout.ResumeLayout(false);
            clickIntervalTimeTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)minutesUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)millisecondsUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)secondsUpDown).EndInit();
            clickIntervalGroup.ResumeLayout(false);
            clickIntervalTableLayout.ResumeLayout(false);
            clickIntervalTableLayout.PerformLayout();
            clickIntervalOffsetTableLayout.ResumeLayout(false);
            clickIntervalOffsetTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)randomOffsetUpDown).EndInit();
            clickOptionsGroup.ResumeLayout(false);
            clickOptionsTableLayout.ResumeLayout(false);
            clickOptionsTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)repeatCountUpDown).EndInit();
            clickPositionTableLayout.ResumeLayout(false);
            clickPositionTableLayout.PerformLayout();
            positionTableLayout.ResumeLayout(false);
            positionTableLayout.PerformLayout();
            clickPositionGroup.ResumeLayout(false);
            viewOptionsTableLayout.ResumeLayout(false);
            viewOptionsTableLayout.PerformLayout();
            miscOptionsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown minutesUpDown;
        private NumericUpDown millisecondsUpDown;
        private NumericUpDown secondsUpDown;
        private ComboBox mouseButtonChoose;
        private ComboBox clickTypeChoose;
        private ComboBox positionTypeChoose;
        private TextBox positionXText;
        private TextBox positionYText;
        private Button selectedWindowButton;
        private ComboBox clickViewModeChoose;
        private NumericUpDown randomOffsetUpDown;
        private ComboBox repeatModeChoose;
        private NumericUpDown repeatCountUpDown;
        private Button hotkeyButton;
        private Button selectPositionButton;
        private StatusStrip statusBar;
        private Label secondsUpDownLabel;
        private Label millisecondsUpDownLabel;
        private Label minutesUpDownLabel;
        private Label randomOffsetLabel;
        private Label mouseButtonChooseLabel;
        private Label clickTypeChooseLabel;
        private Label repeatModeLabel;
        private Label repeatCountLabel;
        private Label positionTypeChooseLabel;
        private Label positionLabel;
        private Label selectPositionLabel;
        private Label selectedWindowLabel;
        private Label clickViewModeLabel;
        private Label hotkeyLabel;
        private Label recordControlLabel;
        private Label positionSeparatorLabel;
        private ErrorProvider errorProvider;
    }
}
