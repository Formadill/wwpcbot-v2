using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wwpcbot_v2.API;
using wwpcbot_v2.IRC;

namespace wwpcbot_v2.Commands
{
    class YoutubeFunc
    {
        public static void mainControl(string message)
        {
            if (message.Contains("www.youtube.com/watch?v="))
                giveVideoInfo(message);

        }

        private static void giveVideoInfo(string message)
        {
            
            try
            {
                string _id = message.Substring(message.IndexOf("www.youtube.com/watch?v=") + ("www.youtube.com/watch?v=").Length);
                string id;
                try
                {
                    id = _id.Substring(0, _id.IndexOf(" "));
                }
                catch
                {
                    id = _id;
                }
                videoInfo info = YoutubeAPI.GetVideoInfo(id);
                IRCconnect.sendPrivMsg("Title: " + info.title + ", Uploader: " + info.creator + ", Views: " + info.views + ", Likes: +" + info.likes + "/-" + info.dislikes + ".");
            }
            catch
            {

            }
        }
    }
}
