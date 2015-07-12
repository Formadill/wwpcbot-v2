using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using wwpcbot_v2;
using wwpcbot_v2.IRC;

namespace wwpcbot_v2.Functionalities
{
    class CustomCommands
    {
        private static string cmdFilePath = "Functionalities/Commands.txt";
        public static void mainControl(string commandInput)
        {
            if (commandInput.StartsWith("!addcommand "))
            {
                if (Functionality.TagBool)
                {
                    if (Functionality.info.user_type == "mod" || Functionality.Sender == IRCconnect.MainIRC.Channel.Remove(0, 1))
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
                    IRCconnect.sendPrivMsg(response);
                }
            }
        }

        public static void cmdAdd(string commandInput)
        {
            string toAdd = commandInput.Substring(commandInput.IndexOf(" ") + 1);
            using (FileStream fs = new FileStream(cmdFilePath, FileMode.Append, FileAccess.Write))
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine(toAdd);
            }
            IRCconnect.sendPrivMsg("Command added succesfully");
        }
    }
}
