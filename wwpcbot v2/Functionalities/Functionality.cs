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
        public static tagInfo info;

        public static void ActivateFunc(MainForm form)
        {
            Task.Factory.StartNew(() => { new AddFunc().ShowDialog(); }).Wait();
            if(CmdBool == true)
            {
                IRCconnect.callCmdChk = true;
            }
            if(CapBool == true)
            {
                TwitchCap.mainControl(MemBool, TagBool);
            }
        }

        public static void CheckCmd(MainForm form)
        {
            
            string _data = IRCconnect._data.Remove(0,1);
            string data = _data.Substring(_data.IndexOf(":") + 1);
            if (data.StartsWith("!"))
            {
                if (CustomCmdBool == true)
                    Task.Factory.StartNew(() => CustomCommands.mainControl(data));
            }
            
        }

        public static void parseTags()
        {
            string _data = IRCconnect._data;
            if (TagBool == true && _data.StartsWith("@color=") && _data.Contains(IRCconnect.MainIRC.Channel))
            {
                string tags = _data.Substring(0, _data.IndexOf(" :"));
                Console.WriteLine(tags);
                info = TwitchCap.getTagValues(tags);
                if (info.emote_sets != "")
                {
                    replaceEmotes();
                }
            }
        }

        private static void replaceEmotes()
        {
            Task.Factory.StartNew(TwitchEmotes.ReplaceEmotes, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext()).Wait();
        }
    }
}
