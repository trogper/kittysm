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

namespace uk.org.riseley.puttySessionManager.form
{
    public partial class RenameNameForm
        : Form
    {
        public RenameNameForm()
        {
            InitializeComponent();
            resetDialogFont();
        }

        public RenameNameForm(string oldName, bool isFolder)
            : this()
        {
            if (isFolder)
            {
                this.Text = "Enter Folder Name";
                nameLabel.Text = "Folder Name";
            }
            else
            {
                this.Text = "Enter Session Name";
                nameLabel.Text = "Session Name";
            }

            nameTextBox.Text = oldName;
        }

        public string getName()
        {
            return nameTextBox.Text;
        }

        public void resetDialogFont()
        {
            Font = Properties.Settings.Default.DialogFont;
        }
    }
}