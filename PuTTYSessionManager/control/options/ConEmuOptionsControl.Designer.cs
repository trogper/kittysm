namespace uk.org.riseley.puttySessionManager.control.options
{
    partial class ConEmuOptionsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConEmuOptionsControl));
            this.conEmuTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.enableConEmuCheckBox = new System.Windows.Forms.CheckBox();
            this.locateConEmuCButton = new System.Windows.Forms.Button();
            this.conEmuCLocationTextBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.locateComEmuButton = new System.Windows.Forms.Button();
            this.conEmuLocationTextBox = new System.Windows.Forms.TextBox();
            this.conEmuTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // conEmuTableLayout
            // 
            this.conEmuTableLayout.ColumnCount = 2;
            this.conEmuTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.conEmuTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.conEmuTableLayout.Controls.Add(this.enableConEmuCheckBox, 0, 1);
            this.conEmuTableLayout.Controls.Add(this.locateConEmuCButton, 0, 3);
            this.conEmuTableLayout.Controls.Add(this.conEmuCLocationTextBox, 1, 3);
            this.conEmuTableLayout.Controls.Add(this.richTextBox1, 0, 0);
            this.conEmuTableLayout.Controls.Add(this.locateComEmuButton, 0, 2);
            this.conEmuTableLayout.Controls.Add(this.conEmuLocationTextBox, 1, 2);
            this.conEmuTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conEmuTableLayout.Location = new System.Drawing.Point(0, 0);
            this.conEmuTableLayout.Name = "conEmuTableLayout";
            this.conEmuTableLayout.RowCount = 5;
            this.conEmuTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.23684F));
            this.conEmuTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.76316F));
            this.conEmuTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.conEmuTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.conEmuTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.conEmuTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.conEmuTableLayout.Size = new System.Drawing.Size(442, 240);
            this.conEmuTableLayout.TabIndex = 0;
            // 
            // enableConEmuCheckBox
            // 
            this.enableConEmuCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.enableConEmuCheckBox.AutoSize = true;
            this.enableConEmuCheckBox.Checked = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.ConEmuEnabled;
            this.enableConEmuCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "ConEmuEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.enableConEmuCheckBox.Location = new System.Drawing.Point(3, 130);
            this.enableConEmuCheckBox.Name = "enableConEmuCheckBox";
            this.enableConEmuCheckBox.Size = new System.Drawing.Size(142, 17);
            this.enableConEmuCheckBox.TabIndex = 0;
            this.enableConEmuCheckBox.Text = "Enable ConEmu Support";
            this.enableConEmuCheckBox.UseVisualStyleBackColor = true;
            // 
            // locateConEmuCButton
            // 
            this.locateConEmuCButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.locateConEmuCButton.Location = new System.Drawing.Point(3, 182);
            this.locateConEmuCButton.Name = "locateConEmuCButton";
            this.locateConEmuCButton.Size = new System.Drawing.Size(170, 21);
            this.locateConEmuCButton.TabIndex = 1;
            this.locateConEmuCButton.Text = "Locate ConEmuC.exe";
            this.locateConEmuCButton.UseVisualStyleBackColor = true;
            this.locateConEmuCButton.Click += new System.EventHandler(this.locateConEmuCButton_Click);
            // 
            // conEmuCLocationTextBox
            // 
            this.conEmuCLocationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "ConEmuCLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.conEmuCLocationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conEmuCLocationTextBox.Location = new System.Drawing.Point(179, 182);
            this.conEmuCLocationTextBox.Name = "conEmuCLocationTextBox";
            this.conEmuCLocationTextBox.ReadOnly = true;
            this.conEmuCLocationTextBox.Size = new System.Drawing.Size(260, 20);
            this.conEmuCLocationTextBox.TabIndex = 2;
            this.conEmuCLocationTextBox.Text = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.ConEmuCLocation;
            // 
            // richTextBox1
            // 
            this.conEmuTableLayout.SetColumnSpan(this.richTextBox1, 2);
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(436, 119);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // locateComEmuButton
            // 
            this.locateComEmuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.locateComEmuButton.Location = new System.Drawing.Point(3, 155);
            this.locateComEmuButton.Name = "locateComEmuButton";
            this.locateComEmuButton.Size = new System.Drawing.Size(170, 21);
            this.locateComEmuButton.TabIndex = 6;
            this.locateComEmuButton.Text = "Locate ConEmu(64).exe";
            this.locateComEmuButton.UseVisualStyleBackColor = true;
            this.locateComEmuButton.Click += new System.EventHandler(this.locateConEmuButton_Click);
            // 
            // conEmuLocationTextBox
            // 
            this.conEmuLocationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "ConEmuLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.conEmuLocationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conEmuLocationTextBox.Location = new System.Drawing.Point(179, 155);
            this.conEmuLocationTextBox.Name = "conEmuLocationTextBox";
            this.conEmuLocationTextBox.ReadOnly = true;
            this.conEmuLocationTextBox.Size = new System.Drawing.Size(260, 20);
            this.conEmuLocationTextBox.TabIndex = 7;
            this.conEmuLocationTextBox.Text = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.ConEmuLocation;
            // 
            // ConEmuOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.conEmuTableLayout);
            this.Name = "ConEmuOptionsControl";
            this.Size = new System.Drawing.Size(442, 240);
            this.conEmuTableLayout.ResumeLayout(false);
            this.conEmuTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel conEmuTableLayout;
        private System.Windows.Forms.CheckBox enableConEmuCheckBox;
        private System.Windows.Forms.Button locateConEmuCButton;
        private System.Windows.Forms.TextBox conEmuCLocationTextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button locateComEmuButton;
        private System.Windows.Forms.TextBox conEmuLocationTextBox;
    }
}
