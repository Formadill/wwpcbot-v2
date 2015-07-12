using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wwpcbot_v2
{
    class Functionality
    {
        public static bool CustomCmdBool;
        public static bool CmdBool;
        public static bool CapBool;
        public static bool MemBool;
        public static bool TagBool;

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
    }
}
