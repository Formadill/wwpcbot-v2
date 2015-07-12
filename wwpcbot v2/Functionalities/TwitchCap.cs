using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wwpcbot_v2;
using wwpcbot_v2.IRC;

namespace wwpcbot_v2.Functionalities
{
    public struct tagInfo
    {
        public string color;
        public string display_name;
        public string emote_sets;
        public string subscriber;
        public string turbo;
        public string user_type;
    }

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

        public static tagInfo getTagValues(string tagsFull)
        {
            tagInfo info = new tagInfo();
            string[] tags = tagsFull.Split(';');
            int i = 0;
            foreach (string tag in tags)
            {
                tags[i] = tag.Substring(tag.IndexOf("=") + 1);
                i++;
            }
            info.color = tags[0];
            info.display_name = tags[1];
            info.emote_sets = tags[2];
            info.subscriber = tags[3];
            info.turbo = tags[4];
            info.user_type = tags[5];
            return info;
        }
    }
}
