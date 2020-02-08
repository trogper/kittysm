/* 
 * Copyright (C) 2006,2007 David Riseley 
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */
using uk.org.riseley.puttySessionManager.control;
namespace uk.org.riseley.puttySessionManager.form
{
    partial class SessionManagerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionManagerForm));
            this.systrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.sysTrayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshSessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionHotkeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.synchronizeSessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSessionContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sessionTreeControl = new uk.org.riseley.puttySessionManager.control.SessionTreeControl();
            this.sessionListControl = new uk.org.riseley.puttySessionManager.control.SessionListControl();
            this.sysTrayContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // systrayIcon
            // 
            this.systrayIcon.ContextMenuStrip = this.sysTrayContextMenu;
            this.systrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("systrayIcon.Icon")));
            this.systrayIcon.Text = "KiTTY Session Manager";
            this.systrayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.systrayIcon_MouseClick);
            this.systrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.systrayIcon_MouseDoubleClick);
            // 
            // sysTrayContextMenu
            // 
            this.sysTrayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSessionToolStripMenuItem,
            this.displayTreeToolStripMenuItem,
            this.toolStripSeparator1,
            this.optionsToolStripMenuItem,
            this.refreshSessionsToolStripMenuItem,
            this.sessionEditorToolStripMenuItem,
            this.sessionHotkeysToolStripMenuItem,
            this.synchronizeSessionsToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.sysTrayContextMenu.Name = "sysTrayContextMenu";
            this.sysTrayContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.sysTrayContextMenu.ShowCheckMargin = true;
            this.sysTrayContextMenu.ShowImageMargin = false;
            this.sysTrayContextMenu.Size = new System.Drawing.Size(186, 214);
            // 
            // newSessionToolStripMenuItem
            // 
            this.newSessionToolStripMenuItem.Name = "newSessionToolStripMenuItem";
            this.newSessionToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.newSessionToolStripMenuItem.Text = "New Session";
            this.newSessionToolStripMenuItem.Click += new System.EventHandler(this.newSessionToolStripMenuItem_Click);
            // 
            // displayTreeToolStripMenuItem
            // 
            this.displayTreeToolStripMenuItem.Checked = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.DisplayTree;
            this.displayTreeToolStripMenuItem.CheckOnClick = true;
            this.displayTreeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.displayTreeToolStripMenuItem.Name = "displayTreeToolStripMenuItem";
            this.displayTreeToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.displayTreeToolStripMenuItem.Text = "&Display Tree";
            this.displayTreeToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.displayTreeToolStripMenuItem_CheckStateChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.sessionControl_ShowOptions);
            // 
            // refreshSessionsToolStripMenuItem
            // 
            this.refreshSessionsToolStripMenuItem.Name = "refreshSessionsToolStripMenuItem";
            this.refreshSessionsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.refreshSessionsToolStripMenuItem.Text = "&Refresh Sessions";
            this.refreshSessionsToolStripMenuItem.Click += new System.EventHandler(this.refreshSessionsToolStripMenuItem_Click);
            // 
            // sessionEditorToolStripMenuItem
            // 
            this.sessionEditorToolStripMenuItem.Name = "sessionEditorToolStripMenuItem";
            this.sessionEditorToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.sessionEditorToolStripMenuItem.Text = "Session &Editor";
            this.sessionEditorToolStripMenuItem.Click += new System.EventHandler(this.sessionEditorToolStripMenuItem_Click);
            // 
            // sessionHotkeysToolStripMenuItem
            // 
            this.sessionHotkeysToolStripMenuItem.Name = "sessionHotkeysToolStripMenuItem";
            this.sessionHotkeysToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.sessionHotkeysToolStripMenuItem.Text = "Session &Hotkeys";
            this.sessionHotkeysToolStripMenuItem.Click += new System.EventHandler(this.sessionHotkeysToolStripMenuItem_Click);
            // 
            // synchronizeSessionsToolStripMenuItem
            // 
            this.synchronizeSessionsToolStripMenuItem.Name = "synchronizeSessionsToolStripMenuItem";
            this.synchronizeSessionsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.synchronizeSessionsToolStripMenuItem.Text = "&Synchronize Sessions";
            this.synchronizeSessionsToolStripMenuItem.Click += new System.EventHandler(this.synchronizeSessionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(182, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.sessionControl_ShowAbout);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // loadSessionContextMenu
            // 
            this.loadSessionContextMenu.Name = "loadSessionContextMenu";
            this.loadSessionContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.loadSessionContextMenu.ShowImageMargin = false;
            this.loadSessionContextMenu.Size = new System.Drawing.Size(36, 4);
            // 
            // sessionTreeControl
            // 
            this.sessionTreeControl.ContextMenuVisible = true;
            this.sessionTreeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sessionTreeControl.Enabled = false;
            this.sessionTreeControl.Location = new System.Drawing.Point(0, 0);
            this.sessionTreeControl.Name = "sessionTreeControl";
            this.sessionTreeControl.Size = new System.Drawing.Size(264, 543);
            this.sessionTreeControl.TabIndex = 5;
            this.sessionTreeControl.Visible = false;
            this.sessionTreeControl.LaunchSession += new uk.org.riseley.puttySessionManager.control.SessionControl.LaunchSessionEventHandler(this.sessionControl_LaunchSession);
            this.sessionTreeControl.ExportSessions += new uk.org.riseley.puttySessionManager.control.SessionControl.ExportSessionEventHandler(this.sessionTreeControl1_ExportSessions);
            this.sessionTreeControl.DeleteSessions += new uk.org.riseley.puttySessionManager.control.SessionControl.DeleteSessionsEventHandler(this.sessionTreeControl1_DeleteSessions);
            // 
            // sessionListControl
            // 
            this.sessionListControl.ContextMenuVisible = true;
            this.sessionListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sessionListControl.Enabled = false;
            this.sessionListControl.Location = new System.Drawing.Point(0, 0);
            this.sessionListControl.Name = "sessionListControl";
            this.sessionListControl.Size = new System.Drawing.Size(264, 543);
            this.sessionListControl.TabIndex = 6;
            this.sessionListControl.Visible = false;
            this.sessionListControl.LaunchSession += new uk.org.riseley.puttySessionManager.control.SessionControl.LaunchSessionEventHandler(this.sessionControl_LaunchSession);
            // 
            // SessionManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 543);
            this.Controls.Add(this.sessionTreeControl);
            this.Controls.Add(this.sessionListControl);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Opacity", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "TransparencyValueDouble", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TopMost", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "AlwaysOnTop", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ShowInTaskbar", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "ShowInTaskbar", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SessionManagerForm";
            this.Opacity = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.TransparencyValueDouble;
            this.ShowInTaskbar = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.ShowInTaskbar;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "KiTTY Session Manager";
            this.TopMost = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.AlwaysOnTop;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SessionManagerForm_FormClosing);
            this.sysTrayContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon systrayIcon;
        private SessionTreeControl sessionTreeControl;
        private System.Windows.Forms.ContextMenuStrip sysTrayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private SessionListControl sessionListControl;
        private System.Windows.Forms.ToolStripMenuItem sessionEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshSessionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionHotkeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem synchronizeSessionsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip loadSessionContextMenu;
    }
}

