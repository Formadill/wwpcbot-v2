using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using wwpcbot_v2.IRC;

namespace wwpcbot_v2.Commands
{
    class TwitchInfoCmds
    {
        public static void mainControl(string command)
        {
            if (command == "!uptime")
                uptimeCmd();
        }

        private static void uptimeCmd()
        {
            string url = "https://decapi.me/twitch/";
            var client = new RestClient(url);
            var request = new RestRequest("uptime.php?channel={channel}", Method.GET);
            request.AddParameter("channel", IRCconnect.MainIRC.Channel[MainForm.form.tabControl1.SelectedIndex].Remove(0, 1), ParameterType.UrlSegment);
            var result = client.Execute(request);
            if (result.Content != "Channel is not live.")
                IRCconnect.sendPrivMsg("This channel has been live for " + result.Content + ".");
            else
                IRCconnect.sendPrivMsg(result.Content);
        }
    }
}
