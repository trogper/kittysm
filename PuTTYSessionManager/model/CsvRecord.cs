/* 
 * Copyright (C) 2007 David Riseley 
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
using System.Text;
using FileHelpers;
using FileHelpers.Events;

namespace uk.org.riseley.puttySessionManager.model
{
    [IgnoreEmptyLines()]
    [DelimitedRecord(",")]
    [IgnoreFirst]
    public sealed class CsvRecord : INotifyRead
    {

        public CsvRecord()
        {
        }

        public CsvRecord(Session s)
        {
            SessionName = s.SessionDisplayText;
            FolderName = s.FolderName;
            Username = s.Username;
            Hostname = s.Hostname;
            Protocol = s.Protocol;
            Portnumber = s.Portnumber;
        }

        [FieldQuoted('"', QuoteMode.OptionalForRead, MultilineMode.AllowForRead)]
        [FieldOrder(1)]
        private String sessionName;

        public String SessionName
        {
            get { return sessionName; }
            set { sessionName = value; }
        }

        [FieldQuoted('"', QuoteMode.OptionalForRead, MultilineMode.AllowForRead)]
        [FieldOrder(2)]
        private String folderName;

        public String FolderName
        {
            get { return folderName; }
            set { folderName = value; }
        }

        [FieldQuoted('"', QuoteMode.OptionalForRead, MultilineMode.AllowForRead)]
        [FieldOrder(3)]
        private String username;

        public String Username
        {
            get { return username; }
            set { username = value; }
        }

        [FieldQuoted('"', QuoteMode.OptionalForRead, MultilineMode.AllowForRead)]
        [FieldOrder(4)]
        private String hostname;

        public String Hostname
        {
            get { return hostname; }
            set { hostname = value; }
        }

        [FieldQuoted('"', QuoteMode.OptionalForRead, MultilineMode.AllowForRead)]
        [FieldOrder(5)]
        private String protocol;

        public String Protocol
        {
            get { return protocol; }
            set { protocol = value; }
        }

        [FieldQuoted('"', QuoteMode.OptionalForRead, MultilineMode.AllowForRead)]
        [FieldOrder(6)]
        private int portnumber;

        public int Portnumber
        {
            get { return portnumber; }
            set { portnumber = value; }
        }

        public void AfterRead(AfterReadEventArgs e)
        {
        }

        /**
         * Skip commented lines in the source file
         */
        public void BeforeRead(BeforeReadEventArgs e)
        {
            if (e.RecordLine.StartsWith("#"))
            {
                e.SkipThisRecord = true;
            }
        }
    }
}
