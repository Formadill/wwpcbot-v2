using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using wwpcbot_v2;
using wwpcbot_v2.IRC;
using wwpcbot_v2.TwitchInfo;
using wwpcbot_v2.SpeedruncomInfo;

namespace wwpcbot_v2.Commands
{
    class Functionality
    {
        public static bool TagBool;
        public static string Sender;
        public static tagInfo info;

        public static void CheckCmd(MainForm form)
        {
            string _data = IRCconnect._data.Remove(0,1);
            string data = _data.Substring(_data.IndexOf(IRCconnect.MainIRC.Channel + " :") + (IRCconnect.MainIRC.Channel + " :").Length);
            if (data.StartsWith("!"))
            {
                if (Properties.Settings.Default.CustomCmds == true)
                    Task.Factory.StartNew(() => CustomCommands.mainControl(data), CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext()).Wait();
                if (Properties.Settings.Default.SpeedrunCmds == true)
                    SpeedrunCmds.SayCmds(data);
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
