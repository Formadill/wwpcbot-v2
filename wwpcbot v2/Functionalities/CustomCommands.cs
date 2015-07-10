using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace wwpcbot_v2
{
    class CustomCommands
    {
        public static void cmdReply(string commandInput)
        {
            string command;
            string response = null;
            string cmdFilePath = "Commands.txt";
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
    }
}
