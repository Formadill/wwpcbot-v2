using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using wwpcbot_v2.Functionalities;
using wwpcbot_v2;

namespace wwpcbot_v2.IRC
{
    public struct IRCconnectInfo
    {
        public string IRCip;
        public int IRCport;
        public string BotNick;
        public string BotOwner;
        public string OAuthKey;
        public string Channel;
    }

    class IRCconnect
    {        
        public static bool ConnectToGroup;
        public static IRCconnectInfo MainIRC;
        public static TextReader input;
        public static TextWriter output;
        private static string __data;
        public static bool callCmdChk = false;
        public static messageInfo MsgInfo;
        
        public static string _data
        {
            get { return __data; }
            set {
                __data = value;
                if (callCmdChk == true)
                {
                    Functionality.CheckCmd(MainForm.form);
                }
                
            }
        }
        public static void connectMain()
        {
            MainForm form = MainForm.form;
            TcpClient mainClient = new TcpClient();
            mainClient.Connect(MainIRC.IRCip, MainIRC.IRCport);
            input = new StreamReader(mainClient.GetStream());
            output = new StreamWriter(mainClient.GetStream());
            sendData(
                "PASS " + MainIRC.OAuthKey + "\r\n" +
                "NICK " + MainIRC.BotNick + "\r\n"
            );    
        }

        public static void sendPrivMsg(string msg)
        {
            sendData("PRIVMSG " + MainIRC.Channel + " :" + msg + "\r\n");
        }

        public static async Task listener()
        {
            MainForm form = MainForm.form;
            try
            {
                string data;
                while ((data = await input.ReadLineAsync()) != null)
                {
                    _data = data;
                    MsgInfo = TwitchCap.getMessageInfo();                
                    form.AddToListBox(data);                  
                    if(data.Split(' ')[1] == "001")
                        sendData("CAP REQ :twitch.tv/commands" + "\r\n" +
                                 "MODE " + IRCconnect.MainIRC.BotNick + " +B\r\n" +
                                 "JOIN " + IRCconnect.MainIRC.Channel + "\r\n");
                    if (data.StartsWith("PING ")) { sendData(data.Replace("PING", "PONG") + "\r\n");}                            
                }
            }
            catch
            {
                Console.WriteLine("error");
            }
        }

        public static void sendData(string data)
        {
            output.WriteAsync(data);
            output.FlushAsync();
            MainForm.form.AddToListBox(data.Replace(Environment.NewLine, ""));
        }

        public static void connectGroup()
        {
        }
    }
}
