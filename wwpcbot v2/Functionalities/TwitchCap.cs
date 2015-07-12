using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wwpcbot_v2;
using wwpcbot_v2.IRC;

namespace wwpcbot_v2.Functionalities
{
    class TwitchCap
    {
        public static void mainControl(bool mem, bool tag)
        {
            if (mem == true)
                ackMem();
            if (tag == true)
                ackTag();
        }

        private static void ackMem()
        {
            IRCconnect.sendData("CAP REQ :twitch.tv/membership" + "\r\n");
        }

        private static void ackTag()
        {
            IRCconnect.sendData("CAP REQ :twitch.tv/tags" + "\r\n");
        }
    }
}
