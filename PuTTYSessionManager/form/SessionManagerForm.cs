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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using uk.org.riseley.puttySessionManager.model;
using uk.org.riseley.puttySessionManager.model.eventargs;
using uk.org.riseley.puttySessionManager.controller;
using uk.org.riseley.puttySessionManager.control;
using System.Runtime.InteropServices;
using System.IO;

namespace uk.org.riseley.puttySessionManager.form
{
    public partial class SessionManagerForm : SessionManagementForm, IMessageFilter 
    {
        private Options optionsDialog;
        private AboutBox aboutDialog;
        private SessionEditorForm sessionEditor;
        private HotkeyChooser hotKeyChooser;
        private SynchronizeForm synchronizeForm;

        private SessionControl currentSessionControl;
        private SessionControl hiddenSessionControl;

        private HotkeyController hkc;

        private bool visibleState = false;

        private class User32
        {
            [DllImport("user32.dll")]
            private static extern bool SetForegroundWindow(IntPtr hWnd);

            [DllImport("User32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
            public static extern bool SetForegroundWindow(HandleRef hWnd);

            public static void SetForegroundWindow()
            {
                SetForegroundWindow(System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle);
            }

            public static void SetForegroundWindow(Form form)
            {
                SetForegroundWindow(new HandleRef(form, form.Handle));
            }

        }

        public SessionManagerForm()
            : base()
        {
            this.Visible = false;
            InitializeComponent();
            hkc = HotkeyController.getInstance();
            LoadLayout();
            SessionController.SessionsRefreshedEventHandler scHandler = new SessionController.SessionsRefreshedEventHandler(this.SessionsRefreshed);
            sc.SessionsRefreshed += scHandler;
            Application.AddMessageFilter(this);
            EventHandler dialogFontHandler = new EventHandler(this.dialogFontChanged);
            optionsDialog.DialogFontChanged += dialogFontHandler;
            SystemEvents.DisplaySettingsChanged += OnDisplaySettingsChanged;

            sessionTreeControl.LaunchAbout += sessionControl_ShowAbout;
            sessionTreeControl.LaunchOptions += sessionControl_ShowOptions;
            sessionTreeControl.LaunchSessionEditor += sessionEditorToolStripMenuItem_Click;
            sessionTreeControl.LaunchSessionHotkeys += sessionHotkeysToolStripMenuItem_Click;
            sessionTreeControl.LaunchSynchroniseSessions += synchronizeSessionsToolStripMenuItem_Click;
            sessionTreeControl.ExitRequest += exitToolStripMenuItem_Click;
            sessionTreeControl.SwitchDisplay += sessionTreeControl_SwitchDisplay;

            sessionListControl.LaunchAbout += sessionControl_ShowAbout;
            sessionListControl.LaunchOptions += sessionControl_ShowOptions;
            sessionListControl.LaunchSessionEditor += sessionEditorToolStripMenuItem_Click;
            sessionListControl.LaunchSessionHotkeys += sessionHotkeysToolStripMenuItem_Click;
            sessionListControl.LaunchSynchroniseSessions += synchronizeSessionsToolStripMenuItem_Click;
            sessionListControl.ExitRequest += exitToolStripMenuItem_Click;
            sessionListControl.SwitchDisplay += sessionListControl_SwitchDisplay;
        }

        /// <summary>
        /// Check PuTTY is accessible on startup
        /// and launch pageant if required
        /// </summary>
        public void doStartupActions()
        {
            // Check to see if PuTTY is accessible
            if (sc.isPuTTYExecutableAccessible() == false)
            {
                if (MessageBox.Show("PuTTY location is not accessible\n.Would you like to specify this now?"
                    , "Warning"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Warning
                    , MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    optionsDialog.ShowDialog();
                }
            }

            // Launch Pageant if required
            if (Properties.Settings.Default.LaunchPageantOnStart)
                sc.launchPageant();
        }

        private void LoadLayout()
        {
            optionsDialog = new Options(this);
            aboutDialog   = new AboutBox();
            sessionEditor = new SessionEditorForm();
            hotKeyChooser = new HotkeyChooser(this);
            synchronizeForm = new SynchronizeForm();

            // Attempt to override the system and taskbar tray icons
            string iconFile = Path.GetDirectoryName(Application.ExecutablePath) + "\\psm.ico";
            if (File.Exists(iconFile))
            {
                try
                {
                    Icon psmIcon = new Icon(iconFile);
                    systrayIcon.Icon = psmIcon;
                    this.Icon = psmIcon;
                }
                catch (Exception)
                {
                  // Do nothing
                }
            }

            if (Properties.Settings.Default.CloseToTray)
                systrayIcon.Visible = true;

            // Restore the size of the application
            this.ClientSize = Properties.Settings.Default.WindowSize;

            // Restore the location of the application
            Point savedLocation = Properties.Settings.Default.Location;

            // Get the screen that will display the point
            Screen display = Screen.FromPoint(savedLocation);

            // Check that the selected display contains the point
            // if not - restore the application in the top left hand corner
            if (display != null && display.Bounds.Contains(savedLocation))
                this.DesktopLocation = Properties.Settings.Default.Location;
            else
                this.DesktopLocation = new Point(0, 0);

            // Reset the display to either the tree or the list
            displayTreeToolStripMenuItem.Checked = Properties.Settings.Default.DisplayTree;

            // Register the new session hotkey if enabled
            if (Properties.Settings.Default.HotkeyNewEnabled)
                hkc.RegisterHotkey(this, HotkeyController.HotKeyId.HKID_NEW);

            // Register the minimize hotkey if enabled
            if (Properties.Settings.Default.HotkeyMinimizeEnabled)
                hkc.RegisterHotkey(this, HotkeyController.HotKeyId.HKID_MINIMIZE);

            // Invalidate the session list to force a refresh of all forms
            sc.invalidateSessionList(this, true); 

            // Expand the tree if requested on startup
            if (Properties.Settings.Default.ExpandTreeOnStartup)
                sessionTreeControl.expandFullTree();

            // Setup the display
            setDisplay();
        }

        private void SaveSize()
        {
            Properties.Settings.Default.WindowSize = this.ClientSize;
            Properties.Settings.Default.Location = this.DesktopLocation;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            confirmExit();
        }

        /// <summary>
        /// Comfirm exit if required
        /// </summary>
        private void confirmExit()
        {
            bool doExit = true;

            if (Properties.Settings.Default.ConfirmExit == true &&
                MessageBox.Show(this, "Exit application?"
                                   , "Exit"
                                   , MessageBoxButtons.YesNo
                                   , MessageBoxIcon.Question) == DialogResult.No)
            {
                doExit = false;
            }

            if (doExit)
                Exit();
        }
        
        public void Exit()
        {
            systrayIcon.Visible = false;
	        optionsDialog.Close();
	        aboutDialog.Close();
	        sessionEditor.Close();
	        hotKeyChooser.Close();
	        synchronizeForm.Close();
	        hkc.UnregisterAllHotKeys(this);
	        SaveSize();
	        Application.Exit();        
        }

        /// <summary>
        /// Event handler for double click event on the
        /// system tray icon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void systrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (loadSessionContextMenu.Visible == true)
            {
                loadSessionContextMenu.Visible = false;
            }
            switchApplicationVisibility();
        }

        /// <summary>
        /// Event handler for mouse click event on the
        /// system tray icon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void systrayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {   
                // This is a work around to prevent the taskbar icon
                // from displaying
                User32.SetForegroundWindow(this);
                loadSessionContextMenu.Show(Cursor.Position,ToolStripDropDownDirection.AboveLeft);
                loadSessionContextMenu.Visible = true;
            }
            else if (e.Button == MouseButtons.Middle)
            {
                switchApplicationVisibility();
            }
        }

        /// <summary>
        /// Helper to display the main window
        /// </summary>
        /// <param name="visible"></param>
        private void showApplication(bool visible)
        {
            visibleState = visible;

            if (Properties.Settings.Default.ShowInTaskbar == true)
            {
                Visible = true;
            }
            else
            {
                Visible = visibleState;
            }

            if (visibleState)
            {
                // If the window has been minimized
                // bring it back to it's normal size
                if (WindowState == FormWindowState.Minimized)
                    WindowState = FormWindowState.Normal;

                // Request focus in this window
                Activate();

                // Bring the window to the front
                User32.SetForegroundWindow();
            }
            else
            {
                WindowState = FormWindowState.Minimized;
            }


        }

        /// <summary>
        /// Allow other parts of the code to request display of the main window
        /// </summary>
        public void showApplication()
        {
            showApplication(true);
        }

        /// <summary>
        /// Allow other parts of the code to request hide of the main window
        /// </summary>
        public void hideApplication()
        {
            if (Properties.Settings.Default.CloseToTray)
                showApplication(false);
            else
                Exit();
        }

        /// <summary>
        /// Allow other parts of the code to switch the visibility of the main window
        /// </summary>
        public void switchApplicationVisibility()
        {
            showApplication((visibleState==false));
        }

        private void sessionControl_LaunchSession(object sender, LaunchSessionEventArgs se)
        {
            if (se != null)
            {
                if (se.program == LaunchSessionEventArgs.PROGRAM.PUTTY)
                {
                    String errMsg = sc.launchSession(se.SessionName());
                    if (errMsg.Equals("") == false)
                    {
                        MessageBox.Show("KiTTY Failed to start.\nCheck the PuTTY location in System Tray -> Options.\n" +
                                        errMsg
                        , "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (se.program == LaunchSessionEventArgs.PROGRAM.PSFTP)
                {
                    String errMsg = sc.launchPSFTP(se.SessionName());
                    if (errMsg.Equals("") == false)
                    {
                        MessageBox.Show("PSFTP Failed to start.\nCheck the PSFTP location in System Tray -> Options.\n" +
                                        errMsg
                        , "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (se.program == LaunchSessionEventArgs.PROGRAM.FILEZILLA)
                {
                    String errMsg = sc.launchOtherSession(se.session, se.program);
                    if (errMsg.Equals("") == false)
                    {
                        MessageBox.Show("FileZilla Failed to start.\nCheck the FileZilla location in System Tray -> Options.\n" +
                                        errMsg
                        , "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (se.program == LaunchSessionEventArgs.PROGRAM.WINSCP)
                {
                    String errMsg = sc.launchOtherSession(se.session, se.program);
                    if (errMsg.Equals("") == false)
                    {
                        MessageBox.Show("WinSCP Failed to start.\nCheck the WinSCP location in System Tray -> Options.\n" +
                                        errMsg
                        , "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void sessionTreeControl_SwitchDisplay(object sender, EventArgs e)
        {
            displayTreeToolStripMenuItem.Checked = false;
        }

        private void sessionListControl_SwitchDisplay(object sender, EventArgs e)
        {
            displayTreeToolStripMenuItem.Checked = true;
        }

        private void displayTreeToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            setDisplay();
        }

        private void setDisplay()
        {

            if (displayTreeToolStripMenuItem.Checked == true)
            {
                currentSessionControl = sessionTreeControl;
                hiddenSessionControl = sessionListControl;
            }
            else
            {
                currentSessionControl = sessionListControl;
                hiddenSessionControl = sessionTreeControl;            
            }

            this.SuspendLayout();
            
            currentSessionControl.Enabled = true;
            currentSessionControl.Visible = true;
            hiddenSessionControl.Enabled = false;
            hiddenSessionControl.Visible = false;
                       
            this.ResumeLayout(true);

            currentSessionControl.getSessionMenuItems(loadSessionContextMenu, loadSessionContextMenu.Items);          

            Properties.Settings.Default.DisplayTree = displayTreeToolStripMenuItem.Checked;

        }

        /// <summary>
        /// A message filter to listen for escape key and hotkey events
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public bool PreFilterMessage(ref Message m)
        {
            // Quick filter to ignore events we're not interested in
            if (m.Msg != hkc.WM_KEYDOWN &&
                m.Msg != hkc.WM_HOTKEY  )
                return false;

            Keys keyCode = (Keys)(int)m.WParam & Keys.KeyCode;
            if (m.Msg == hkc.WM_KEYDOWN &&
                keyCode == Keys.Escape &&
                this.visibleState == true &&
                this.ContainsFocus == true )
            {
                hideApplication();
            }
            else if (m.Msg == hkc.WM_HOTKEY)
            {
                processHotKey((int)m.WParam);
            }
            else
            {
                return false;
            }
            return true;
        } 

        /// <summary>
        /// Process the hotkey event
        /// </summary>
        /// <param name="id">The hotkey that was pressed</param>
        private void processHotKey(int id)
        {
            // If it's the minimize hotkey switch the display state
            if (id == (int)HotkeyController.HotKeyId.HKID_MINIMIZE)
            {
                switchApplicationVisibility();                
                return;
            }

            // Otherwise figure out which session to launch
            Session s = hkc.getSessionFromHotkey((HotkeyController.HotKeyId)id);
            sessionControl_LaunchSession(this, new LaunchSessionEventArgs(s));
        }

        public void SessionsRefreshed(object sender, RefreshSessionsEventArgs re)
        {
            currentSessionControl.getSessionMenuItems(loadSessionContextMenu, loadSessionContextMenu.Items);
        }

        private void refreshSessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sc.invalidateSessionList(this, true); 
        }

        private void sessionControl_ShowAbout(object sender, EventArgs e)
        {
            if (aboutDialog.Visible == false)
            {
                aboutDialog.ShowDialog();
            }
            else
            {
                aboutDialog.BringToFront();
            }
        }

        private void sessionControl_ShowOptions(object sender, EventArgs e)
        {
            if (optionsDialog.Visible == false)
            {
                optionsDialog.ShowDialog();
            }
            else
            {
                optionsDialog.BringToFront();
            }
        }

        private void sessionEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sessionEditor.Show();
        }

        private void sessionHotkeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hotKeyChooser.Show();
        }

        private void sessionTreeControl1_ExportSessions(object sender, ExportSessionEventArgs se)
        {
            exportSessions(currentSessionControl.getSelectedSessions(),se);
        }

        private void sessionTreeControl1_BackupSessions(object sender, EventArgs e)
        {
            backupSessions(currentSessionControl.getSelectedSessions());
        }

        private void sessionTreeControl1_DeleteSessions(object sender, CancelEventArgs ce)
        {
            bool result = deleteSessions(currentSessionControl.getSelectedSessions(), sender);
            // if the delete failed or aborted cancel the event
            ce.Cancel = !(result);
        }

        /// <summary>
        /// Event handler for SessionManagerForm FormClosing event
        /// Cancel the close if it was requested by the user and just
        /// hide the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SessionManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Properties.Settings.Default.CloseToTray)
                Exit();

            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                showApplication(false);

                // Make sure the systray icon is visible
                if (systrayIcon.Visible == false)
                    systrayIcon.Visible = true;
            }
        }

        /// <summary>
        /// Event handler for the newSessionToolStripMenuItem click event
        /// Launches an empty PuTTY Session
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sessionControl_LaunchSession(this, new LaunchSessionEventArgs());
        }

        private void synchronizeSessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synchronizeForm.Show();
        }

        private void dialogFontChanged(object sender, EventArgs e)
        {
            aboutDialog.resetDialogFont();    
            sessionEditor.resetDialogFont();
            hotKeyChooser.resetDialogFont();
            synchronizeForm.resetDialogFont();
            sessionTreeControl.resetDialogFont();
            sessionListControl.resetDialogFont();
        }

        private void OnDisplaySettingsChanged(object sender, EventArgs e)
        {
            bool visible = false;
            foreach (Screen s in Screen.AllScreens)
            {
                if (s.WorkingArea.Contains(this.Location))
                {
                    visible = true;
                }
            }

            if (!visible)
            {
                this.SetDesktopLocation(Screen.PrimaryScreen.Bounds.Location.X, Screen.PrimaryScreen.Bounds.Location.Y);
            }
        }
    }
}