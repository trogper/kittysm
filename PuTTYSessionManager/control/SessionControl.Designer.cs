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
namespace uk.org.riseley.puttySessionManager.control
{
    partial class SessionControl
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.swtichDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshSessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionHotkeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.synchronizeSessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.swtichDisplayToolStripMenuItem,
            this.toolStripSeparator1,
            this.optionsToolStripMenuItem,
            this.refreshSessionsToolStripMenuItem,
            this.sessionEditorToolStripMenuItem,
            this.sessionHotkeysToolStripMenuItem,
            this.synchronizeSessionsToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(186, 214);
            // 
            // swtichDisplayToolStripMenuItem
            // 
            this.swtichDisplayToolStripMenuItem.Name = "swtichDisplayToolStripMenuItem";
            this.swtichDisplayToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.swtichDisplayToolStripMenuItem.Text = "Display List";
            this.swtichDisplayToolStripMenuItem.Click += new System.EventHandler(this.displayTreeToolStripMenuItem_Click);
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
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // refreshSessionsToolStripMenuItem
            // 
            this.refreshSessionsToolStripMenuItem.Name = "refreshSessionsToolStripMenuItem";
            this.refreshSessionsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshSessionsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.refreshSessionsToolStripMenuItem.Text = "Refresh Sessions";
            this.refreshSessionsToolStripMenuItem.Click += new System.EventHandler(this.refreshSessionsToolStripMenuItem_Click);
            // 
            // sessionEditorToolStripMenuItem
            // 
            this.sessionEditorToolStripMenuItem.Name = "sessionEditorToolStripMenuItem";
            this.sessionEditorToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.sessionEditorToolStripMenuItem.Text = "Session Editor";
            this.sessionEditorToolStripMenuItem.Click += new System.EventHandler(this.sessionEditorToolStripMenuItem_Click);
            // 
            // sessionHotkeysToolStripMenuItem
            // 
            this.sessionHotkeysToolStripMenuItem.Name = "sessionHotkeysToolStripMenuItem";
            this.sessionHotkeysToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.sessionHotkeysToolStripMenuItem.Text = "Session Hotkeys";
            this.sessionHotkeysToolStripMenuItem.Click += new System.EventHandler(this.sessionHotkeysToolStripMenuItem_Click);
            // 
            // synchronizeSessionsToolStripMenuItem
            // 
            this.synchronizeSessionsToolStripMenuItem.Name = "synchronizeSessionsToolStripMenuItem";
            this.synchronizeSessionsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.synchronizeSessionsToolStripMenuItem.Text = "Synchronize Sessions";
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
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // SessionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Name = "SessionControl";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem refreshSessionsToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem swtichDisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionHotkeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem synchronizeSessionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}
