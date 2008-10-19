/* 
 * Copyright (C) 2008 David Riseley 
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
using uk.org.riseley.puttySessionManager.control;
using uk.org.riseley.puttySessionManager.controller;
using uk.org.riseley.puttySessionManager.model.eventargs;

namespace uk.org.riseley.puttySessionManager.form
{
    public partial class SynchronizeForm : SessionManagementForm
    {
        public SynchronizeForm()
            :base()
        {
            InitializeComponent();
            SessionController.SessionsRefreshedEventHandler scHandler = new SessionController.SessionsRefreshedEventHandler(this.SessionsRefreshed);
            sc.SessionsRefreshed += scHandler;
        }

        private void SynchronizeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        public void SessionsRefreshed(Object sender, EventArgs e)
        {
            optionsControl1.loadList(sc.getSessionList().ToArray(), sc.findDefaultSession(false));
        }

        private void optionsControl1_SyncSessionsLoaded(object sender, SyncSessionsLoadedEventArgs e)
        {
            tableControl1.LoadSessions(e);
            tabControl1.SelectTab(1);
        }
    }
}