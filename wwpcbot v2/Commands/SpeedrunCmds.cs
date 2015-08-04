using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wwpcbot_v2.API;
using wwpcbot_v2.IRC;

namespace wwpcbot_v2.Commands
{
    class SpeedrunCmds
    {
        public static void mainControl(string command)
        {
            if (command == "!wr")
                WRCmd();
        }

        private static async void WRCmd()
        {
            var tuple = await GetSpeedrunInfo.GetWR(await GetStrmInfo.GetGame(IRCconnect.MainIRC.Channel[MainForm.form.tabControl1.SelectedIndex].Remove(0, 1)));
            PlayerInfo info = tuple.Item2;
            string wr = tuple.Item1;
            IRCconnect.sendPrivMsg("The world record for " + GetStrmInfo.GetGame(IRCconnect.MainIRC.Channel[MainForm.form.tabControl1.SelectedIndex].Remove(0, 1)) + " is " + wr + " by " + info.playerName + " (" + info.playerStream + ")");
        }
    }
}
