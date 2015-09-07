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
            List<string> args = new List<string>();
            string response = null;
            string cmdfuncs = null;
            allow = true;
            command = commandInput;
            if (commandInput.Contains(" "))
            {
               
                command = commandInput.Substring(0, commandInput.IndexOf(" "));
                try
                {
                    string[] tmp = commandInput.Split(' ')[1].Split(' ');
                    foreach (string arg in tmp)
                    {
                        args.Add(arg);
                    }
                }
                catch
                {
                    args.Add(commandInput.Split(' ')[1]);
                }
            }
            using (var fs = new FileStream(cmdFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (StreamReader sr = new StreamReader(fs, Encoding.Default))
            {
                bool found = false;
                string line;
                
                while (!string.IsNullOrEmpty((line = sr.ReadLine())) && found == false)
                {
                    string[] tmp = line.Split(new[] { "=" }, 2, StringSplitOptions.None);
                    string stuff;
                    try
                    {
                        stuff = tmp[0].Split(' ')[0];
                        
                    }
                    catch
                    {
                        stuff = tmp[0];
                    }
                    if(stuff == command)
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
                    response = replaceCmdCalls(response, args);
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

        private static string replaceCmdCalls(string input, List<string> args)
        {
            string response = null;
            
            if (input.Contains("$readlinefromfile("))
                input = readfromfile(input);
            if (input.Contains("$arg["))
                input = cmdargs(input, args);
            if (input.Contains("$addlinetofile("))
                input = addtofile(input);
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
            string _options = readcmdargs(input, "$random(");
            string[] options = _options.Split(',');
            int index = random.Next(options.Length);
            output = options[index];
            return output;
        }

        private static string cmdargs(string input, List<string> args)
        {
            string output = null;
            int index = 0;
            foreach (string arg in args)
            {
                try
                {
                    output = input.Replace("$arg[" + index.ToString() + "]", args[index]);
                    index++;
                }
                catch { output = ""; }
            }
            return output;
        }

        private static string addtofile(string input)
        {
            string[] pars = (readcmdargs(input, "$addlinetofile(")).Split(',');
            string path = "Commands/" + pars[0];
            string text = pars[1];
            if (!File.Exists(path))
                File.Create(path);
            File.AppendAllText(path, text + Environment.NewLine);
            return "Added succesfully!";
        }

        private static string readfromfile(string input)
        {
            Random random = new Random();
            string[] pars = (readcmdargs(input, "$readlinefromfile(")).Split(',');
            string path = "Commands/" + pars[0];
            string _line = pars[1];
            int line;
            if (_line == "random")
            {
                line = random.Next(File.ReadLines(path).Count());
                Console.WriteLine(File.ReadLines(path).Count());
            }
            else
                line = Convert.ToInt32(_line);
            string text = File.ReadLines(path).Skip(line).Take(1).First();
            return text;
        }

        private static string readcmdargs(string input, string command)
        {
            string args = input.Substring(input.IndexOf(command) + command.Length);
            int count = args.Count(f => f == ')');
            args = args.Substring(0, GetNthIndex(args, ')', count));
            return args;
        }

        public static int GetNthIndex(string s, char t, int n)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == t)
                {
                    count++;
                    if (count == n)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
