using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using wwpcbot_v2;
using wwpcbot_v2.IRC;

namespace wwpcbot_v2.Functionalities
{
    class Functionality
    {
        public static bool CustomCmdBool;
        public static bool CmdBool;
        public static bool CapBool;
        public static bool MemBool;
        public static bool TagBool;
        public static string Sender;
        public static tagInfo info;

        public static void ActivateFunc(MainForm form)
        {
            //Task.Factory.StartNew(() => { new AddFunc().ShowDialog(); }).Wait();
            //if(CmdBool == true)
            //{
            //    IRCconnect.callCmdChk = true;
            //}
            if (CapBool == true)
            {
                TwitchCap.mainControl(MemBool, TagBool);
            }
        }

        public static void CheckCmd(MainForm form)
        {
            string _data = IRCconnect._data.Remove(0,1);
            string data = _data.Substring(_data.IndexOf(IRCconnect.MainIRC.Channel + " :") + (IRCconnect.MainIRC.Channel + " :").Length);
            if (data.StartsWith("!"))
            {
                Task.Factory.StartNew(() => CustomCommands.mainControl(data), CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
            }
            
        }

        public static void parseTags()
        {
            string _data = IRCconnect._data;
            if (_data.StartsWith("@color="))
            {
                string tags = _data.Substring(0, _data.IndexOf(" :"));
                info = TwitchCap.getTagValues(tags);
                
            }
        }

        public static void replaceEmotes()
        {
            Task.Factory.StartNew(TwitchEmotes.ReplaceEmotes, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext()).Wait();
        }
    }
}
