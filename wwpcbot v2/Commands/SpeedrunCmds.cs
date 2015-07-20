﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wwpcbot_v2.SpeedruncomInfo;
using wwpcbot_v2.TwitchInfo;
using wwpcbot_v2.IRC;

namespace wwpcbot_v2.Commands
{
    class SpeedrunCmds
    {
        public static void SayCmds(string command)
        {
            if (command.StartsWith("!wr"))
                WRCmd();
        }

        private static void WRCmd()
        {
            var tuple = GetSpeedrunInfo.GetWR(GetStrmInfo.GetGame(IRCconnect.MainIRC.Channel.Remove(0, 1)));
            PlayerInfo info = tuple.Item2;
            string wr = tuple.Item1;
            IRCconnect.sendPrivMsg("The world record for " + GetStrmInfo.GetGame(IRCconnect.MainIRC.Channel.Remove(0, 1)) + " is " + wr  + " by " + info.playerName + " (" + info.playerStream + ")");
        }
    }
}
