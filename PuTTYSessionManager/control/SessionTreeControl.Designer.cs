/* 
 * Copyright (C) 2006 David Riseley 
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
using uk.org.riseley.puttySessionManager.model;

namespace uk.org.riseley.puttySessionManager.control
{
    partial class SessionTreeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionTreeControl));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Sessions");
            this.nodeContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newSessionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchSessionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchFolderAndSubfoldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshSessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lockSessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveNewSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSessionAsHotkeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotkey1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotkey2MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotkey3MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotkey4MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotkey5MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeImageList = new System.Windows.Forms.ImageList(this.components);
            this.treeView = new System.Windows.Forms.TreeView();
            this.nodeContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // nodeContextMenuStrip
            // 
            this.nodeContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSessionMenuItem,
            this.launchSessionMenuItem,
            this.launchFolderToolStripMenuItem,
            this.launchFolderAndSubfoldersToolStripMenuItem,
            this.refreshSessionsToolStripMenuItem,
            this.toolStripSeparator2,
            this.lockSessionsToolStripMenuItem,
            this.sessionManagementToolStripMenuItem});
            this.nodeContextMenuStrip.Name = "contextMenuStrip";
            this.nodeContextMenuStrip.Size = new System.Drawing.Size(228, 164);
            // 
            // newSessionMenuItem
            // 
            this.newSessionMenuItem.Name = "newSessionMenuItem";
            this.newSessionMenuItem.Size = new System.Drawing.Size(227, 22);
            this.newSessionMenuItem.Text = "New Session";
            this.newSessionMenuItem.Click += new System.EventHandler(this.newSessionMenuItem_Click);
            // 
            // launchSessionMenuItem
            // 
            this.launchSessionMenuItem.Name = "launchSessionMenuItem";
            this.launchSessionMenuItem.Size = new System.Drawing.Size(227, 22);
            this.launchSessionMenuItem.Text = "Launch Session";
            this.launchSessionMenuItem.Click += new System.EventHandler(this.launchSessionMenuItem_Click);
            // 
            // launchFolderToolStripMenuItem
            // 
            this.launchFolderToolStripMenuItem.Name = "launchFolderToolStripMenuItem";
            this.launchFolderToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.launchFolderToolStripMenuItem.Text = "Launch Folder ";
            this.launchFolderToolStripMenuItem.Click += new System.EventHandler(this.launchFolderToolStripMenuItem_Click);
            // 
            // launchFolderAndSubfoldersToolStripMenuItem
            // 
            this.launchFolderAndSubfoldersToolStripMenuItem.Name = "launchFolderAndSubfoldersToolStripMenuItem";
            this.launchFolderAndSubfoldersToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.launchFolderAndSubfoldersToolStripMenuItem.Text = "Launch Folder and Subfolders";
            this.launchFolderAndSubfoldersToolStripMenuItem.Click += new System.EventHandler(this.launchFolderAndSubfoldersToolStripMenuItem_Click);
            // 
            // refreshSessionsToolStripMenuItem
            // 
            this.refreshSessionsToolStripMenuItem.Name = "refreshSessionsToolStripMenuItem";
            this.refreshSessionsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshSessionsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.refreshSessionsToolStripMenuItem.Text = "Refresh Sessions";
            this.refreshSessionsToolStripMenuItem.Click += new System.EventHandler(this.refreshSessionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(224, 6);
            // 
            // lockSessionsToolStripMenuItem
            // 
            this.lockSessionsToolStripMenuItem.Checked = true;
            this.lockSessionsToolStripMenuItem.CheckOnClick = true;
            this.lockSessionsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lockSessionsToolStripMenuItem.Name = "lockSessionsToolStripMenuItem";
            this.lockSessionsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.lockSessionsToolStripMenuItem.Text = "Lock Sessions";
            this.lockSessionsToolStripMenuItem.Click += new System.EventHandler(this.lockSessionsToolStripMenuItem_Click);
            // 
            // sessionManagementToolStripMenuItem
            // 
            this.sessionManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFolderMenuItem,
            this.renameFolderMenuItem,
            this.toolStripSeparator1,
            this.deleteSessionToolStripMenuItem,
            this.exportSessionsToolStripMenuItem,
            this.renameSessionToolStripMenuItem,
            this.saveNewSessionToolStripMenuItem,
            this.setSessionAsHotkeyToolStripMenuItem});
            this.sessionManagementToolStripMenuItem.Name = "sessionManagementToolStripMenuItem";
            this.sessionManagementToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.sessionManagementToolStripMenuItem.Text = "Session Management";
            // 
            // newFolderMenuItem
            // 
            this.newFolderMenuItem.Enabled = false;
            this.newFolderMenuItem.Name = "newFolderMenuItem";
            this.newFolderMenuItem.Size = new System.Drawing.Size(192, 22);
            this.newFolderMenuItem.Text = "New Folder";
            this.newFolderMenuItem.Click += new System.EventHandler(this.newFolderMenuItem_Click);
            // 
            // renameFolderMenuItem
            // 
            this.renameFolderMenuItem.Enabled = false;
            this.renameFolderMenuItem.Name = "renameFolderMenuItem";
            this.renameFolderMenuItem.Size = new System.Drawing.Size(192, 22);
            this.renameFolderMenuItem.Text = "Rename Folder";
            this.renameFolderMenuItem.Click += new System.EventHandler(this.renameFolderMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // deleteSessionToolStripMenuItem
            // 
            this.deleteSessionToolStripMenuItem.Enabled = false;
            this.deleteSessionToolStripMenuItem.Name = "deleteSessionToolStripMenuItem";
            this.deleteSessionToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.deleteSessionToolStripMenuItem.Text = "Delete Sessions";
            this.deleteSessionToolStripMenuItem.Click += new System.EventHandler(this.deleteSessionToolStripMenuItem_Click);
            // 
            // exportSessionsToolStripMenuItem
            // 
            this.exportSessionsToolStripMenuItem.Name = "exportSessionsToolStripMenuItem";
            this.exportSessionsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.exportSessionsToolStripMenuItem.Text = "Export Sessions";
            this.exportSessionsToolStripMenuItem.Click += new System.EventHandler(this.exportSessionsToolStripMenuItem_Click);
            // 
            // renameSessionToolStripMenuItem
            // 
            this.renameSessionToolStripMenuItem.Enabled = false;
            this.renameSessionToolStripMenuItem.Name = "renameSessionToolStripMenuItem";
            this.renameSessionToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.renameSessionToolStripMenuItem.Text = "Rename Session";
            this.renameSessionToolStripMenuItem.Click += new System.EventHandler(this.renameSessionToolStripMenuItem_Click);
            // 
            // saveNewSessionToolStripMenuItem
            // 
            this.saveNewSessionToolStripMenuItem.Enabled = false;
            this.saveNewSessionToolStripMenuItem.Name = "saveNewSessionToolStripMenuItem";
            this.saveNewSessionToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.saveNewSessionToolStripMenuItem.Text = "Save New Session";
            this.saveNewSessionToolStripMenuItem.Click += new System.EventHandler(this.saveNewSessionToolStripMenuItem_Click);
            // 
            // setSessionAsHotkeyToolStripMenuItem
            // 
            this.setSessionAsHotkeyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotkey1MenuItem,
            this.hotkey2MenuItem,
            this.hotkey3MenuItem,
            this.hotkey4MenuItem,
            this.hotkey5MenuItem});
            this.setSessionAsHotkeyToolStripMenuItem.Enabled = false;
            this.setSessionAsHotkeyToolStripMenuItem.Name = "setSessionAsHotkeyToolStripMenuItem";
            this.setSessionAsHotkeyToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.setSessionAsHotkeyToolStripMenuItem.Text = "Set Session As Hotkey";
            // 
            // hotkey1MenuItem
            // 
            this.hotkey1MenuItem.Name = "hotkey1MenuItem";
            this.hotkey1MenuItem.Size = new System.Drawing.Size(117, 22);
            this.hotkey1MenuItem.Text = "Win+1";
            this.hotkey1MenuItem.Click += new System.EventHandler(this.hotkeyMenuItem_Click);
            // 
            // hotkey2MenuItem
            // 
            this.hotkey2MenuItem.Name = "hotkey2MenuItem";
            this.hotkey2MenuItem.Size = new System.Drawing.Size(117, 22);
            this.hotkey2MenuItem.Text = "Win+2";
            this.hotkey2MenuItem.Click += new System.EventHandler(this.hotkeyMenuItem_Click);
            // 
            // hotkey3MenuItem
            // 
            this.hotkey3MenuItem.Name = "hotkey3MenuItem";
            this.hotkey3MenuItem.Size = new System.Drawing.Size(117, 22);
            this.hotkey3MenuItem.Text = "Win+3";
            this.hotkey3MenuItem.Click += new System.EventHandler(this.hotkeyMenuItem_Click);
            // 
            // hotkey4MenuItem
            // 
            this.hotkey4MenuItem.Name = "hotkey4MenuItem";
            this.hotkey4MenuItem.Size = new System.Drawing.Size(117, 22);
            this.hotkey4MenuItem.Text = "Win+4";
            this.hotkey4MenuItem.Click += new System.EventHandler(this.hotkeyMenuItem_Click);
            // 
            // hotkey5MenuItem
            // 
            this.hotkey5MenuItem.Name = "hotkey5MenuItem";
            this.hotkey5MenuItem.Size = new System.Drawing.Size(117, 22);
            this.hotkey5MenuItem.Text = "Win+5";
            this.hotkey5MenuItem.Click += new System.EventHandler(this.hotkeyMenuItem_Click);
            // 
            // treeImageList
            // 
            this.treeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeImageList.ImageStream")));
            this.treeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.treeImageList.Images.SetKeyName(0, "Folder.gif");
            this.treeImageList.Images.SetKeyName(1, "SelectedFolder.gif");
            this.treeImageList.Images.SetKeyName(2, "Putty.gif");
            // 
            // treeView
            // 
            this.treeView.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::uk.org.riseley.puttySessionManager.Properties.Settings.Default, "TreeFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Font = global::uk.org.riseley.puttySessionManager.Properties.Settings.Default.TreeFont;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.treeImageList;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            treeNode1.ContextMenuStrip = this.nodeContextMenuStrip;
            treeNode1.Name = "SessionsNode";
            treeNode1.Text = "Sessions";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView.SelectedImageIndex = 1;
            this.treeView.Size = new System.Drawing.Size(205, 414);
            this.treeView.TabIndex = 0;
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseDoubleClick);
            this.treeView.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_DragDrop);
            this.treeView.DragOver += new System.Windows.Forms.DragEventHandler(this.treeView_DragOver);
            this.treeView.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.treeView_NodeMouseHover);
            this.treeView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseMove);
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            this.treeView.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView_DragEnter);
            this.treeView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView_ItemDrag);
            // 
            // SessionTreeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeView);
            this.DoubleBuffered = true;
            this.Name = "SessionTreeControl";
            this.Size = new System.Drawing.Size(205, 414);
            this.nodeContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ContextMenuStrip nodeContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem launchSessionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSessionMenuItem;
        private System.Windows.Forms.ImageList treeImageList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem lockSessionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem launchFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem launchFolderAndSubfoldersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshSessionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFolderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameFolderMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveNewSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSessionAsHotkeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotkey1MenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotkey2MenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotkey3MenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotkey4MenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotkey5MenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSessionsToolStripMenuItem;
    }
}