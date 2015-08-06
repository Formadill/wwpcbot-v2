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
                giveVideoInfo(message, "www.youtube.com/watch?v=");
            else if(message.Contains("https://youtu.be/"))
                giveVideoInfo(message, "https://youtu.be/");

        }

        private static async void giveVideoInfo(string message, string link)
        {
            
            try
            {
                string _id = message.Substring(message.IndexOf(link) + (link).Length);
                string id;
                try
                {
                    id = _id.Substring(0, _id.IndexOf(" "));
                }
                catch
                {
                    id = _id;
                }
                videoInfo info = await YoutubeAPI.GetVideoInfo(id);
                IRCconnect.sendPrivMsg("Title: " + info.title + ", Uploader: " + info.creator + ", Views: " + info.views + ", Likes: +" + info.likes + "/-" + info.dislikes + ".");
            }
            catch
            {

            }
        }
    }
}
