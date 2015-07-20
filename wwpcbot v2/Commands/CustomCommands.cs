using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using wwpcbot_v2;
using wwpcbot_v2.IRC;

namespace wwpcbot_v2.Commands
{
    class CustomCommands
    {
        private static string cmdFilePath = "Commands/Commands.txt";
        public static void mainControl(string commandInput)
        {
            if (commandInput.StartsWith("!addcommand "))
            {
                if (Functionality.TagBool)
                {
                    if (Functionality.info.user_type == "mod" || Functionality.Sender == IRCconnect.MainIRC.Channel.Remove(0, 1) || Functionality.Sender == IRCconnect.MainIRC.BotOwner)
                    {
                        cmdAdd(commandInput);
                    }
                }
                else
                    cmdAdd(commandInput);
            }
            else
            {
                cmdReply(commandInput);
            }
        }

        public static void cmdReply(string commandInput)
        {
            string command;
            string response = null;
            
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
                    if(tmp[0] == command)
                    {
                        response = tmp[1];
                        found = true;
                    }
                }
                if(found == true)
                {
                    response = replaceCmdCalls(response);
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
