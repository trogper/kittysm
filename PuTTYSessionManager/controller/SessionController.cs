using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Permissions;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;


[assembly: RegistryPermissionAttribute(SecurityAction.RequestMinimum,
ViewAndModify = uk.org.riseley.puttySessionManager.model.SessionController.PUTTY_SESSIONS_REG_KEY)]

namespace uk.org.riseley.puttySessionManager.model
{

    public class SessionController
    {
        public const string PUTTY_SESSIONS_REG_KEY = "Software\\SimonTatham\\PuTTY\\Sessions";
        public const string PUTTY_PSM_FOLDER_VALUE = "PsmPath";
        private const string PUTTY_HOSTNAME_VALUE = "HostName";
        private const string PUTTY_USERNAME_VALUE = "UserName";
        private const string PUTTY_DEFAULT_SESSION = "Default%20Settings";

        private static List<Session> sessionList = new List<Session>();
        private static List<string> folderList = new List<string>();

        private static SessionController instance = null;

        public event SessionsRefreshedEventHandler SessionsRefreshed;
        public delegate void SessionsRefreshedEventHandler(object sender, RefreshSessionsEventArgs re);

        public static SessionController getInstance()
        {
            if (instance == null)
                instance = new SessionController();
            return instance;
        }

        private SessionController()
        {
            invalidateSessionList(this, true);
        }

        public List<Session> getSessionList()
        {
            return sessionList;
        }

        public List<string> getFolderList()
        {
            return folderList;
        }

        public List<string> getSessionAttributes(Session s)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(PUTTY_SESSIONS_REG_KEY + "\\" + s.SessionName);
            List<string> attributes = new List<string>();
            attributes.AddRange(rk.GetValueNames());
            attributes.Sort();
            return attributes;
        }

        public Session findDefaultSession()
        {
            return findSession(PUTTY_DEFAULT_SESSION);
        }

        public string findDefaultFolder()
        {
            return Session.SESSIONS_FOLDER_NAME;
        }

        public Session findDefaultSession(List<Session> sl)
        {
            return findSession(sl, PUTTY_DEFAULT_SESSION);
        }

        public Session findSession(string sessionName)
        {
            return findSession(sessionList, sessionName);
        }

        public Session findSession(List<Session> sl, string sessionName)
        {
            Session s = new Session(sessionName, "", false);
            int index = sl.BinarySearch(s);
            if (index >= 0)
                s = sessionList[index];
            else
                s = null;
            return s;
        }

        public void invalidateSessionList(Object sender, bool refreshSender)
        {
            lock (sessionList)
            {
                sessionList = getSessionListFromRegistry();
                folderList = getFolderListFromSessions(sessionList);
            }
            OnSessionsRefreshed(sender, new RefreshSessionsEventArgs(refreshSender));
        }

        private List<Session> getSessionListFromRegistry()
        {
            List<Session> sl = new List<Session>();

            RegistryKey rk = Registry.CurrentUser.OpenSubKey(PUTTY_SESSIONS_REG_KEY);

            foreach (string keyName in rk.GetSubKeyNames())
            {
                RegistryKey sessKey = rk.OpenSubKey(keyName);
                String psmpath = (String)sessKey.GetValue(PUTTY_PSM_FOLDER_VALUE);
                sessKey.Close();

                Session s = new Session(keyName, psmpath, false);

                sl.Add(s);

            }
            rk.Close();

            sl.Sort();


            return sl;
        }

        private List<string> getFolderListFromSessions(List<Session> sl)
        {
            List<string> fl = new List<string>();

            // Add the default folder
            fl.Add(Session.SESSIONS_FOLDER_NAME);

            foreach (Session s in sl)
            {
                if (fl.Contains(s.FolderName) == false)
                    fl.Add(s.FolderName);
            }

            fl.Sort();

            return fl;
        
        }


        public void saveFolderToRegistry(Session s)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(PUTTY_SESSIONS_REG_KEY + "\\" + s.SessionName, true);
            rk.SetValue(PUTTY_PSM_FOLDER_VALUE, s.FolderName, RegistryValueKind.String);
            rk.Close();
        }

        protected virtual void OnSessionsRefreshed(Object sender, RefreshSessionsEventArgs e)
        {
            if (SessionsRefreshed != null)
                SessionsRefreshed(sender, e);
        }

        public bool saveSessionsToFile(Session[] sessionArray, String fileName)
        {
            if (sessionArray.Length == 0)
                return false;
            using (StreamWriter sw = File.CreateText(fileName))
            {
                writeSessionExportHeader(sw);
                foreach (Session s in sessionArray)
                {
                    saveSession(s, sw);
                }
                sw.Close();
            }
            return true;
        }

        private void saveSession(Session s, StreamWriter sw)
        {
            sw.WriteLine("[" + Registry.CurrentUser.Name + "\\" + PUTTY_SESSIONS_REG_KEY + "\\" + s.SessionName + "]");
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(PUTTY_SESSIONS_REG_KEY + "\\" + s.SessionName);
            foreach (string valueName in rk.GetValueNames())
            {
                RegistryValueKind valueKind = rk.GetValueKind(valueName);
                if (valueKind.Equals(RegistryValueKind.String))
                {
                    sw.WriteLine("\"" + valueName + "\"=\"" + rk.GetValue(valueName).ToString().Replace("\\", "\\\\") + "\"");
                }
                else if (valueKind.Equals(RegistryValueKind.DWord))
                {
                    Object o = rk.GetValue(valueName);
                    string hex = ((int)o).ToString("x8");
                    sw.WriteLine("\"" + valueName + "\"=dword:" + hex);
                }

            }
            sw.WriteLine();
            rk.Close();

        }

        private void writeSessionExportHeader(StreamWriter sw)
        {
            sw.WriteLine("Windows Registry Editor Version 5.00");
            sw.WriteLine();
            sw.WriteLine("[" + Registry.CurrentUser.Name + "\\" + PUTTY_SESSIONS_REG_KEY + "]");
            sw.WriteLine();
        }

        public bool createNewSession(NewSessionRequest nsr, object sender)
        {
            // Check the template session is still there
            RegistryKey template = Registry.CurrentUser.OpenSubKey(PUTTY_SESSIONS_REG_KEY + "\\" + nsr.SessionTemplate.SessionName, false);
            if (template == null)
                return false;

            // Check no-one has created a new session with the same name
            RegistryKey newSession = Registry.CurrentUser.OpenSubKey(PUTTY_SESSIONS_REG_KEY + "\\" + nsr.SessionName, false);
            if (newSession != null)
            {
                newSession.Close();
                return false;
            }

            // Create the new session 
            newSession = Registry.CurrentUser.CreateSubKey (PUTTY_SESSIONS_REG_KEY + "\\" + nsr.SessionName.Replace(" ", "%20"));

            // Copy the values
            bool hostnameSet = false;
            bool foldernameSet = false;

            object value;
            foreach (string valueName in template.GetValueNames())
            {
                
                if ( valueName.Equals ( PUTTY_HOSTNAME_VALUE ) ) 
                {
                    hostnameSet = true;
                    value = nsr.Hostname;
                } 
                else if ( valueName.Equals ( PUTTY_PSM_FOLDER_VALUE ) )
                {
                    foldernameSet = true;
                    value = nsr.SessionFolder;
                }
                else if ( nsr.CopyDefaultUsername == false &&
                            valueName.Equals (PUTTY_USERNAME_VALUE) )
                {
                    value = "";
                } 
                else 
                {
                    value = template.GetValue(valueName);
                }

                newSession.SetValue(valueName,value,template.GetValueKind(valueName));
            }

            // Set the hostname if it hasn't already been set
            if ( hostnameSet == false )
                newSession.SetValue(PUTTY_HOSTNAME_VALUE, nsr.Hostname, RegistryValueKind.String);

            // Set the foldername if it hasn't already been set
            if ( foldernameSet == false )
                newSession.SetValue(PUTTY_PSM_FOLDER_VALUE, nsr.SessionFolder, RegistryValueKind.String);

            template.Close();
            newSession.Close();

            invalidateSessionList(sender, false);

            return true;
        }

        public bool deleteSessions(List<Session> sl)
        {
            // Can't delete the default session
            if (findSession(sl, PUTTY_DEFAULT_SESSION) != null)
            {
                return false;
            }

            // 
            foreach (Session s in sl)
            {
                Registry.CurrentUser.DeleteSubKey(PUTTY_SESSIONS_REG_KEY + "\\" + s.SessionName, false);
            }

            invalidateSessionList(this, true);

            return true;
        }

        public String launchSession(String sessionName)
        {
            String puttyExec = Properties.Settings.Default.PuttyLocation;
            Process p = new Process();
            p.StartInfo.FileName = puttyExec;
            p.StartInfo.Arguments = "-load \"" + sessionName + "\"";

            bool result = false;
            String errMsg = "";
            try
            {
                result = p.Start();
            }
            catch (Exception ex)
            {
                result = false;
                errMsg = ex.Message;
            }
            p.Close();

            return errMsg;
        }

        public bool renameSession(Session s, string newSessionName)
        {
            // Check the old session isn't the default session
            if (s.SessionName.Equals(PUTTY_DEFAULT_SESSION))
                return false;
            
            // Check the current session is still there
            RegistryKey current = Registry.CurrentUser.OpenSubKey(PUTTY_SESSIONS_REG_KEY + "\\" + s.SessionName, false);
            if (current == null)
                return false;

            // Check no-one has created a new session with the same name
            RegistryKey newSession = Registry.CurrentUser.OpenSubKey(PUTTY_SESSIONS_REG_KEY + "\\" + newSessionName, false);
            if (newSession != null)
            {
                newSession.Close();
                return false;
            }

            // Create the new session
            newSession = Registry.CurrentUser.CreateSubKey(PUTTY_SESSIONS_REG_KEY + "\\" + newSessionName);
            if (newSession == null)
                return false;

            // Copy all the attributes
            object value;
            foreach (string valueName in current.GetValueNames())
            {
                value = current.GetValue(valueName);
                newSession.SetValue(valueName, value, current.GetValueKind(valueName));
            }

            // Close the new session
            newSession.Close();

            // Close the current session;
            current.Close();

            // Delete the current session
            Registry.CurrentUser.DeleteSubKey(PUTTY_SESSIONS_REG_KEY + "\\" + s.SessionName);

            return true;
        }
    }



}
