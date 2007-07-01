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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using uk.org.riseley.puttySessionManager.model;
using uk.org.riseley.puttySessionManager.controller;
using System.Text.RegularExpressions;


namespace uk.org.riseley.puttySessionManager.form
{
    public partial class HotkeyChooser : Form
    {
        private Form parentWindow;
        private SessionController sc;
        private HotkeyController hkc;

        // Setup dictionaries
        private Dictionary<HotkeyController.HotKeyId,ComboBox> comboDictionary;
        private Dictionary<HotkeyController.HotKeyId,TextBox>  textboxDictionary;
        private Dictionary<HotkeyController.HotKeyId,CheckBox> checkboxDictionary;

        public HotkeyChooser(Form parent)
        {
            parentWindow = parent;
            sc = SessionController.getInstance();
            hkc = HotkeyController.getInstance();
            InitializeComponent();
            createTags();
            createComboDictionary();
            createTextboxDictionary();
            createCheckboxDictionary();
            intialiseTextboxes();
            SessionController.SessionsRefreshedEventHandler scHandler = new SessionController.SessionsRefreshedEventHandler(this.SessionsRefreshed);
            sc.SessionsRefreshed += scHandler;
            EventHandler hkHandler = new EventHandler(setHotkeys);
            hkc.HotkeysRefreshed += hkHandler;
            hkc.registerAllEnabledHotkeys(parentWindow);
        }

        private void createTags()
        {
            comboBox1.Tag = HotkeyController.HotKeyId.HKID_SESSION_1;
            comboBox2.Tag = HotkeyController.HotKeyId.HKID_SESSION_2;
            comboBox3.Tag = HotkeyController.HotKeyId.HKID_SESSION_3;
            comboBox4.Tag = HotkeyController.HotKeyId.HKID_SESSION_4;
            comboBox5.Tag = HotkeyController.HotKeyId.HKID_SESSION_5;
            comboBox6.Tag = HotkeyController.HotKeyId.HKID_SESSION_6;
            comboBox7.Tag = HotkeyController.HotKeyId.HKID_SESSION_7;
            comboBox8.Tag = HotkeyController.HotKeyId.HKID_SESSION_8;
            comboBox9.Tag = HotkeyController.HotKeyId.HKID_SESSION_9;
            comboBox10.Tag = HotkeyController.HotKeyId.HKID_SESSION_10;

            checkBox1.Tag = HotkeyController.HotKeyId.HKID_SESSION_1;
            checkBox2.Tag = HotkeyController.HotKeyId.HKID_SESSION_2;
            checkBox3.Tag = HotkeyController.HotKeyId.HKID_SESSION_3;
            checkBox4.Tag = HotkeyController.HotKeyId.HKID_SESSION_4;
            checkBox5.Tag = HotkeyController.HotKeyId.HKID_SESSION_5;
            checkBox6.Tag = HotkeyController.HotKeyId.HKID_SESSION_6;
            checkBox7.Tag = HotkeyController.HotKeyId.HKID_SESSION_7;
            checkBox8.Tag = HotkeyController.HotKeyId.HKID_SESSION_8;
            checkBox9.Tag = HotkeyController.HotKeyId.HKID_SESSION_9;
            checkBox10.Tag = HotkeyController.HotKeyId.HKID_SESSION_10;
            newSessionHKCheckbox.Tag = HotkeyController.HotKeyId.HKID_NEW;
            minimizeWindowHKCheckbox.Tag = HotkeyController.HotKeyId.HKID_MINIMIZE;

            hk1TextBox.Tag = HotkeyController.HotKeyId.HKID_SESSION_1;
            hk2TextBox.Tag = HotkeyController.HotKeyId.HKID_SESSION_2;
            hk3TextBox.Tag = HotkeyController.HotKeyId.HKID_SESSION_3;
            hk4TextBox.Tag = HotkeyController.HotKeyId.HKID_SESSION_4;
            hk5TextBox.Tag = HotkeyController.HotKeyId.HKID_SESSION_5;
            hk6TextBox.Tag = HotkeyController.HotKeyId.HKID_SESSION_6;
            hk7TextBox.Tag = HotkeyController.HotKeyId.HKID_SESSION_7;
            hk8TextBox.Tag = HotkeyController.HotKeyId.HKID_SESSION_8;
            hk9TextBox.Tag = HotkeyController.HotKeyId.HKID_SESSION_9;
            hk10TextBox.Tag = HotkeyController.HotKeyId.HKID_SESSION_10;
            newSessionHKTextbox.Tag = HotkeyController.HotKeyId.HKID_NEW;
            minimizeWindowHKTextbox.Tag = HotkeyController.HotKeyId.HKID_MINIMIZE;
        }

        private void createComboDictionary()
        {
            comboDictionary = new Dictionary<HotkeyController.HotKeyId, ComboBox>();
            comboDictionary.Add((HotkeyController.HotKeyId)comboBox1.Tag, comboBox1);
            comboDictionary.Add((HotkeyController.HotKeyId)comboBox2.Tag, comboBox2);
            comboDictionary.Add((HotkeyController.HotKeyId)comboBox3.Tag, comboBox3);
            comboDictionary.Add((HotkeyController.HotKeyId)comboBox4.Tag, comboBox4);
            comboDictionary.Add((HotkeyController.HotKeyId)comboBox5.Tag, comboBox5);
            comboDictionary.Add((HotkeyController.HotKeyId)comboBox6.Tag, comboBox6);
            comboDictionary.Add((HotkeyController.HotKeyId)comboBox7.Tag, comboBox7);
            comboDictionary.Add((HotkeyController.HotKeyId)comboBox8.Tag, comboBox8);
            comboDictionary.Add((HotkeyController.HotKeyId)comboBox9.Tag, comboBox9);
            comboDictionary.Add((HotkeyController.HotKeyId)comboBox10.Tag, comboBox10);
        }

        private void createTextboxDictionary()
        {
            textboxDictionary = new Dictionary<HotkeyController.HotKeyId, TextBox>();
            textboxDictionary.Add((HotkeyController.HotKeyId)hk1TextBox.Tag, hk1TextBox);
            textboxDictionary.Add((HotkeyController.HotKeyId)hk2TextBox.Tag, hk2TextBox);
            textboxDictionary.Add((HotkeyController.HotKeyId)hk3TextBox.Tag, hk3TextBox);
            textboxDictionary.Add((HotkeyController.HotKeyId)hk4TextBox.Tag, hk4TextBox);
            textboxDictionary.Add((HotkeyController.HotKeyId)hk5TextBox.Tag, hk5TextBox);
            textboxDictionary.Add((HotkeyController.HotKeyId)hk6TextBox.Tag, hk6TextBox);
            textboxDictionary.Add((HotkeyController.HotKeyId)hk7TextBox.Tag, hk7TextBox);
            textboxDictionary.Add((HotkeyController.HotKeyId)hk8TextBox.Tag, hk8TextBox);
            textboxDictionary.Add((HotkeyController.HotKeyId)hk9TextBox.Tag, hk9TextBox);
            textboxDictionary.Add((HotkeyController.HotKeyId)hk10TextBox.Tag, hk10TextBox);
            textboxDictionary.Add((HotkeyController.HotKeyId)minimizeWindowHKTextbox.Tag, minimizeWindowHKTextbox);
            textboxDictionary.Add((HotkeyController.HotKeyId)newSessionHKTextbox.Tag, newSessionHKTextbox);
        }

        private void createCheckboxDictionary()
        {
            checkboxDictionary = new Dictionary<HotkeyController.HotKeyId, CheckBox>();
            checkboxDictionary.Add((HotkeyController.HotKeyId)checkBox1.Tag, checkBox1);
            checkboxDictionary.Add((HotkeyController.HotKeyId)checkBox2.Tag, checkBox2);
            checkboxDictionary.Add((HotkeyController.HotKeyId)checkBox3.Tag, checkBox3);
            checkboxDictionary.Add((HotkeyController.HotKeyId)checkBox4.Tag, checkBox4);
            checkboxDictionary.Add((HotkeyController.HotKeyId)checkBox5.Tag, checkBox5);
            checkboxDictionary.Add((HotkeyController.HotKeyId)checkBox6.Tag, checkBox6);
            checkboxDictionary.Add((HotkeyController.HotKeyId)checkBox7.Tag, checkBox7);
            checkboxDictionary.Add((HotkeyController.HotKeyId)checkBox8.Tag, checkBox8);
            checkboxDictionary.Add((HotkeyController.HotKeyId)checkBox9.Tag, checkBox9);
            checkboxDictionary.Add((HotkeyController.HotKeyId)checkBox10.Tag, checkBox10);
            checkboxDictionary.Add((HotkeyController.HotKeyId)minimizeWindowHKCheckbox.Tag, minimizeWindowHKCheckbox);
            checkboxDictionary.Add((HotkeyController.HotKeyId)newSessionHKCheckbox.Tag, newSessionHKCheckbox);
        }


        private void intialiseTextboxes()
        {
            foreach (TextBox t in textboxDictionary.Values)
            {
                t.Text = hkc.getHotKeyFromId((HotkeyController.HotKeyId)t.Tag);
            }
        }

        private void loadLists()
        {
            Session[] sa = sc.getSessionList().ToArray();
            ComboBox c;
            foreach (HotkeyController.HotKeyId hkid in comboDictionary.Keys)
            {
                comboDictionary.TryGetValue(hkid, out c);
                c.Items.AddRange(sa);
                c.SelectedItem = hkc.getSessionFromHotkey(hkid);
            }
        }

        private void setHotkeys(object source , EventArgs e)
        {
            ComboBox c;
            foreach (HotkeyController.HotKeyId hkid in comboDictionary.Keys)
            {
                comboDictionary.TryGetValue(hkid, out c);
                c.SelectedItem = hkc.getSessionFromHotkey(hkid);               
            }        
        }


        private void clearLists()
        {
            foreach (ComboBox c in comboDictionary.Values)
            {
                c.Items.Clear();
            }
        }


        private void okButton_Click(object sender, EventArgs e)
        {
            foreach (CheckBox c in checkboxDictionary.Values)
            {
                if (c.Checked == false)
                {
                    TextBox t = null;
                    HotkeyController.HotKeyId hkid = (HotkeyController.HotKeyId)c.Tag;
                    textboxDictionary.TryGetValue(hkid, out t);
                    if (t != null)
                        t.Text = hkc.getHotKeyFromId(hkid);
                }
            }
            this.Close();
        }

        private void hotkeyCheckbox_Click(object sender, EventArgs e)
        {
            // Get the checkbox that was clicked
            CheckBox cb = (CheckBox)sender;

            // Get the hotkey to adjust and the text box to query
            HotkeyController.HotKeyId hkid;
            TextBox tb = null;
            
            hkid = (HotkeyController.HotKeyId)cb.Tag;
            if (textboxDictionary.TryGetValue(hkid, out tb) == false)
            {
                // If we can't get the text box give up
                return;
            }

            // Unregister the hotkey if the box is unticked
            if (cb.Checked == false)
            {
                bool result = hkc.UnregisterHotKey(parentWindow, hkid);
                if (result == false)
                {
                    MessageBox.Show(this, "Failed to unregister hotkey"
                                   , "Warning"
                                   , MessageBoxButtons.OK
                                   , MessageBoxIcon.Warning);
                }
                tb.Text = hkc.getHotKeyFromId(hkid);
                hkc.refreshHotkeys();

                // Try to disable any associated combox box
                ComboBox cmb = null;
                comboDictionary.TryGetValue(hkid, out cmb);
                if (cb != null)
                    cb.Enabled = false;
            }
            else
            {
                if ( tb.Text.Length != 1 ) {
                    MessageBox.Show(this, "Hotkey must be specified"
                                   , "Warning"
                                   , MessageBoxButtons.OK
                                   , MessageBoxIcon.Warning);
                    tb.Text = hkc.getHotKeyFromId(hkid);
                    cb.Checked = false;
                } 
                else 
                {
                    char newHotkey = tb.Text.ToCharArray(0,1)[0];
                    if (hkc.isHotkeyAvailable(newHotkey) == false)
                    {
                        MessageBox.Show(this, "Hotkey may not be duplicated or D,E,F,L,M,R or U"
                                       , "Warning"
                                       , MessageBoxButtons.OK
                                       , MessageBoxIcon.Warning);
                        tb.Text = hkc.getHotKeyFromId(hkid);
                        cb.Checked = false;
                    }
                    else
                    {
                        bool result = hkc.RegisterHotkey(parentWindow, newHotkey, hkid);
                        if (result == false)
                        {
                            MessageBox.Show(this, "Failed to register hotkey"
                                           , "Warning"
                                           , MessageBoxButtons.OK
                                           , MessageBoxIcon.Warning);
                            tb.Text = hkc.getHotKeyFromId(hkid);
                            cb.Checked = false;
                        }
                        else
                        {
                            tb.Text = hkc.getHotKeyFromId(hkid);

                            // Try to enable any associated combox box
                            ComboBox cmb = null;
                            comboDictionary.TryGetValue(hkid, out cmb);
                            if (cb != null)
                                cb.Enabled = true;

                            hkc.refreshHotkeys();
                        }
                    }
                }                
            }
        }

        public void SessionsRefreshed(Object sender, EventArgs e)
        {
            clearLists();
            loadLists();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox c = (ComboBox)sender;
            Session s = (Session)c.SelectedItem;
            HotkeyController.HotKeyId hkid = (HotkeyController.HotKeyId)c.Tag;

            if (s == null || 
                Properties.Settings.Default.HotkeyFavouriteEnabled == false ||
                hkc.isSessionHotkeyEnabled(hkid) == false )
                return;

            hkc.saveSessionnameToHotkey(parentWindow, hkid, s);
        }

        private void favSessCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (favSessCheckBox.Checked == true)
            {
                foreach (HotkeyController.HotKeyId hkid in comboDictionary.Keys)
                {
                    if ( hkc.isSessionHotkeyEnabled(hkid) )
                        hkc.RegisterHotkey(parentWindow, hkid);
                }                
            }
            else
            {
                foreach (HotkeyController.HotKeyId hkid in comboDictionary.Keys)
                {
                    hkc.UnregisterHotKey(parentWindow, hkid);
                }                
            }
            hkc.setFavouriteSessionHotkeysEnabled(favSessCheckBox.Checked);
        }

        private void HotkeyChooser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Visible = false;
            }
        }
    }
}