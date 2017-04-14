namespace uk.org.riseley.puttySessionManager.control.options
{
    partial class WinSCPOptionsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.useWinSCPIniCheckBox = new System.Windows.Forms.CheckBox();
            this.wsVerGroupBox = new System.Windows.Forms.GroupBox();
            this.wsVerTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.wsVer3RadioButton = new System.Windows.Forms.RadioButton();
            this.wsVer4RadioButton = new System.Windows.Forms.RadioButton();
            this.wsProtoGroupBox = new System.Windows.Forms.GroupBox();
            this.wsProtoTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.wsSessionGroupBox = new System.Windows.Forms.GroupBox();
            this.wsSessionTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.wsPrefGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.wsprefScpRadioButton = new System.Windows.Forms.RadioButton();
            this.wsprefSftpRadioButton = new System.Windows.Forms.RadioButton();
            this.wsGssCheckBox = new System.Windows.Forms.CheckBox();
            this.wsOptionGroupBox = new System.Windows.Forms.GroupBox();
            this.wsPrefTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.wsFtpRadioButton = new System.Windows.Forms.RadioButton();
            this.wsSftpRadioButton = new System.Windows.Forms.RadioButton();
            this.wsScpRadioButton = new System.Windows.Forms.RadioButton();
            this.wsOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.wsSessionInfoRadioButton = new System.Windows.Forms.RadioButton();
            this.winSCPTextBox = new System.Windows.Forms.TextBox();
            this.locateWinSCPButton = new System.Windows.Forms.Button();
            this.locateWinSCPIniButton = new System.Windows.Forms.Button();
            this.winSCPIniTextBox = new System.Windows.Forms.TextBox();
            this.enableWinSCPCheckBox = new System.Windows.Forms.CheckBox();
            this.wsTableLayout.SuspendLayout();
            this.wsVerGroupBox.SuspendLayout();
            this.wsVerTableLayout.SuspendLayout();
            this.wsProtoGroupBox.SuspendLayout();
            this.wsProtoTableLayout.SuspendLayout();
            this.wsSessionGroupBox.SuspendLayout();
            this.wsSessionTableLayout.SuspendLayout();
            this.wsPrefGroupBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.wsOptionGroupBox.SuspendLayout();
            this.wsPrefTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // wsTableLayout
            // 
            this.wsTableLayout.ColumnCount = 2;
            this.wsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.wsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.wsTableLayout.Controls.Add(this.useWinSCPIniCheckBox, 0, 2);
            this.wsTableLayout.Controls.Add(this.wsVerGroupBox, 0, 1);
            this.wsTableLayout.Controls.Add(this.wsProtoGroupBox, 1, 0);
            this.wsTableLayout.Controls.Add(this.winSCPTextBox, 1, 5);
            this.wsTableLayout.Controls.Add(this.locateWinSCPButton, 0, 5);
            this.wsTableLayout.Controls.Add(this.locateWinSCPIniButton, 0, 4);
            this.wsTableLayout.Controls.Add(this.winSCPIniTextBox, 1, 4);
            this.wsTableLayout.Controls.Add(this.enableWinSCPCheckBox, 0, 0);
            this.wsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wsTableLayout.Location = new System.Drawing.Point(0, 0);
            this.wsTableLayout.Name = "wsTableLayout";
            this.wsTableLayout.RowCount = 6;
            this.wsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.wsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.wsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.wsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.wsTableLayout.Size = new System.Drawing.Size(441, 240);
            this.wsTableLayout.TabIndex = 32;
            // 
            // useWinSCPIniCheckBox
            // 
            this.useWinSCPIniCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.useWinSCPIniCheckBox.AutoSize = true;
            this.useWinSCPIniCheckBox.Checked = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.WinSCPIniEnabled;
            this.useWinSCPIniCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "WinSCPIniEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.useWinSCPIniCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "WinSCPEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.useWinSCPIniCheckBox.Enabled = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.WinSCPEnabled;
            this.useWinSCPIniCheckBox.Location = new System.Drawing.Point(3, 156);
            this.useWinSCPIniCheckBox.Name = "useWinSCPIniCheckBox";
            this.useWinSCPIniCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.useWinSCPIniCheckBox.Size = new System.Drawing.Size(117, 17);
            this.useWinSCPIniCheckBox.TabIndex = 28;
            this.useWinSCPIniCheckBox.Text = "Use WinSCP ini file";
            this.optionsToolTip.SetToolTip(this.useWinSCPIniCheckBox, "Pass the /ini option to WinSCP.\r\nUse the ini file in the location specified below" +
        ".");
            this.useWinSCPIniCheckBox.UseVisualStyleBackColor = true;
            // 
            // wsVerGroupBox
            // 
            this.wsVerGroupBox.Controls.Add(this.wsVerTableLayout);
            this.wsVerGroupBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "WinSCPEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.wsVerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wsVerGroupBox.Enabled = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.WinSCPEnabled;
            this.wsVerGroupBox.Location = new System.Drawing.Point(3, 26);
            this.wsVerGroupBox.Name = "wsVerGroupBox";
            this.wsVerGroupBox.Size = new System.Drawing.Size(144, 43);
            this.wsVerGroupBox.TabIndex = 27;
            this.wsVerGroupBox.TabStop = false;
            this.wsVerGroupBox.Text = "WinSCP Version";
            // 
            // wsVerTableLayout
            // 
            this.wsVerTableLayout.ColumnCount = 2;
            this.wsVerTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.wsVerTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.wsVerTableLayout.Controls.Add(this.wsVer3RadioButton, 0, 0);
            this.wsVerTableLayout.Controls.Add(this.wsVer4RadioButton, 1, 0);
            this.wsVerTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wsVerTableLayout.Location = new System.Drawing.Point(3, 16);
            this.wsVerTableLayout.Name = "wsVerTableLayout";
            this.wsVerTableLayout.RowCount = 1;
            this.wsVerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.wsVerTableLayout.Size = new System.Drawing.Size(138, 24);
            this.wsVerTableLayout.TabIndex = 2;
            // 
            // wsVer3RadioButton
            // 
            this.wsVer3RadioButton.Location = new System.Drawing.Point(3, 3);
            this.wsVer3RadioButton.Name = "wsVer3RadioButton";
            this.wsVer3RadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wsVer3RadioButton.Size = new System.Drawing.Size(62, 17);
            this.wsVer3RadioButton.TabIndex = 0;
            this.wsVer3RadioButton.Text = "3.X";
            this.wsVer3RadioButton.UseVisualStyleBackColor = true;
            this.wsVer3RadioButton.CheckedChanged += new System.EventHandler(this.wsVerRadioButton_CheckedChanged);
            // 
            // wsVer4RadioButton
            // 
            this.wsVer4RadioButton.Checked = true;
            this.wsVer4RadioButton.Location = new System.Drawing.Point(72, 3);
            this.wsVer4RadioButton.Name = "wsVer4RadioButton";
            this.wsVer4RadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wsVer4RadioButton.Size = new System.Drawing.Size(62, 17);
            this.wsVer4RadioButton.TabIndex = 1;
            this.wsVer4RadioButton.TabStop = true;
            this.wsVer4RadioButton.Text = "4.X";
            this.wsVer4RadioButton.UseVisualStyleBackColor = true;
            this.wsVer4RadioButton.CheckedChanged += new System.EventHandler(this.wsVerRadioButton_CheckedChanged);
            // 
            // wsProtoGroupBox
            // 
            this.wsProtoGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wsProtoGroupBox.Controls.Add(this.wsProtoTableLayout);
            this.wsProtoGroupBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "WinSCPEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.wsProtoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wsProtoGroupBox.Enabled = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.WinSCPEnabled;
            this.wsProtoGroupBox.Location = new System.Drawing.Point(153, 3);
            this.wsProtoGroupBox.Name = "wsProtoGroupBox";
            this.wsTableLayout.SetRowSpan(this.wsProtoGroupBox, 3);
            this.wsProtoGroupBox.Size = new System.Drawing.Size(285, 170);
            this.wsProtoGroupBox.TabIndex = 26;
            this.wsProtoGroupBox.TabStop = false;
            this.wsProtoGroupBox.Text = "Protocol";
            // 
            // wsProtoTableLayout
            // 
            this.wsProtoTableLayout.ColumnCount = 2;
            this.wsProtoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.wsProtoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.wsProtoTableLayout.Controls.Add(this.wsSessionGroupBox, 0, 5);
            this.wsProtoTableLayout.Controls.Add(this.wsOptionGroupBox, 1, 5);
            this.wsProtoTableLayout.Controls.Add(this.wsOptionRadioButton, 1, 0);
            this.wsProtoTableLayout.Controls.Add(this.wsSessionInfoRadioButton, 0, 0);
            this.wsProtoTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wsProtoTableLayout.Location = new System.Drawing.Point(3, 16);
            this.wsProtoTableLayout.Name = "wsProtoTableLayout";
            this.wsProtoTableLayout.RowCount = 8;
            this.wsProtoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsProtoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsProtoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsProtoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsProtoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsProtoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsProtoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsProtoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.wsProtoTableLayout.Size = new System.Drawing.Size(279, 151);
            this.wsProtoTableLayout.TabIndex = 5;
            // 
            // wsSessionGroupBox
            // 
            this.wsSessionGroupBox.Controls.Add(this.wsSessionTableLayout);
            this.wsSessionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wsSessionGroupBox.Location = new System.Drawing.Point(3, 26);
            this.wsSessionGroupBox.Name = "wsSessionGroupBox";
            this.wsSessionGroupBox.Size = new System.Drawing.Size(161, 122);
            this.wsSessionGroupBox.TabIndex = 5;
            this.wsSessionGroupBox.TabStop = false;
            this.wsSessionGroupBox.Text = "Session Information";

            // 
            // wsSessionTableLayout
            // 
            this.wsSessionTableLayout.ColumnCount = 1;
            this.wsSessionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.wsSessionTableLayout.Controls.Add(this.wsPrefGroupBox, 0, 0);
            this.wsSessionTableLayout.Controls.Add(this.wsGssCheckBox, 0, 2);
            this.wsSessionTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wsSessionTableLayout.Location = new System.Drawing.Point(3, 16);
            this.wsSessionTableLayout.Name = "wsSessionTableLayout";
            this.wsSessionTableLayout.RowCount = 3;
            this.wsSessionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsSessionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsSessionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsSessionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.wsSessionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.wsSessionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.wsSessionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.wsSessionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.wsSessionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.wsSessionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.wsSessionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.wsSessionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.wsSessionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.wsSessionTableLayout.Size = new System.Drawing.Size(155, 103);
            this.wsSessionTableLayout.TabIndex = 5;

            // 
            // wsPrefGroupBox
            // 
            this.wsPrefGroupBox.Controls.Add(this.tableLayoutPanel3);
            this.wsPrefGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wsPrefGroupBox.Location = new System.Drawing.Point(3, 3);
            this.wsPrefGroupBox.Name = "wsPrefGroupBox";
            this.wsPrefGroupBox.Size = new System.Drawing.Size(154, 67);
            this.wsPrefGroupBox.TabIndex = 5;
            this.wsPrefGroupBox.TabStop = false;
            this.wsPrefGroupBox.Text = "Preferred Protocol";

            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.wsprefScpRadioButton, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.wsprefSftpRadioButton, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(148, 48);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // wsprefScpRadioButton
            // 
            this.wsprefScpRadioButton.AutoSize = true;
            this.wsprefScpRadioButton.Location = new System.Drawing.Point(3, 26);
            this.wsprefScpRadioButton.Name = "wsprefScpRadioButton";
            this.wsprefScpRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wsprefScpRadioButton.Size = new System.Drawing.Size(46, 17);
            this.wsprefScpRadioButton.TabIndex = 4;
            this.wsprefScpRadioButton.Text = "SCP";
            this.wsprefScpRadioButton.UseVisualStyleBackColor = true;
            this.wsprefScpRadioButton.CheckedChanged += new System.EventHandler(this.protocolRadioButton_CheckedChanged);
            // 
            // wsprefSftpRadioButton
            // 
            this.wsprefSftpRadioButton.AutoSize = true;
            this.wsprefSftpRadioButton.Checked = true;
            this.wsprefSftpRadioButton.Location = new System.Drawing.Point(3, 3);
            this.wsprefSftpRadioButton.Name = "wsprefSftpRadioButton";
            this.wsprefSftpRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wsprefSftpRadioButton.Size = new System.Drawing.Size(52, 17);
            this.wsprefSftpRadioButton.TabIndex = 3;
            this.wsprefSftpRadioButton.TabStop = true;
            this.wsprefSftpRadioButton.Text = "SFTP";
            this.wsprefSftpRadioButton.UseVisualStyleBackColor = true;
            this.wsprefSftpRadioButton.CheckedChanged += new System.EventHandler(this.protocolRadioButton_CheckedChanged);
            // 
            // wsGssCheckBox
            // 
            this.wsGssCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.wsGssCheckBox.AutoSize = true;
            this.wsGssCheckBox.Location = new System.Drawing.Point(3, 79);
            this.wsGssCheckBox.Name = "wsGssCheckBox";
            this.wsGssCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wsGssCheckBox.Size = new System.Drawing.Size(111, 17);
            this.wsGssCheckBox.TabIndex = 23;
            this.wsGssCheckBox.Text = "Use GSS Settings";
            this.wsGssCheckBox.UseVisualStyleBackColor = true;
            this.wsGssCheckBox.CheckedChanged += new System.EventHandler(this.protocolRadioButton_CheckedChanged);
            // 
            // wsOptionGroupBox
            // 
            this.wsOptionGroupBox.Controls.Add(this.wsPrefTableLayout);
            this.wsOptionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wsOptionGroupBox.Enabled = false;
            this.wsOptionGroupBox.Location = new System.Drawing.Point(170, 26);
            this.wsOptionGroupBox.Name = "wsOptionGroupBox";
            this.wsOptionGroupBox.Size = new System.Drawing.Size(106, 122);
            this.wsOptionGroupBox.TabIndex = 6;
            this.wsOptionGroupBox.TabStop = false;
            this.wsOptionGroupBox.Text = "Option";
            // 
            // wsPrefTableLayout
            // 
            this.wsPrefTableLayout.ColumnCount = 1;
            this.wsPrefTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.wsPrefTableLayout.Controls.Add(this.wsFtpRadioButton, 0, 4);
            this.wsPrefTableLayout.Controls.Add(this.wsSftpRadioButton, 0, 2);
            this.wsPrefTableLayout.Controls.Add(this.wsScpRadioButton, 0, 3);
            this.wsPrefTableLayout.Location = new System.Drawing.Point(6, 16);
            this.wsPrefTableLayout.Name = "wsPrefTableLayout";
            this.wsPrefTableLayout.RowCount = 5;
            this.wsPrefTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsPrefTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsPrefTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.wsPrefTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.wsPrefTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.wsPrefTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.wsPrefTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.wsPrefTableLayout.Size = new System.Drawing.Size(84, 103);
            this.wsPrefTableLayout.TabIndex = 5;
            // 
            // wsFtpRadioButton
            // 
            this.wsFtpRadioButton.AutoSize = true;
            this.wsFtpRadioButton.Location = new System.Drawing.Point(3, 49);
            this.wsFtpRadioButton.Name = "wsFtpRadioButton";
            this.wsFtpRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wsFtpRadioButton.Size = new System.Drawing.Size(63, 17);
            this.wsFtpRadioButton.TabIndex = 0;
            this.wsFtpRadioButton.Text = "FTP(21)";
            this.wsFtpRadioButton.UseVisualStyleBackColor = true;
            this.wsFtpRadioButton.CheckedChanged += new System.EventHandler(this.protocolRadioButton_CheckedChanged);
            // 
            // wsSftpRadioButton
            // 
            this.wsSftpRadioButton.AutoSize = true;
            this.wsSftpRadioButton.Checked = true;
            this.wsSftpRadioButton.Location = new System.Drawing.Point(3, 3);
            this.wsSftpRadioButton.Name = "wsSftpRadioButton";
            this.wsSftpRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wsSftpRadioButton.Size = new System.Drawing.Size(70, 17);
            this.wsSftpRadioButton.TabIndex = 1;
            this.wsSftpRadioButton.TabStop = true;
            this.wsSftpRadioButton.Text = "SFTP(22)";
            this.wsSftpRadioButton.UseVisualStyleBackColor = true;
            this.wsSftpRadioButton.CheckedChanged += new System.EventHandler(this.protocolRadioButton_CheckedChanged);
            // 
            // wsScpRadioButton
            // 
            this.wsScpRadioButton.AutoSize = true;
            this.wsScpRadioButton.Location = new System.Drawing.Point(3, 26);
            this.wsScpRadioButton.Name = "wsScpRadioButton";
            this.wsScpRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wsScpRadioButton.Size = new System.Drawing.Size(64, 17);
            this.wsScpRadioButton.TabIndex = 2;
            this.wsScpRadioButton.Text = "SCP(22)";
            this.wsScpRadioButton.UseVisualStyleBackColor = true;
            this.wsScpRadioButton.CheckedChanged += new System.EventHandler(this.protocolRadioButton_CheckedChanged);
            // 
            // wsOptionRadioButton
            // 
            this.wsOptionRadioButton.AutoSize = true;
            this.wsOptionRadioButton.Location = new System.Drawing.Point(170, 3);
            this.wsOptionRadioButton.Name = "wsOptionRadioButton";
            this.wsOptionRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wsOptionRadioButton.Size = new System.Drawing.Size(92, 17);
            this.wsOptionRadioButton.TabIndex = 3;
            this.wsOptionRadioButton.Text = "Option Setting";
            this.wsOptionRadioButton.UseVisualStyleBackColor = true;
            this.wsOptionRadioButton.CheckedChanged += new System.EventHandler(this.protocolRadioButton_CheckedChanged);
            // 
            // wsSessionInfoRadioButton
            // 
            this.wsSessionInfoRadioButton.AutoSize = true;
            this.wsSessionInfoRadioButton.Checked = true;
            this.wsSessionInfoRadioButton.Location = new System.Drawing.Point(3, 3);
            this.wsSessionInfoRadioButton.Name = "wsSessionInfoRadioButton";
            this.wsSessionInfoRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wsSessionInfoRadioButton.Size = new System.Drawing.Size(158, 17);
            this.wsSessionInfoRadioButton.TabIndex = 3;
            this.wsSessionInfoRadioButton.TabStop = true;
            this.wsSessionInfoRadioButton.Text = "Session Information Settings";
            this.wsSessionInfoRadioButton.UseVisualStyleBackColor = true;
            this.wsSessionInfoRadioButton.CheckedChanged += new System.EventHandler(this.protocolRadioButton_CheckedChanged);
            // 
            // winSCPTextBox
            // 
            this.winSCPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "WinSCPEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.winSCPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "WinSCPLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.winSCPTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winSCPTextBox.Enabled = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.WinSCPEnabled;
            this.winSCPTextBox.Location = new System.Drawing.Point(153, 209);
            this.winSCPTextBox.Name = "winSCPTextBox";
            this.winSCPTextBox.ReadOnly = true;
            this.winSCPTextBox.Size = new System.Drawing.Size(285, 20);
            this.winSCPTextBox.TabIndex = 24;
            this.winSCPTextBox.Text = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.WinSCPLocation;
            // 
            // locateWinSCPButton
            // 
            this.locateWinSCPButton.AutoSize = true;
            this.locateWinSCPButton.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "WinSCPEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.locateWinSCPButton.Enabled = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.WinSCPEnabled;
            this.locateWinSCPButton.Location = new System.Drawing.Point(3, 209);
            this.locateWinSCPButton.Name = "locateWinSCPButton";
            this.locateWinSCPButton.Size = new System.Drawing.Size(144, 24);
            this.locateWinSCPButton.TabIndex = 25;
            this.locateWinSCPButton.Text = "&Locate WinSCP*.exe";
            this.locateWinSCPButton.UseVisualStyleBackColor = true;
            this.locateWinSCPButton.Click += new System.EventHandler(this.locateWinSCPButton_Click);
            // 
            // locateWinSCPIniButton
            // 
            this.locateWinSCPIniButton.AutoSize = true;
            this.locateWinSCPIniButton.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "WinSCPEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.locateWinSCPIniButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locateWinSCPIniButton.Enabled = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.WinSCPEnabled;
            this.locateWinSCPIniButton.Location = new System.Drawing.Point(3, 179);
            this.locateWinSCPIniButton.Name = "locateWinSCPIniButton";
            this.locateWinSCPIniButton.Size = new System.Drawing.Size(144, 24);
            this.locateWinSCPIniButton.TabIndex = 29;
            this.locateWinSCPIniButton.Text = "&Locate WinSCP ini file";
            this.locateWinSCPIniButton.UseVisualStyleBackColor = true;
            this.locateWinSCPIniButton.Click += new System.EventHandler(this.locateWinSCPIniButton_Click);
            // 
            // winSCPIniTextBox
            // 
            this.winSCPIniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "WinSCPEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.winSCPIniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "WinSCPIniLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.winSCPIniTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winSCPIniTextBox.Enabled = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.WinSCPEnabled;
            this.winSCPIniTextBox.Location = new System.Drawing.Point(153, 179);
            this.winSCPIniTextBox.Name = "winSCPIniTextBox";
            this.winSCPIniTextBox.ReadOnly = true;
            this.winSCPIniTextBox.Size = new System.Drawing.Size(285, 20);
            this.winSCPIniTextBox.TabIndex = 30;
            this.winSCPIniTextBox.Text = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.WinSCPIniLocation;
            // 
            // enableWinSCPCheckBox
            // 
            this.enableWinSCPCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.enableWinSCPCheckBox.AutoSize = true;
            this.enableWinSCPCheckBox.Checked = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.WinSCPEnabled;
            this.enableWinSCPCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "WinSCPEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.enableWinSCPCheckBox.Location = new System.Drawing.Point(5, 3);
            this.enableWinSCPCheckBox.Name = "enableWinSCPCheckBox";
            this.enableWinSCPCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.enableWinSCPCheckBox.Size = new System.Drawing.Size(142, 17);
            this.enableWinSCPCheckBox.TabIndex = 23;
            this.enableWinSCPCheckBox.Text = "Enable WinSCP Support";
            this.enableWinSCPCheckBox.UseVisualStyleBackColor = true;
            // 
            // WinSCPOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wsTableLayout);
            this.Name = "WinSCPOptionsControl";
            this.Size = new System.Drawing.Size(441, 240);
            this.wsTableLayout.ResumeLayout(false);
            this.wsTableLayout.PerformLayout();
            this.wsVerGroupBox.ResumeLayout(false);
            this.wsVerTableLayout.ResumeLayout(false);
            this.wsProtoGroupBox.ResumeLayout(false);
            this.wsProtoTableLayout.ResumeLayout(false);
            this.wsProtoTableLayout.PerformLayout();
            this.wsSessionGroupBox.ResumeLayout(false);
            this.wsSessionTableLayout.ResumeLayout(false);
            this.wsSessionTableLayout.PerformLayout();
            this.wsPrefGroupBox.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.wsOptionGroupBox.ResumeLayout(false);
            this.wsPrefTableLayout.ResumeLayout(false);
            this.wsPrefTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel wsTableLayout;
        private System.Windows.Forms.CheckBox enableWinSCPCheckBox;
        private System.Windows.Forms.CheckBox useWinSCPIniCheckBox;
        private System.Windows.Forms.GroupBox wsVerGroupBox;
        private System.Windows.Forms.TableLayoutPanel wsVerTableLayout;
        private System.Windows.Forms.RadioButton wsVer3RadioButton;
        private System.Windows.Forms.RadioButton wsVer4RadioButton;
        private System.Windows.Forms.GroupBox wsProtoGroupBox;
        private System.Windows.Forms.RadioButton wsSessionInfoRadioButton;
        private System.Windows.Forms.RadioButton wsOptionRadioButton;
        private System.Windows.Forms.TextBox winSCPTextBox;
        private System.Windows.Forms.Button locateWinSCPButton;
        private System.Windows.Forms.Button locateWinSCPIniButton;
        private System.Windows.Forms.TextBox winSCPIniTextBox;
        private System.Windows.Forms.TableLayoutPanel wsProtoTableLayout;
        private System.Windows.Forms.GroupBox wsSessionGroupBox;
        private System.Windows.Forms.TableLayoutPanel wsSessionTableLayout;
        private System.Windows.Forms.GroupBox wsPrefGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton wsprefScpRadioButton;
        private System.Windows.Forms.RadioButton wsprefSftpRadioButton;
        private System.Windows.Forms.CheckBox wsGssCheckBox;
        private System.Windows.Forms.GroupBox wsOptionGroupBox;
        private System.Windows.Forms.TableLayoutPanel wsPrefTableLayout;
        private System.Windows.Forms.RadioButton wsFtpRadioButton;
        private System.Windows.Forms.RadioButton wsSftpRadioButton;
        private System.Windows.Forms.RadioButton wsScpRadioButton;
    }
}
