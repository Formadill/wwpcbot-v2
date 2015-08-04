using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using wwpcbot_v2;
using wwpcbot_v2.IRC;
using wwpcbot_v2.API;

namespace wwpcbot_v2.Commands
{
    class CustomCommands
    {
        private static string cmdFilePath = "Commands/Commands.txt";
        private static bool allow = true;
        public static void mainControl(string command)
        {
            if (command.StartsWith("!addcommand "))
            {
                if (TwitchCap.ack)
                {
                    if (CmdControl.info.user_type == "mod" || TwitchCap.Sender == IRCconnect.MainIRC.Channel[MainForm.form.tabControl1.SelectedIndex].Remove(0, 1) || TwitchCap.Sender == IRCconnect.MainIRC.BotOwner)
                    {
                        cmdAdd(command);
                    }
                }
                else
                    cmdAdd(command);
            }
            else
            {
                cmdReply(command);
            }
        }

        public static void cmdReply(string commandInput)
        {
            string command;
            string response = null;
            string cmdfuncs = null;
            allow = true;
            command = commandInput;
            if (commandInput.Contains(" "))
                command = commandInput.Substring(0, commandInput.IndexOf(" "));
            using (var fs = new FileStream(cmdFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (StreamReader sr = new StreamReader(fs, Encoding.Default))
            {
                bool found = false;
                string line;
                while (!string.IsNullOrEmpty((line = sr.ReadLine())) && found == false)
                {
                    string[] tmp = line.Split(new[] { "=" }, 2, StringSplitOptions.None);
                    if(tmp[0].StartsWith(command))
                    {
                        response = tmp[1];
                        cmdfuncs = tmp[0];
                        found = true;
                    }
                }
                if(found == true)
                {
                    if (cmdfuncs.Contains('-'))
                        cmdFuncs(cmdfuncs);
                    response = replaceCmdCalls(response);
                    if (allow)
                        IRCconnect.sendPrivMsg(response);
                }
            }
        }

        private static void cmdAdd(string commandInput)
        {
            string toAdd = commandInput.Substring(commandInput.IndexOf(" ") + 1);
            using (FileStream fs = new FileStream(cmdFilePath, FileMode.Append, FileAccess.Write))
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine(toAdd);
            }
            IRCconnect.sendPrivMsg("Command added succesfully");
        }

        private static string replaceCmdCalls(string input)
        {
            string response = null;
            if (input.Contains("$random("))
                input = random(input);
            if (input.Contains("$user"))
                input = input.Replace("$user", IRCconnect.MsgInfo.user);
            response = input;
            return response;
        }

        private static async void cmdFuncs(string _funcs)
        {
            string _func = _funcs.Substring(_funcs.IndexOf(' '));
            string[] funcs = _func.Replace("-", "").Split(' ');
            foreach (string func in funcs)
            {
                if (func == "m" && TwitchCap.ack)
                {
                    if (!(CmdControl.info.user_type == "mod" || TwitchCap.Sender == IRCconnect.MainIRC.Channel[MainForm.form.tabControl1.SelectedIndex].Remove(0, 1) || TwitchCap.Sender == IRCconnect.MainIRC.BotOwner))
                        allow = false;
                }
                else if (func.StartsWith("g"))
                {
                    string _id = func.Substring(func.IndexOf("g") + 1);
                    try
                    {
                        string game = await GetStrmInfo.GetGame(IRCconnect.MainIRC.Channel[MainForm.form.tabControl1.SelectedIndex].Remove(0, 1));
                        string id = await GetSpeedrunInfo.GetGameID(game);
                        if (_id != id)
                            allow = false;
                    }
                    catch
                    {

                    }
                }
            }
        }

        private static string random(string input)
        {
            string output = null;
            Random random = new Random();
            string _options = input.Substring(input.IndexOf("$random(") + 8);
            _options = _options.Substring(0, _options.IndexOf(")"));
            string[] options = _options.Split(',');
            int index = random.Next(options.Length);
            output = options[index];
            return output;
        }
    }
}
